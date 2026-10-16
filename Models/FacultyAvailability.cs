using System;
using System.Collections.Generic;

namespace DCSSMeetingScheduler.Models {
    public class FacultyAvailability {
        public string FacultyId { get; set; } = string.Empty;
        public List<DayOfWeek> AvailableDays { get; set; } = new() {
            DayOfWeek.Monday,
            DayOfWeek.Wednesday,
            DayOfWeek.Friday
        };
        public string StartTime { get; set; } = "09:00 AM";
        public string EndTime { get; set; } = "04:00 PM";
        public int MaxMeetingsPerDay { get; set; } = 4;
        public MeetingType PreferredMode { get; set; } = MeetingType.FaceToFace;
        public string DefaultLocation { get; set; } = "Tan Yan Kee Academic Building, 4th Flr Faculty Rm";
        public string OnlineMeetingPlatform { get; set; } = "Google Meet (UE GSuite link will be emailed)";
        public string ConsultationNotes { get; set; } = "Please bring capstone documentation or course syllabus when attending consultation.";
    }
}
