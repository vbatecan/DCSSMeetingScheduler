namespace DCSSMeetingScheduler
{
    public class SignUpUtil
    {
        public static string ValidateSignUp(string firstName, string lastName, string email, string role, string programOrDept, string password, string confirmPassword)
        {
            if (string.IsNullOrEmpty(firstName))
            {
                return "Please enter your first name.";
            }

            if (string.IsNullOrEmpty(lastName))
            {
                return "Please enter your last name.";
            }

            if (string.IsNullOrEmpty(email))
            {
                return "Please enter your UE email.";
            }

            if (!LoginUtils.ValidateEmail(email))
            {
                return "Please enter a valid UE email (e.g. name@ue.edu.ph).";
            }

            if (string.IsNullOrEmpty(role))
            {
                return "Please select a role.";
            }

            if (string.IsNullOrEmpty(programOrDept))
            {
                return "Please select a program or department.";
            }

            if (string.IsNullOrEmpty(password))
            {
                return "Please enter a password.";
            }

            if (password.Length < 8)
            {
                return "Password must be at least 8 characters long.";
            }

            if (password != confirmPassword)
            {
                return "Passwords do not match.";
            }

            return string.Empty;
        }

        public static string ValidateSignUpForm(string firstName, string lastName, string email, string role, string programOrDept, string password, string confirmPassword)
        {
            return ValidateSignUp(firstName, lastName, email, role, programOrDept, password, confirmPassword);
        }

        public static string ValidateSignUpForm(User user)
        {
            if (user == null)
            {
                return "User cannot be null.";
            }

            if (string.IsNullOrEmpty(user.FirstName))
            {
                return "Please enter your first name.";
            }

            if (string.IsNullOrEmpty(user.LastName))
            {
                return "Please enter your last name.";
            }

            if (string.IsNullOrEmpty(user.UeEmail))
            {
                return "Please enter your UE email.";
            }

            if (!LoginUtils.ValidateEmail(user.UeEmail))
            {
                return "Please enter a valid UE email (e.g. name@ue.edu.ph).";
            }

            if (string.IsNullOrEmpty(user.ProgramOrDept))
            {
                return "Please select a program or department.";
            }

            if (string.IsNullOrEmpty(user.UserPassword))
            {
                return "Please enter a password.";
            }

            if (user.UserPassword.Length < 8)
            {
                return "Password must be at least 8 characters long.";
            }

            return string.Empty;
        }
    }
}