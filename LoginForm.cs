namespace DCSSMeetingScheduler {
    public partial class LoginForm : Form {
        public LoginForm() {
            InitializeComponent();
        }

        public string Username => txtUsername.Text.Trim();
        public string Password => txtPassword.Text;

        private void btnLogin_Click(object? sender, EventArgs e) {
            lblErrorMessage.Text = "";

            if (string.IsNullOrWhiteSpace(txtUsername.Text)) {
                lblErrorMessage.Text = "Please enter your username.";
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtPassword.Text)) {
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
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }
    }
}
