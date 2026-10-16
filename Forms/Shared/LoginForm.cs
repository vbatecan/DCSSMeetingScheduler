using System.Data;
using System.Text.RegularExpressions;
using DCSSMeetingScheduler.Admin;
using DCSSMeetingScheduler.Faculty;
using DCSSMeetingScheduler.Shared;
using DCSSMeetingScheduler.Student;
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
            if (!LoginUtils.ValidateEmail(txtEmail.Text))
            {
                lblErrorMessage.Text = "Please enter a valid UE email.";
                txtEmail.Focus();
                return;
            }

            if (LoginUtils.ValidatePassword(txtPassword.Text) == false)
            {
                lblErrorMessage.Text = "Please enter your password.";
                txtPassword.Focus();
                return;
            }

            using (MySqlConnection conn = Connection.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM users WHERE ue_email = @email AND user_password = @password", conn);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                using (MySqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow))
                {
                    if (reader.Read())
                    {
                        User user = User.FromReader(reader);

                        if (user.UeEmail.Equals(txtEmail.Text, StringComparison.OrdinalIgnoreCase) && user.UserPassword == txtPassword.Text)
                        {
                            // Dito yung login successful.
                            Hide();
                            switch (user.Role)
                            {
                                case UserRole.Admin:
                                    AdminForm adminForm = new AdminForm(user);
                                    adminForm.Show();
                                    break;
                                case UserRole.Faculty:
                                    faculty facultyForm = new faculty(user);
                                    facultyForm.Show();
                                    break;
                                case UserRole.Student:
                                    StudentForm studentForm = new StudentForm(user);
                                    studentForm.Show();
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

        private void lnkForgotPassword_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangePassword.ChangePasswordForm changePasswordForm = new ChangePassword.ChangePasswordForm();
            changePasswordForm.ShowDialog();
        }

        private void lnkSignUp_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            Hide();
            DialogResult result = signUpForm.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrEmpty(signUpForm.RegisteredEmail))
            {
                txtEmail.Text = signUpForm.RegisteredEmail;
                txtPassword.Clear();
                txtPassword.Focus();
            }
            Show();
        }
    }
}
