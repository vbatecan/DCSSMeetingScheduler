using System;
using DCSSMeetingScheduler.Models;

namespace DCSSMeetingScheduler.Services {
    public static class SessionManager {
        public static User? CurrentUser { get; private set; }

        public static event EventHandler? UserChanged;

        public static bool IsLoggedIn => CurrentUser != null;

        public static void SetSession(User user) {
            CurrentUser = user;
            UserChanged?.Invoke(null, EventArgs.Empty);
        }

        public static void ClearSession() {
            CurrentUser = null;
            UserChanged?.Invoke(null, EventArgs.Empty);
        }
    }
}
