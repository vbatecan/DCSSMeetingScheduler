using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using DCSSMeetingScheduler.Models;
using DCSSMeetingScheduler.Services;
using DCSSMeetingScheduler.UI.Common;
using DCSSMeetingScheduler.UI.Views.Admin;
using DCSSMeetingScheduler.UI.Views.Faculty;
using DCSSMeetingScheduler.UI.Views.Student;

namespace DCSSMeetingScheduler.UI.Forms {
    public class MainShellForm : Form {
        private readonly IDataService _dataService = MockDataStore.Instance;

        private readonly Panel _pnlTopBar = new();
        private readonly Panel _pnlSidebar = new();
        private readonly Panel _pnlNavButtons = new();
        private readonly Panel _pnlContent = new();

        private readonly Label _lblTopTitle = new();
        private readonly Label _lblTopUser = new();
        private readonly Label _lblTopRole = new();
        private readonly ComboBox _cbRoleSwitcher = new();

        private readonly List<NavButtonInfo> _navButtons = new();
        private string _activeNavKey = "Home";

        private class NavButtonInfo {
            public string Key { get; set; } = string.Empty;
            public string Label { get; set; } = string.Empty;
            public string IconGlyph { get; set; } = string.Empty;
            public Button ButtonControl { get; set; } = null!;
            public Func<UserControl> ViewFactory { get; set; } = null!;
        }

        public MainShellForm() {
            DoubleBuffered = true;
            InitializeComponent();
            SetupNavigationForRole();
            NavigateTo("Home");

            _dataService.DataChanged += (s, e) => {
                if (!IsDisposed && IsHandleCreated) {
                    BeginInvoke(new Action(UpdateTopBarUserInfo));
                }
            };
        }

        private void InitializeComponent() {
            Text = "DCSS Faculty and Student Meeting Scheduler - University of the East Caloocan";
            Size = new Size(1280, 800);
            MinimumSize = new Size(1024, 680);
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = ThemeColors.CanvasBackground;

            // 1. Top Header Bar
            _pnlTopBar.Dock = DockStyle.Top;
            _pnlTopBar.Height = 65;
            _pnlTopBar.BackColor = ThemeColors.White;
            _pnlTopBar.Padding = new Padding(20, 10, 24, 10);
            _pnlTopBar.Paint += (s, e) => {
                using var pen = new Pen(ThemeColors.BorderGray, 1);
                e.Graphics.DrawLine(pen, 0, _pnlTopBar.Height - 1, _pnlTopBar.Width, _pnlTopBar.Height - 1);
            };

            // Top Bar Left: UE & DCSS Brand
            var lblBrandUni = new Label {
                Text = "UNIVERSITY OF THE EAST • CALOOCAN CAMPUS",
                Font = new Font("Segoe UI", 8F, FontStyle.Bold),
                ForeColor = ThemeColors.PrimaryRed,
                Location = new Point(20, 12),
                AutoSize = true
            };
            _pnlTopBar.Controls.Add(lblBrandUni);

            _lblTopTitle.Text = "DCSS Faculty & Student Meeting Scheduler";
            _lblTopTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            _lblTopTitle.ForeColor = ThemeColors.TextDark;
            _lblTopTitle.Location = new Point(20, 30);
            _lblTopTitle.AutoSize = true;
            _pnlTopBar.Controls.Add(_lblTopTitle);

            // Top Bar Right: User profile pill & quick role switcher
            var pnlUserCard = new Panel {
                Size = new Size(420, 48),
                Location = new Point(_pnlTopBar.Width - 440, 8),
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                BackColor = ThemeColors.LightGray
            };
            pnlUserCard.Paint += (s, e) => {
                var g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                var user = SessionManager.CurrentUser;
                string initials = user != null && !string.IsNullOrEmpty(user.FullName)
                    ? string.Concat(user.FullName.Split(' ').Where(w => !string.IsNullOrEmpty(w) && !w.EndsWith(".")).Take(2).Select(w => w[0]))
                    : "UE";

                // Avatar circle
                var avRect = new Rectangle(8, 6, 36, 36);
                using (var brush = new SolidBrush(ThemeColors.PrimaryRed)) {
                    g.FillEllipse(brush, avRect);
                }
                using (var font = new Font("Segoe UI", 10.5F, FontStyle.Bold))
                using (var textBrush = new SolidBrush(ThemeColors.White)) {
                    var sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                    g.DrawString(initials.ToUpperInvariant(), font, textBrush, avRect, sf);
                }

                // Border
                using (var pen = new Pen(ThemeColors.BorderGrayMedium, 1)) {
                    g.DrawRectangle(pen, 0, 0, pnlUserCard.Width - 1, pnlUserCard.Height - 1);
                }
            };

            _lblTopUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            _lblTopUser.ForeColor = ThemeColors.TextDark;
            _lblTopUser.Location = new Point(52, 6);
            _lblTopUser.AutoSize = true;
            pnlUserCard.Controls.Add(_lblTopUser);

            _lblTopRole.Font = new Font("Segoe UI", 8F);
            _lblTopRole.ForeColor = ThemeColors.PrimaryRedDark;
            _lblTopRole.Location = new Point(52, 26);
            _lblTopRole.AutoSize = true;
            pnlUserCard.Controls.Add(_lblTopRole);

            // Role Switcher Dropdown (Allows instant switching to demo student, faculty, admin)
            var lblSwitch = new Label {
                Text = "Switch View:",
                Font = new Font("Segoe UI", 8F, FontStyle.Bold),
                ForeColor = ThemeColors.TextMuted,
                Location = new Point(220, 6),
                AutoSize = true
            };
            pnlUserCard.Controls.Add(lblSwitch);

            _cbRoleSwitcher.Location = new Point(220, 22);
            _cbRoleSwitcher.Size = new Size(130, 22);
            _cbRoleSwitcher.Items.AddRange(new object[] { "Student Demo", "Faculty Demo", "Admin Demo" });
            _cbRoleSwitcher.SelectedIndexChanged += OnRoleSwitcherChanged;
            UIHelper.StyleComboBox(_cbRoleSwitcher);
            pnlUserCard.Controls.Add(_cbRoleSwitcher);

            var btnLogoutTop = new Button {
                Text = "Logout",
                Location = new Point(356, 10),
                Size = new Size(56, 28)
            };
            UIHelper.StyleSecondaryButton(btnLogoutTop);
            btnLogoutTop.Click += (s, e) => Close();
            pnlUserCard.Controls.Add(btnLogoutTop);

            _pnlTopBar.Controls.Add(pnlUserCard);
            Controls.Add(_pnlTopBar);

            // 2. Left Sidebar (Deep Red)
            _pnlSidebar.Dock = DockStyle.Left;
            _pnlSidebar.Width = 240;
            _pnlSidebar.BackColor = ThemeColors.SidebarBackground;
            _pnlSidebar.Padding = new Padding(0);

            // Sidebar Header (Logo & DCSS Brand)
            var pnlSidebarHeader = new Panel {
                Dock = DockStyle.Top,
                Height = 85,
                BackColor = ThemeColors.SidebarBackground
            };
            pnlSidebarHeader.Paint += (s, e) => {
                var g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                // UE Emblem circle
                var emblemRect = new Rectangle(20, 18, 48, 48);
                using (var brush = new SolidBrush(ThemeColors.White)) {
                    g.FillEllipse(brush, emblemRect);
                }
                using (var font = new Font("Segoe UI", 15F, FontStyle.Bold))
                using (var brush = new SolidBrush(ThemeColors.PrimaryRedDark)) {
                    var sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                    g.DrawString("UE", font, brush, emblemRect, sf);
                }

                // Text
                using (var font = new Font("Segoe UI", 11F, FontStyle.Bold))
                using (var brush = new SolidBrush(ThemeColors.White)) {
                    g.DrawString("DCSS PORTAL", font, brush, 78, 20);
                }

                using (var font = new Font("Segoe UI", 8F))
                using (var brush = new SolidBrush(ThemeColors.SidebarTextMuted)) {
                    g.DrawString("Meeting Scheduler\nCaloocan Campus", font, brush, 78, 40);
                }

                // Divider line
                using (var pen = new Pen(ThemeColors.SidebarHover, 1)) {
                    g.DrawLine(pen, 16, pnlSidebarHeader.Height - 1, _pnlSidebar.Width - 16, pnlSidebarHeader.Height - 1);
                }
            };
            _pnlSidebar.Controls.Add(pnlSidebarHeader);

            // Sidebar Footer (Term + Logout)
            var pnlSidebarFooter = new Panel {
                Dock = DockStyle.Bottom,
                Height = 90,
                BackColor = ThemeColors.SidebarBackground
            };
            pnlSidebarFooter.Paint += (s, e) => {
                using var pen = new Pen(ThemeColors.SidebarHover, 1);
                e.Graphics.DrawLine(pen, 16, 0, _pnlSidebar.Width - 16, 0);

                using var font = new Font("Segoe UI", 7.5F);
                using var brush = new SolidBrush(ThemeColors.SidebarTextMuted);
                e.Graphics.DrawString("1st Semester, AY 2026-2027\nDepartment of Computer Studies", font, brush, 20, 10);
            };

            var btnSidebarLogout = new Button {
                Text = "⎋  Log Out",
                Location = new Point(16, 46),
                Size = new Size(208, 36)
            };
            UIHelper.StyleSecondaryButton(btnSidebarLogout);
            btnSidebarLogout.BackColor = ThemeColors.SidebarBackground;
            btnSidebarLogout.ForeColor = ThemeColors.White;
            btnSidebarLogout.FlatAppearance.BorderColor = ThemeColors.PrimaryRedLight;
            btnSidebarLogout.Click += (s, e) => Close();
            pnlSidebarFooter.Controls.Add(btnSidebarLogout);
            _pnlSidebar.Controls.Add(pnlSidebarFooter);

            // Nav buttons container panel
            _pnlNavButtons.Dock = DockStyle.Fill;
            _pnlNavButtons.AutoScroll = true;
            _pnlNavButtons.BackColor = ThemeColors.SidebarBackground;
            _pnlNavButtons.Padding = new Padding(0, 10, 0, 10);
            _pnlSidebar.Controls.Add(_pnlNavButtons);
            _pnlNavButtons.BringToFront();

            Controls.Add(_pnlSidebar);

            // 3. Center Content Panel
            _pnlContent.Dock = DockStyle.Fill;
            _pnlContent.BackColor = ThemeColors.CanvasBackground;
            Controls.Add(_pnlContent);
            _pnlContent.BringToFront();

            UpdateTopBarUserInfo();
        }

        private void SetupNavigationForRole() {
            var user = SessionManager.CurrentUser;
            if (user == null) return;

            _navButtons.Clear();
            _pnlNavButtons.Controls.Clear();

            switch (user.Role) {
                case UserRole.Student:
                    AddNav("Home", "Home", "🏠", () => new StudentHomeView());
                    AddNav("Request Meeting", "Request Meeting", "➕", () => {
                        var reqView = new StudentRequestMeetingView();
                        reqView.RequestSubmitted += (s, e) => NavigateTo("My Meeting Requests");
                        return reqView;
                    });
                    AddNav("My Meeting Requests", "My Meeting Requests", "📋", () => new StudentMeetingRequestsView());
                    AddNav("Notifications", "Notifications", "🔔", () => new StudentNotificationsView());
                    AddNav("My Profile", "My Profile", "👤", () => new StudentProfileView());
                    break;

                case UserRole.Faculty:
                    AddNav("Home", "Home", "🏠", () => new FacultyHomeView());
                    AddNav("Meeting Requests", "Meeting Requests", "📥", () => new FacultyRequestsView());
                    AddNav("My Schedule", "My Schedule", "📅", () => new FacultyScheduleView());
                    AddNav("Availability", "Availability", "⚙", () => new FacultyAvailabilityView());
                    AddNav("Settings", "Settings", "🔧", () => new FacultySettingsView());
                    break;

                case UserRole.Admin:
                    AddNav("Home", "Home", "🏠", () => new AdminHomeView());
                    AddNav("Manage Users", "Manage Users", "👥", () => new AdminManageUsersView());
                    AddNav("Reset Password", "Reset Password", "🔑", () => new AdminResetPasswordView());
                    AddNav("Reports", "Reports", "📊", () => new AdminReportsView());
                    break;
            }

            // Create buttons in panel
            int by = 8;
            foreach (var item in _navButtons) {
                var btn = new Button {
                    Text = $"  {item.IconGlyph}   {item.Label}",
                    Size = new Size(_pnlSidebar.Width, 44),
                    Location = new Point(0, by),
                    TextAlign = ContentAlignment.MiddleLeft,
                    Padding = new Padding(24, 0, 0, 0),
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Segoe UI", 9.5F, FontStyle.Regular),
                    ForeColor = ThemeColors.SidebarText,
                    BackColor = ThemeColors.SidebarBackground,
                    Cursor = Cursors.Hand,
                    Tag = item.Key
                };
                btn.FlatAppearance.BorderSize = 0;

                btn.Click += (s, e) => NavigateTo(item.Key);

                btn.MouseEnter += (s, e) => {
                    if (btn.Tag?.ToString() != _activeNavKey) {
                        btn.BackColor = ThemeColors.SidebarHover;
                    }
                };

                btn.MouseLeave += (s, e) => {
                    if (btn.Tag?.ToString() != _activeNavKey) {
                        btn.BackColor = ThemeColors.SidebarBackground;
                    }
                };

                // Paint active indicator strip
                btn.Paint += (s, e) => {
                    if (btn.Tag?.ToString() == _activeNavKey) {
                        using var brush = new SolidBrush(ThemeColors.White);
                        e.Graphics.FillRectangle(brush, 0, 0, 5, btn.Height);
                    }
                };

                item.ButtonControl = btn;
                _pnlNavButtons.Controls.Add(btn);
                by += 46;
            }

            UpdateActiveButtonStyles();
        }

        private void AddNav(string key, string label, string glyph, Func<UserControl> factory) {
            _navButtons.Add(new NavButtonInfo {
                Key = key,
                Label = label,
                IconGlyph = glyph,
                ViewFactory = factory
            });
        }

        public void NavigateTo(string key) {
            var nav = _navButtons.FirstOrDefault(n => n.Key == key) ?? _navButtons.FirstOrDefault();
            if (nav == null) return;

            _activeNavKey = nav.Key;
            UpdateActiveButtonStyles();

            // Load and switch view control
            _pnlContent.SuspendLayout();
            _pnlContent.Controls.Clear();

            var view = nav.ViewFactory();
            view.Dock = DockStyle.Fill;
            _pnlContent.Controls.Add(view);
            _pnlContent.ResumeLayout(true);
        }

        private void UpdateActiveButtonStyles() {
            foreach (var nav in _navButtons) {
                bool isActive = nav.Key == _activeNavKey;
                nav.ButtonControl.BackColor = isActive ? ThemeColors.SidebarActiveItem : ThemeColors.SidebarBackground;
                nav.ButtonControl.Font = new Font("Segoe UI", 9.5F, isActive ? FontStyle.Bold : FontStyle.Regular);
                nav.ButtonControl.ForeColor = isActive ? ThemeColors.White : ThemeColors.SidebarTextMuted;
                nav.ButtonControl.Invalidate();
            }
        }

        private void UpdateTopBarUserInfo() {
            var user = SessionManager.CurrentUser;
            if (user == null) return;

            _lblTopUser.Text = user.FullName;
            _lblTopRole.Text = $"{user.DisplayRole} • {user.ProgramOrTitle}";

            // Update role switcher index safely
            _cbRoleSwitcher.SelectedIndexChanged -= OnRoleSwitcherChanged;
            _cbRoleSwitcher.SelectedIndex = user.Role switch {
                UserRole.Student => 0,
                UserRole.Faculty => 1,
                UserRole.Admin => 2,
                _ => 0
            };
            _cbRoleSwitcher.SelectedIndexChanged += OnRoleSwitcherChanged;
        }

        private void OnRoleSwitcherChanged(object? sender, EventArgs e) {
            string targetEmail = _cbRoleSwitcher.SelectedIndex switch {
                0 => "juan.delacruz@ue.edu.ph",
                1 => "maria.santos@ue.edu.ph",
                2 => "admin.dcss@ue.edu.ph",
                _ => "juan.delacruz@ue.edu.ph"
            };

            var user = _dataService.GetAllUsers().FirstOrDefault(u => u.Email == targetEmail);
            if (user != null) {
                SessionManager.SetSession(user);
                SetupNavigationForRole();
                NavigateTo("Home");
                UpdateTopBarUserInfo();
            }
        }
    }
}
