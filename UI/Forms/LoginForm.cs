using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using DCSSMeetingScheduler.Models;
using DCSSMeetingScheduler.Services;
using DCSSMeetingScheduler.UI.Common;

namespace DCSSMeetingScheduler.UI.Forms {
    public class LoginForm : Form {
        private readonly IDataService _dataService = MockDataStore.Instance;

        private readonly TextBox _txtEmail = new();
        private readonly TextBox _txtPassword = new();
        private readonly CheckBox _chkShowPassword = new();
        private readonly Button _btnLogin = new();
        private readonly Label _lblError = new();

        public LoginForm() {
            DoubleBuffered = true;
            InitializeComponent();
        }

        private void InitializeComponent() {
            Text = "DCSS Faculty and Student Meeting Scheduler - Login";
            Size = new Size(950, 640);
            MinimumSize = new Size(850, 580);
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = ThemeColors.CanvasBackground;

            // Split Layout: Left UE Brand Banner (Red) and Right Login Form (White Card)
            var pnlLeftBanner = new Panel {
                Dock = DockStyle.Left,
                Width = 380,
                BackColor = ThemeColors.PrimaryRedDark
            };
            pnlLeftBanner.Paint += RenderLeftBanner;
            Controls.Add(pnlLeftBanner);

            // Right Container Panel
            var pnlRight = new Panel {
                Dock = DockStyle.Fill,
                BackColor = ThemeColors.CanvasBackground,
                Padding = new Padding(40)
            };

            // Centered Login Card
            var pnlCard = new Panel {
                Size = new Size(460, 510),
                BackColor = ThemeColors.White,
                Padding = new Padding(32)
            };
            pnlCard.Paint += (s, e) => {
                var g = e.Graphics;
                using var pen = new Pen(ThemeColors.BorderGray, 1);
                g.DrawRectangle(pen, 0, 0, pnlCard.Width - 1, pnlCard.Height - 1);

                // Top Red Accent Line
                using var redBrush = new SolidBrush(ThemeColors.PrimaryRed);
                g.FillRectangle(redBrush, 0, 0, pnlCard.Width, 4);
            };

            // Center the card on resize
            pnlRight.Resize += (s, e) => {
                pnlCard.Location = new Point(
                    Math.Max(20, (pnlRight.ClientSize.Width - pnlCard.Width) / 2),
                    Math.Max(20, (pnlRight.ClientSize.Height - pnlCard.Height) / 2)
                );
            };

            // Title inside card
            var lblLoginTitle = new Label {
                Text = "Account Login",
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                ForeColor = ThemeColors.TextDark,
                Location = new Point(32, 24),
                AutoSize = true
            };
            pnlCard.Controls.Add(lblLoginTitle);

            var lblLoginSub = new Label {
                Text = "Enter your UE email credentials to access the consultation portal.",
                Font = new Font("Segoe UI", 8.5F),
                ForeColor = ThemeColors.TextMuted,
                Location = new Point(32, 58),
                AutoSize = true
            };
            pnlCard.Controls.Add(lblLoginSub);

            int y = 95;

            // Email Field
            var lblEmail = new Label {
                Text = "UE Email Address (@ue.edu.ph) *",
                Font = new Font("Segoe UI", 8.5F, FontStyle.Bold),
                ForeColor = ThemeColors.TextDark,
                Location = new Point(32, y),
                AutoSize = true
            };
            pnlCard.Controls.Add(lblEmail);
            y += 22;

            _txtEmail.Location = new Point(32, y);
            _txtEmail.Size = new Size(396, 28);
            _txtEmail.Text = "juan.delacruz@ue.edu.ph";
            _txtEmail.PlaceholderText = "username@ue.edu.ph";
            UIHelper.StyleTextBox(_txtEmail);
            pnlCard.Controls.Add(_txtEmail);
            y += 40;

            // Password Field
            var lblPassword = new Label {
                Text = "Password *",
                Font = new Font("Segoe UI", 8.5F, FontStyle.Bold),
                ForeColor = ThemeColors.TextDark,
                Location = new Point(32, y),
                AutoSize = true
            };
            pnlCard.Controls.Add(lblPassword);
            y += 22;

            _txtPassword.Location = new Point(32, y);
            _txtPassword.Size = new Size(396, 28);
            _txtPassword.Text = "password123";
            _txtPassword.PasswordChar = '●';
            UIHelper.StyleTextBox(_txtPassword);
            pnlCard.Controls.Add(_txtPassword);
            y += 34;

            // Show/Hide Password Checkbox
            _chkShowPassword.Text = "Show password";
            _chkShowPassword.Font = new Font("Segoe UI", 8.5F);
            _chkShowPassword.ForeColor = ThemeColors.TextRegular;
            _chkShowPassword.Location = new Point(32, y);
            _chkShowPassword.AutoSize = true;
            _chkShowPassword.CheckedChanged += (s, e) => {
                _txtPassword.PasswordChar = _chkShowPassword.Checked ? '\0' : '●';
            };
            pnlCard.Controls.Add(_chkShowPassword);
            y += 30;

            // Error Message Label
            _lblError.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            _lblError.ForeColor = ThemeColors.PrimaryRed;
            _lblError.Location = new Point(32, y);
            _lblError.Size = new Size(396, 20);
            _lblError.Visible = false;
            pnlCard.Controls.Add(_lblError);
            y += 24;

            // Red Login Button
            _btnLogin.Text = "Sign In to Portal";
            _btnLogin.Location = new Point(32, y);
            _btnLogin.Size = new Size(396, 40);
            UIHelper.StylePrimaryButton(_btnLogin);
            _btnLogin.Click += OnLoginClick;
            pnlCard.Controls.Add(_btnLogin);
            AcceptButton = _btnLogin;
            y += 55;

            // Quick Demo Switcher Title & Buttons
            var lblDemo = new Label {
                Text = "QUICK ROLE DEMO ACCESS:",
                Font = new Font("Segoe UI", 7.5F, FontStyle.Bold),
                ForeColor = ThemeColors.TextMuted,
                Location = new Point(32, y),
                AutoSize = true
            };
            pnlCard.Controls.Add(lblDemo);
            y += 20;

            var pnlDemo = new FlowLayoutPanel {
                Location = new Point(32, y),
                Size = new Size(396, 40),
                WrapContents = false,
                BackColor = Color.Transparent
            };

            var btnDemoStudent = new Button {
                Text = "Student Demo",
                Size = new Size(125, 32),
                Margin = new Padding(0, 0, 8, 0)
            };
            UIHelper.StyleSecondaryButton(btnDemoStudent);
            btnDemoStudent.Click += (s, e) => {
                _txtEmail.Text = "juan.delacruz@ue.edu.ph";
                _txtPassword.Text = "password123";
                OnLoginClick(s, e);
            };

            var btnDemoFaculty = new Button {
                Text = "Faculty Demo",
                Size = new Size(125, 32),
                Margin = new Padding(0, 0, 8, 0)
            };
            UIHelper.StyleSecondaryButton(btnDemoFaculty);
            btnDemoFaculty.Click += (s, e) => {
                _txtEmail.Text = "maria.santos@ue.edu.ph";
                _txtPassword.Text = "password123";
                OnLoginClick(s, e);
            };

            var btnDemoAdmin = new Button {
                Text = "Admin Demo",
                Size = new Size(125, 32),
                Margin = new Padding(0)
            };
            UIHelper.StyleSecondaryButton(btnDemoAdmin);
            btnDemoAdmin.Click += (s, e) => {
                _txtEmail.Text = "admin.dcss@ue.edu.ph";
                _txtPassword.Text = "password123";
                OnLoginClick(s, e);
            };

            pnlDemo.Controls.AddRange(new Control[] { btnDemoStudent, btnDemoFaculty, btnDemoAdmin });
            pnlCard.Controls.Add(pnlDemo);

            pnlRight.Controls.Add(pnlCard);
            Controls.Add(pnlRight);
            pnlRight.BringToFront();

            // Initial centering
            pnlCard.Location = new Point(
                Math.Max(20, (pnlRight.ClientSize.Width - pnlCard.Width) / 2),
                Math.Max(20, (pnlRight.ClientSize.Height - pnlCard.Height) / 2)
            );
        }

        private void RenderLeftBanner(object? sender, PaintEventArgs e) {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            var pnl = sender as Panel;
            if (pnl == null) return;

            // University Logo / Emblem Circle
            int circleSize = 80;
            int cx = (pnl.Width - circleSize) / 2;
            int cy = 70;
            var circleRect = new Rectangle(cx, cy, circleSize, circleSize);

            using (var circleBrush = new SolidBrush(ThemeColors.White)) {
                g.FillEllipse(circleBrush, circleRect);
            }
            using (var textFont = new Font("Segoe UI", 24F, FontStyle.Bold))
            using (var textBrush = new SolidBrush(ThemeColors.PrimaryRedDark)) {
                var sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                g.DrawString("UE", textFont, textBrush, circleRect, sf);
            }

            int ty = cy + circleSize + 25;

            // University Name
            using (var font = new Font("Segoe UI", 12F, FontStyle.Bold))
            using (var brush = new SolidBrush(ThemeColors.White)) {
                var sf = new StringFormat { Alignment = StringAlignment.Center };
                g.DrawString("UNIVERSITY OF THE EAST\nCALOOCAN CAMPUS", font, brush, new RectangleF(20, ty, pnl.Width - 40, 50), sf);
            }
            ty += 55;

            // Department Name
            using (var font = new Font("Segoe UI", 9.5F, FontStyle.Regular))
            using (var brush = new SolidBrush(ThemeColors.SidebarTextMuted)) {
                var sf = new StringFormat { Alignment = StringAlignment.Center };
                g.DrawString("College of Arts and Sciences\nDepartment of Computer Studies and Systems", font, brush, new RectangleF(20, ty, pnl.Width - 40, 40), sf);
            }
            ty += 45;

            // Divider Line
            using (var pen = new Pen(ThemeColors.PrimaryRedLight, 1)) {
                g.DrawLine(pen, 40, ty, pnl.Width - 40, ty);
            }
            ty += 25;

            // System Title
            using (var font = new Font("Segoe UI", 14F, FontStyle.Bold))
            using (var brush = new SolidBrush(ThemeColors.White)) {
                var sf = new StringFormat { Alignment = StringAlignment.Center };
                g.DrawString("DCSS FACULTY & STUDENT\nMEETING SCHEDULER", font, brush, new RectangleF(20, ty, pnl.Width - 40, 65), sf);
            }
            ty += 70;

            // Key bullet points
            string[] highlights = {
                "✔  Real-Time Consultation Scheduling",
                "✔  Face-to-Face & Virtual Meeting Slots",
                "✔  Automated Status Updates & Alerts",
                "✔  Role-Based Access for DCSS Community"
            };

            using (var font = new Font("Segoe UI", 8.5F, FontStyle.Regular))
            using (var brush = new SolidBrush(ThemeColors.SidebarTextMuted)) {
                foreach (var h in highlights) {
                    g.DrawString(h, font, brush, 45, ty);
                    ty += 26;
                }
            }

            // Footer
            using (var font = new Font("Segoe UI", 7.5F))
            using (var brush = new SolidBrush(ThemeColors.SidebarTextMuted)) {
                var sf = new StringFormat { Alignment = StringAlignment.Center };
                g.DrawString("Academic Year 2026-2027 • Official University System", font, brush, new RectangleF(20, pnl.Height - 35, pnl.Width - 40, 20), sf);
            }
        }

        private void OnLoginClick(object? sender, EventArgs e) {
            _lblError.Visible = false;

            string email = _txtEmail.Text.Trim();
            string password = _txtPassword.Text;

            if (string.IsNullOrWhiteSpace(email)) {
                ShowError("Please enter your UE email address.");
                _txtEmail.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(password)) {
                ShowError("Please enter your password.");
                _txtPassword.Focus();
                return;
            }

            var user = _dataService.Authenticate(email, password);
            if (user == null) {
                ShowError("Invalid UE email or password. Please verify credentials.");
                return;
            }

            // Successful authentication
            SessionManager.SetSession(user);

            // Launch MainShellForm
            Hide();
            using var shell = new MainShellForm();
            shell.ShowDialog();

            // When shell closes (e.g. on logout)
            SessionManager.ClearSession();
            _txtPassword.Clear();
            _lblError.Visible = false;
            Show();
        }

        private void ShowError(string msg) {
            _lblError.Text = msg;
            _lblError.Visible = true;
        }
    }
}
