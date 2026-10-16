using System;

namespace DCSSMeetingScheduler.Models {
    public class User {
        public string UserId { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public UserRole Role { get; set; } = UserRole.Student;
        public string Department { get; set; } = "DCSS";
        public string IdNumber { get; set; } = string.Empty; // Student No. or Employee No.
        public string ProgramOrTitle { get; set; } = string.Empty; // e.g. "BSCS 3-A" or "Assistant Professor III"
        public string Phone { get; set; } = string.Empty;
        public AccountStatus Status { get; set; } = AccountStatus.Active;
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public string DisplayRole => Role switch {
            UserRole.Student => "Student",
            UserRole.Faculty => "Faculty Member",
            UserRole.Admin => "Administrator",
            _ => "User"
        };
    }
}
