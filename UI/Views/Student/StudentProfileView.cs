using System;
using System.Drawing;
using System.Windows.Forms;
using DCSSMeetingScheduler.Models;
using DCSSMeetingScheduler.Services;
using DCSSMeetingScheduler.UI.Common;

namespace DCSSMeetingScheduler.UI.Views.Student {
    public class StudentProfileView : UserControl {
        private readonly IDataService _dataService = MockDataStore.Instance;

        private readonly TextBox _txtPhone = new();
        private readonly TextBox _txtEmail = new();
        private readonly TextBox _txtName = new();
        private readonly TextBox _txtStudentNo = new();
        private readonly TextBox _txtProgram = new();

        public StudentProfileView() {
            DoubleBuffered = true;
            Dock = DockStyle.Fill;
            BackColor = ThemeColors.CanvasBackground;

            InitializeLayout();
            LoadProfile();
        }

        private void InitializeLayout() {
            // Header
            var pnlHeader = UIHelper.CreatePageHeader(
                "MY STUDENT PROFILE",
                "View and update your student contact information and DCSS enrollment profile"
            );
            Controls.Add(pnlHeader);

            var pnlBody = new Panel {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                Padding = new Padding(24, 16, 24, 24)
            };

            var pnlCard = UIHelper.CreateCard(24);
            pnlCard.Dock = DockStyle.Top;
            pnlCard.Height = 520;
            pnlCard.MaximumSize = new Size(760, 0);

            var lblTitle = new Label {
                Text = "Academic & Student Information",
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                ForeColor = ThemeColors.TextDark,
                Location = new Point(20, 16),
                AutoSize = true
            };
            pnlCard.Controls.Add(lblTitle);

            var lblSub = new Label {
                Text = "Official UE student credentials associated with this scheduler portal.",
                Font = new Font("Segoe UI", 8.5F),
                ForeColor = ThemeColors.TextMuted,
                Location = new Point(20, 42),
                AutoSize = true
            };
            pnlCard.Controls.Add(lblSub);

            int y = 80;

            void AddReadOnlyField(string label, TextBox tb) {
                var lbl = new Label {
                    Text = label,
                    Font = new Font("Segoe UI", 8.5F, FontStyle.Bold),
                    ForeColor = ThemeColors.TextDark,
                    Location = new Point(20, y),
                    AutoSize = true
                };
                pnlCard.Controls.Add(lbl);
                y += 22;

                tb.Location = new Point(20, y);
                tb.Size = new Size(680, 26);
                tb.ReadOnly = true;
                tb.BackColor = ThemeColors.LightGray;
                UIHelper.StyleTextBox(tb);
                pnlCard.Controls.Add(tb);
                y += 38;
            }

            AddReadOnlyField("Full Student Name", _txtName);
            AddReadOnlyField("Student Number", _txtStudentNo);
            AddReadOnlyField("Degree Program & Section", _txtProgram);
            AddReadOnlyField("University Email (@ue.edu.ph)", _txtEmail);

            // Editable Phone
            var lblPhone = new Label {
                Text = "Contact Mobile Number (Editable) *",
                Font = new Font("Segoe UI", 8.5F, FontStyle.Bold),
                ForeColor = ThemeColors.PrimaryRedDark,
                Location = new Point(20, y),
                AutoSize = true
            };
            pnlCard.Controls.Add(lblPhone);
            y += 22;

            _txtPhone.Location = new Point(20, y);
            _txtPhone.Size = new Size(680, 26);
            UIHelper.StyleTextBox(_txtPhone);
            pnlCard.Controls.Add(_txtPhone);
            y += 48;

            // Save Button
            var btnSave = new Button {
                Text = "Update Contact Info",
                Location = new Point(540, y),
                Size = new Size(160, 38)
            };
            UIHelper.StylePrimaryButton(btnSave);
            btnSave.Click += OnSaveClick;
            pnlCard.Controls.Add(btnSave);

            pnlBody.Controls.Add(pnlCard);
            Controls.Add(pnlBody);
            pnlBody.BringToFront();
        }

        private void LoadProfile() {
            var user = SessionManager.CurrentUser;
            if (user == null) return;

            _txtName.Text = user.FullName;
            _txtStudentNo.Text = user.IdNumber;
            _txtProgram.Text = $"{user.ProgramOrTitle} • College of Arts and Sciences (DCSS)";
            _txtEmail.Text = user.Email;
            _txtPhone.Text = user.Phone;
        }

        private void OnSaveClick(object? sender, EventArgs e) {
            var user = SessionManager.CurrentUser;
            if (user == null) return;

            user.Phone = _txtPhone.Text.Trim();
            _dataService.UpdateUser(user);

            MessageBox.Show("Contact information successfully updated!", "Profile Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
