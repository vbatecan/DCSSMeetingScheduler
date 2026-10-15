namespace DCSSMeetingScheduler {
    public partial class LoginForm : Form {
        public LoginForm() {
            InitializeComponent();
        }

        private void btnLogin_Click(object? sender, EventArgs e) {
            lblErrorMessage.Text = "";

            if (txtEmail.Text.Trim() == "") {
                lblErrorMessage.Text = "Please enter your UE email.";
                txtEmail.Focus();
                return;
            }

            if (txtPassword.Text == "") {
                lblErrorMessage.Text = "Please enter your password.";
                txtPassword.Focus();
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object? sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void chkShowPassword_CheckedChanged(object? sender, EventArgs e) {
            if (chkShowPassword.Checked) {
                txtPassword.UseSystemPasswordChar = false;
            } else {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
