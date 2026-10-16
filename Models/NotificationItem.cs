using System;

namespace DCSSMeetingScheduler.Models {
    public class NotificationItem {
        public string NotificationId { get; set; } = Guid.NewGuid().ToString("N")[..8];
        public string UserId { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public DateTime Timestamp { get; set; } = DateTime.Now;
        public bool IsRead { get; set; } = false;
        public MeetingStatus? RelatedStatus { get; set; }

        public string DisplayTime {
            get {
                var span = DateTime.Now - Timestamp;
                if (span.TotalMinutes < 1) return "Just now";
                if (span.TotalMinutes < 60) return $"{(int)span.TotalMinutes}m ago";
                if (span.TotalHours < 24) return $"{(int)span.TotalHours}h ago";
                if (span.TotalDays < 7) return $"{(int)span.TotalDays}d ago";
                return Timestamp.ToString("MMM dd, yyyy");
            }
        }
    }
}
