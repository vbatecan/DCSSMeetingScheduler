using System.Drawing;

namespace DCSSMeetingScheduler.UI.Common {
    public static class ThemeColors {
        // Primary Red Palette (UE-Inspired Academic Red)
        public static readonly Color PrimaryRed = Color.FromArgb(163, 29, 36);      // #A31D24 Deep University Red
        public static readonly Color PrimaryRedDark = Color.FromArgb(127, 20, 26);  // #7F141A Sidebar / Deep Tone
        public static readonly Color PrimaryRedLight = Color.FromArgb(186, 38, 47); // #BA262F Button Hover
        public static readonly Color PrimaryRedAccent = Color.FromArgb(217, 48, 59);// #D9303B Active Highlighting

        // Sidebar Specifics
        public static readonly Color SidebarBackground = Color.FromArgb(127, 20, 26);
        public static readonly Color SidebarActiveItem = Color.FromArgb(163, 29, 36);
        public static readonly Color SidebarHover = Color.FromArgb(145, 23, 30);
        public static readonly Color SidebarText = Color.FromArgb(255, 255, 255);
        public static readonly Color SidebarTextMuted = Color.FromArgb(243, 200, 203);

        // White & Light Grays
        public static readonly Color White = Color.FromArgb(255, 255, 255);
        public static readonly Color CanvasBackground = Color.FromArgb(249, 250, 251); // #F9FAFB
        public static readonly Color CardBackground = Color.FromArgb(255, 255, 255);
        public static readonly Color LightGray = Color.FromArgb(243, 244, 246);        // #F3F4F6
        public static readonly Color BorderGray = Color.FromArgb(229, 231, 235);        // #E5E7EB
        public static readonly Color BorderGrayMedium = Color.FromArgb(209, 213, 219);  // #D1D5DB

        // Light Red Highlights
        public static readonly Color LightRed = Color.FromArgb(253, 242, 242);         // #FDF2F2
        public static readonly Color LightRedBorder = Color.FromArgb(248, 180, 180);   // #F8B4B4
        public static readonly Color LightRedBadge = Color.FromArgb(254, 226, 226);    // #FEE2E2

        // Dark Grays (Typography)
        public static readonly Color TextDark = Color.FromArgb(17, 24, 39);            // #111827
        public static readonly Color TextRegular = Color.FromArgb(55, 65, 81);         // #374151
        public static readonly Color TextMuted = Color.FromArgb(107, 114, 128);        // #6B7280

        // Status Badges (Used sparingly)
        public static readonly Color StatusApprovedBg = Color.FromArgb(222, 247, 236);
        public static readonly Color StatusApprovedText = Color.FromArgb(3, 84, 63);

        public static readonly Color StatusPendingBg = Color.FromArgb(254, 243, 199);
        public static readonly Color StatusPendingText = Color.FromArgb(146, 64, 14);

        public static readonly Color StatusRescheduledBg = Color.FromArgb(254, 240, 222);
        public static readonly Color StatusRescheduledText = Color.FromArgb(180, 83, 9);

        public static readonly Color StatusDeclinedBg = Color.FromArgb(254, 226, 226);
        public static readonly Color StatusDeclinedText = Color.FromArgb(155, 28, 28);

        public static readonly Color StatusCancelledBg = Color.FromArgb(243, 244, 246);
        public static readonly Color StatusCancelledText = Color.FromArgb(75, 85, 99);

        public static readonly Color StatusCompletedBg = Color.FromArgb(229, 231, 235);
        public static readonly Color StatusCompletedText = Color.FromArgb(31, 41, 55);

        public static readonly Color StatusActiveBg = Color.FromArgb(222, 247, 236);
        public static readonly Color StatusActiveText = Color.FromArgb(3, 84, 63);

        public static readonly Color StatusInactiveBg = Color.FromArgb(243, 244, 246);
        public static readonly Color StatusInactiveText = Color.FromArgb(107, 114, 128);
    }
}
