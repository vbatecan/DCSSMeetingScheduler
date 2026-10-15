using DCSSMeetingScheduler.Shared;
using MySqlConnector;

namespace DCSSMeetingScheduler
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object? sender, EventArgs e)
        {
            lblErrorMessage.Text = "";

            if (txtEmail.Text.Trim() == "")
            {
                lblErrorMessage.Text = "Please enter your UE email.";
                txtEmail.Focus();
                return;
            }

            if (txtPassword.Text == "")
            {
                lblErrorMessage.Text = "Please enter your password.";
                txtPassword.Focus();
                return;
            }

            using (MySqlConnection conn = Connection.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT ue_email, password, role FROM users WHERE ue_email = @email AND password = @password", conn);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        string email = reader.GetString("ue_email");
                        string password = reader.GetString("password");

                        if (email.Equals(txtEmail.Text, StringComparison.OrdinalIgnoreCase) && password == txtPassword.Text)
                        {
                            // Dito yung login successful.
                            UserRole userRole = (UserRole)Enum.Parse(typeof(UserRole), reader.GetString("role"));
                            switch (userRole)
                            {
                                case UserRole.Admin:
                                    break;
                                case UserRole.Faculty:
                                    break;
                                case UserRole.Student:
                                    break;
                            }
                        }
                        else
                        {
                            lblErrorMessage.Text = "Invalid email or password.";
                            return;
                        }

                    }
                }
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void chkShowPassword_CheckedChanged(object? sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnChangePassword_Click(object? sender, EventArgs e)
        {
            ChangePassword.ChangePasswordForm changePasswordForm = new ChangePassword.ChangePasswordForm();
            changePasswordForm.ShowDialog();
        }
    }
}
