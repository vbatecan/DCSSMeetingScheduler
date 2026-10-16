using MySqlConnector;
using System;

namespace DCSSMeetingScheduler
{
    public class User
    {
        private int user_id;
        private string ue_email;
        private string user_password;
        private string first_name;
        private string last_name;
        private UserRole role;
        private string id_number;
        private string program_or_dept;
        private bool is_active;
        private bool must_change_password;
        private DateTime created_at;

        public User()
        {
            ue_email = string.Empty;
            user_password = string.Empty;
            first_name = string.Empty;
            last_name = string.Empty;
            id_number = string.Empty;
            program_or_dept = string.Empty;
        }

        public User(int user_id, string ue_email, string user_password, string first_name, string last_name, UserRole role, string id_number, string program_or_dept, bool is_active, bool must_change_password, DateTime created_at)
        {
            this.user_id = user_id;
            this.ue_email = ue_email;
            this.user_password = user_password;
            this.first_name = first_name;
            this.last_name = last_name;
            this.role = role;
            this.id_number = id_number;
            this.program_or_dept = program_or_dept;
            this.is_active = is_active;
            this.must_change_password = must_change_password;
            this.created_at = created_at;
        }

        public static User FromReader(MySqlDataReader reader)
        {
            return new User(
                reader.GetInt32("user_id"),
                reader.GetString("ue_email"),
                reader.GetString("user_password"),
                reader.GetString("first_name"),
                reader.GetString("last_name"),
                Enum.Parse<UserRole>(reader.GetString("role")),
                reader.GetString("id_number"),
                reader.GetString("program_or_dept"),
                reader.GetBoolean("is_active"),
                reader.GetBoolean("must_change_password"),
                reader.GetDateTime("created_at")
            );
        }

        public int UserId { get => user_id; set => user_id = value; }
        public string UeEmail { get => ue_email; set => ue_email = value; }
        public string UserPassword { get => user_password; set => user_password = value; }
        public string FirstName { get => first_name; set => first_name = value; }
        public string LastName { get => last_name; set => last_name = value; }
        public UserRole Role { get => role; set => role = value; }
        public string IdNumber { get => id_number; set => id_number = value; }
        public string ProgramOrDept { get => program_or_dept; set => program_or_dept = value; }
        public bool IsActive { get => is_active; set => is_active = value; }
        public bool MustChangePassword { get => must_change_password; set => must_change_password = value; }
        public DateTime CreatedAt { get => created_at; set => created_at = value; }
    }
}
