using MySqlConnector;
using DCSSMeetingScheduler.Shared;
namespace DCSSMeetingScheduler.Forms.Student;
public partial class StudentForm
{
    private string SettingsFile => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "DCSSMeetingScheduler", $"student-{loggedUser!.UserId}.json");
    private sealed class Preferences
    {
        public int Tab { get; set; }
        public int Year { get; set; }
        public string Section { get; set; } = "";
        public bool Recent { get; set; } = true;
        public bool Upcoming { get; set; } = true;
        public bool Status { get; set; } = true;
    }
    private Preferences saved = new();
    private void InitializeSettings()
    {
        cmbDefaultTab.Items.Clear();
        cmbDefaultTab.Items.AddRange(new object[] { "Home", "Request a Meeting", "Settings" });
        cmbDefaultTab.DropDownStyle = ComboBoxStyle.DropDownList;
        try
        {
            if (loggedUser != null && File.Exists(SettingsFile))
                saved = System.Text.Json.JsonSerializer.Deserialize<Preferences>(File.ReadAllText(SettingsFile)) ?? new();
        }
        catch (Exception ex) when (ex is IOException or UnauthorizedAccessException or System.Text.Json.JsonException)
        { MessageBox.Show("Unable to load settings: " + ex.Message); }
        RestoreSettings();
        tabStudent.SelectedIndex = cmbDefaultTab.SelectedIndex;
        lblVersion.Text = "Version: " + Application.ProductVersion;
        lblLastLogin.Text = "Last Login: " + DateTime.Now.ToString("g");
        chkEmailNotifications.Enabled = false;
        chkEmailNotifications.Text = "Email notifications (service unavailable)";
        chkConsultationReminders.Enabled = false;
        chkConsultationReminders.Text = "Consultation reminders (service unavailable)";
        btnSavePreferences.Click += (_, _) => SaveSettings();
        btnResetPreferences.Click += (_, _) => RestoreSettings();
        btnCancelSettings.Click += (_, _) => RestoreSettings();
        btnChangePassword.Click += ChangePassword;
    }
    private void RestoreSettings()
    {
        cmbDefaultTab.SelectedIndex = Math.Clamp(saved.Tab, 0, 2);
        cmbYearLevel.SelectedIndex = Math.Clamp(saved.Year, 0, 3);
        textBox1.Text = saved.Section;
        chkShowRecentRequests.Checked = saved.Recent;
        chkShowUpcomingMeetings.Checked = saved.Upcoming;
        chkStatusNotifications.Checked = saved.Status;
        pnlRequestsHeader.Visible = saved.Recent;
        tableLayoutPanel1.Visible = saved.Upcoming;
        pnlNotification.Visible = saved.Status;
    }
    private void SaveSettings()
    {
        if (loggedUser == null) return;
        var next = new Preferences { Tab = cmbDefaultTab.SelectedIndex, Year = cmbYearLevel.SelectedIndex,
            Section = textBox1.Text.Trim(), Recent = chkShowRecentRequests.Checked,
            Upcoming = chkShowUpcomingMeetings.Checked, Status = chkStatusNotifications.Checked };
        try
        {
            Directory.CreateDirectory(Path.GetDirectoryName(SettingsFile)!);
            File.WriteAllText(SettingsFile + ".tmp", System.Text.Json.JsonSerializer.Serialize(next));
            File.Move(SettingsFile + ".tmp", SettingsFile, true);
            saved = next;
            RestoreSettings();
            MessageBox.Show("Settings saved on this device.");
        }
        catch (Exception ex) when (ex is IOException or UnauthorizedAccessException)
        { MessageBox.Show("Unable to save settings: " + ex.Message); }
    }
    private void ChangePassword(object? sender, EventArgs e)
    {
        if (loggedUser == null) return;
        string password = txtNewPassword.Text;
        if (password.Length < 6 || password != txtConfirmNewPassword.Text || password == txtCurrentPassword.Text)
        { MessageBox.Show("Use a new password of at least 6 characters and matching confirmation."); return; }
        try
        {
            using var conn = Connection.GetConnection();
            using var cmd = new MySqlCommand("UPDATE users SET user_password = @new, must_change_password = 0 WHERE user_id = @id AND BINARY user_password = BINARY @current", conn);
            cmd.Parameters.AddWithValue("@new", password);
            cmd.Parameters.AddWithValue("@current", txtCurrentPassword.Text);
            cmd.Parameters.AddWithValue("@id", loggedUser.UserId);
            if (cmd.ExecuteNonQuery() != 1) { MessageBox.Show("Current password is incorrect."); return; }
            loggedUser.UserPassword = password;
            loggedUser.MustChangePassword = false;
            txtCurrentPassword.Clear(); txtNewPassword.Clear(); txtConfirmNewPassword.Clear();
            MessageBox.Show("Password changed successfully.");
        }
        catch (MySqlException ex) { MessageBox.Show("Unable to change password: " + ex.Message); }
    }
}

