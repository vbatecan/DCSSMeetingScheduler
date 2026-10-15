namespace DCSSMeetingScheduler {
    public partial class LoginForm : Form {
        public LoginForm() {
            InitializeComponent();
        }

        public string Email => txtEmail.Text.Trim();
        public string Password => txtPassword.Text;

        private void btnLogin_Click(object? sender, EventArgs e) {
            lblErrorMessage.Text = string.Empty;

            if (string.IsNullOrWhiteSpace(txtEmail.Text)) {
                lblErrorMessage.Text = "Please enter your UE email.";
                txtEmail.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtPassword.Text)) {
                lblErrorMessage.Text = "Please enter your password.";
                txtPassword.Focus();
                return;
            }

            // Authentication logic placeholder:
            // Set DialogResult to OK so caller can proceed.
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object? sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void chkShowPassword_CheckedChanged(object? sender, EventArgs e) {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }
    }
}
