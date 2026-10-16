using System.Text.RegularExpressions;

namespace DCSSMeetingScheduler
{
    public class LoginUtils
    {
        
        public static bool ValidateEmail(string email)
        {
            // Should be ue.edu.ph email address
            return Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@ue\.edu\.ph$");
        }

        public static bool ValidatePassword(string password)
        {
            return password.Length >= 6;
        }
    }
}