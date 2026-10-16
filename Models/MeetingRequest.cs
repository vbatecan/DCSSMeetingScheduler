using System;

namespace DCSSMeetingScheduler.Models {
    public class MeetingRequest {
        public string RequestId { get; set; } = string.Empty;
        public string StudentId { get; set; } = string.Empty;
        public string StudentName { get; set; } = string.Empty;
        public string StudentEmail { get; set; } = string.Empty;
        public string StudentProgram { get; set; } = string.Empty;

        public string FacultyId { get; set; } = string.Empty;
        public string FacultyName { get; set; } = string.Empty;
        public string FacultyEmail { get; set; } = string.Empty;

        public string Subject { get; set; } = string.Empty;
        public string Purpose { get; set; } = string.Empty;
        public DateTime PreferredDate { get; set; } = DateTime.Today.AddDays(1);
        public string PreferredTime { get; set; } = "10:00 AM";
        public MeetingType MeetingType { get; set; } = MeetingType.FaceToFace;
        public string LocationOrLink { get; set; } = "Faculty Room (Tan Yan Kee Bldg, 4th Flr)";

        public MeetingStatus Status { get; set; } = MeetingStatus.Pending;

        public DateTime? ScheduledDate { get; set; }
        public string? ScheduledTime { get; set; }

        public string? FacultyNotes { get; set; }
        public string? RescheduleReason { get; set; }
        public string? DeclineReason { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public string DisplayScheduledDate => ScheduledDate.HasValue 
            ? ScheduledDate.Value.ToString("MMM dd, yyyy") 
            : PreferredDate.ToString("MMM dd, yyyy");

        public string DisplayScheduledTime => !string.IsNullOrEmpty(ScheduledTime) 
            ? ScheduledTime 
            : PreferredTime;

        public string DisplayMeetingType => MeetingType == MeetingType.FaceToFace 
            ? "Face-to-face" 
            : "Online (Virtual)";
    }
}
