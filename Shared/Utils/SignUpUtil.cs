

namespace DCSSMeetingScheduler
{
    
    public class SignUpUtil
    {
        
        public static void ValidateSignUpForm(User user)
        {
            if (string.IsNullOrEmpty(firstName))
            {
                lblErrorMessage.Text = "Please enter your first name.";
                txtFirstName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(lastName))
            {
                lblErrorMessage.Text = "Please enter your last name.";
                txtLastName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(email))
            {
                lblErrorMessage.Text = "Please enter your UE email.";
                txtEmail.Focus();
                return;
            }

            if (!LoginUtils.ValidateEmail(email))
            {
                lblErrorMessage.Text = "Please enter a valid UE email (e.g. name@ue.edu.ph).";
                txtEmail.Focus();
                return;
            }

            if (string.IsNullOrEmpty(role))
            {
                lblErrorMessage.Text = "Please select a role.";
                cmbRole.Focus();
                return;
            }

            if (string.IsNullOrEmpty(programOrDept))
            {
                lblErrorMessage.Text = "Please select a program or department.";
                cmbProgramOrDept.Focus();
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                lblErrorMessage.Text = "Please enter a password.";
                txtPassword.Focus();
                return;
            }

            if (password.Length < 8)
            {
                lblErrorMessage.Text = "Password must be at least 8 characters long.";
                txtPassword.Focus();
                return;
            }

            if (password != confirmPassword)
            {
                lblErrorMessage.Text = "Passwords do not match.";
                txtConfirmPassword.Focus();
                return;
            }

        }
    }
}