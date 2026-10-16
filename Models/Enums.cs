using System;

namespace DCSSMeetingScheduler.Models {
    public enum UserRole {
        Student,
        Faculty,
        Admin
    }

    public enum MeetingStatus {
        Pending,
        Approved,
        Rescheduled,
        Declined,
        Cancelled,
        Completed
    }

    public enum MeetingType {
        FaceToFace,
        Online
    }

    public enum AccountStatus {
        Active,
        Inactive
    }
}
