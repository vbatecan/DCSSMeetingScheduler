using System;
using System.Collections.Generic;
using DCSSMeetingScheduler.Models;

namespace DCSSMeetingScheduler.Services {
    public interface IDataService {
        // Authentication
        User? Authenticate(string email, string password);

        // Users
        List<User> GetAllUsers();
        List<User> GetFacultyMembers();
        User? GetUserById(string userId);
        bool CreateUser(User user);
        bool UpdateUser(User user);
        bool ToggleUserStatus(string userId);
        bool ResetPassword(string userId, string newPassword);

        // Meetings
        List<MeetingRequest> GetAllMeetings();
        List<MeetingRequest> GetMeetingsForStudent(string studentId);
        List<MeetingRequest> GetMeetingsForFaculty(string facultyId);
        MeetingRequest? GetMeetingById(string requestId);
        bool CreateMeetingRequest(MeetingRequest request);
        bool ApproveMeeting(string requestId, string? facultyNotes, string? locationOrLink);
        bool RescheduleMeeting(string requestId, DateTime newDate, string newTime, string reason);
        bool DeclineMeeting(string requestId, string reason);
        bool CancelMeeting(string requestId);
        bool CompleteMeeting(string requestId);

        // Notifications
        List<NotificationItem> GetNotificationsForUser(string userId);
        int GetUnreadNotificationCount(string userId);
        void MarkNotificationAsRead(string notificationId);
        void MarkAllNotificationsAsRead(string userId);
        void AddNotification(NotificationItem notification);

        // Faculty Availability
        FacultyAvailability GetFacultyAvailability(string facultyId);
        void SaveFacultyAvailability(FacultyAvailability availability);

        // Stats
        (int pending, int approved, int rescheduled, int declined) GetStudentStats(string studentId);
        (int total, int pending, int approved, int declined, int completed) GetFacultyStats(string facultyId);
        (int totalUsers, int totalStudents, int totalFaculty, int totalMeetings) GetAdminStats();

        // Event for UI data synchronization
        event EventHandler? DataChanged;
    }
}
