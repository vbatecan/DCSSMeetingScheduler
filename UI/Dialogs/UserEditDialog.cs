using System;
using System.Drawing;
using System.Windows.Forms;
using DCSSMeetingScheduler.Models;
using DCSSMeetingScheduler.UI.Common;

namespace DCSSMeetingScheduler.UI.Dialogs {
    public class UserEditDialog : Form {
        public User ResultUser { get; private set; }
        private readonly bool _isEditMode;

        private readonly TextBox _txtFullName = new();
        private readonly TextBox _txtEmail = new();
        private readonly TextBox _txtIdNumber = new();
        private readonly ComboBox _cbRole = new();
        private readonly TextBox _txtProgramOrTitle = new();
        private readonly TextBox _txtPhone = new();
        private readonly ComboBox _cbStatus = new();
        private readonly TextBox _txtPassword = new();

        public UserEditDialog(User? existingUser = null) {
            _isEditMode = existingUser != null;
            ResultUser = existingUser != null ? new User {
                UserId = existingUser.UserId,
                FullName = existingUser.FullName,
                Email = existingUser.Email,
                Role = existingUser.Role,
                Department = existingUser.Department,
                IdNumber = existingUser.IdNumber,
                ProgramOrTitle = existingUser.ProgramOrTitle,
                Phone = existingUser.Phone,
                Status = existingUser.Status,
                Password = existingUser.Password,
                CreatedAt = existingUser.CreatedAt
            } : new User();

            InitializeComponent();
        }

        private void InitializeComponent() {
            Text = _isEditMode ? "Edit User Account" : "Create New User Account";
            Size = new Size(520, 620);
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            BackColor = ThemeColors.CanvasBackground;

            // Header Banner
            var pnlHeader = new Panel {
                Dock = DockStyle.Top,
                Height = 60,
                BackColor = ThemeColors.PrimaryRedDark,
                Padding = new Padding(20, 10, 20, 10)
            };

            var lblHeader = new Label {
                Text = _isEditMode ? "EDIT USER ACCOUNT" : "CREATE NEW USER ACCOUNT",
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                ForeColor = ThemeColors.White,
                Location = new Point(20, 10),
                AutoSize = true
            };
            var lblSub = new Label {
                Text = "Manage DCSS portal credentials and access privileges",
                Font = new Font("Segoe UI", 8.5F),
                ForeColor = ThemeColors.SidebarTextMuted,
                Location = new Point(20, 32),
                AutoSize = true
            };
            pnlHeader.Controls.Add(lblHeader);
            pnlHeader.Controls.Add(lblSub);
            Controls.Add(pnlHeader);

            // Card Panel
            var pnlCard = new Panel {
                Location = new Point(20, 75),
                Size = new Size(464, 460),
                BackColor = ThemeColors.White,
                Padding = new Padding(20)
            };
            pnlCard.Paint += (s, e) => {
                using var pen = new Pen(ThemeColors.BorderGray, 1);
                e.Graphics.DrawRectangle(pen, 0, 0, pnlCard.Width - 1, pnlCard.Height - 1);
            };

            int y = 15;

            void AddInput(string label, Control ctrl) {
                var lbl = new Label {
                    Text = label,
                    Font = new Font("Segoe UI", 8.5F, FontStyle.Bold),
                    ForeColor = ThemeColors.TextDark,
                    Location = new Point(15, y),
                    AutoSize = true
                };
                pnlCard.Controls.Add(lbl);
                y += 20;

                ctrl.Location = new Point(15, y);
                ctrl.Size = new Size(430, 26);
                pnlCard.Controls.Add(ctrl);
                y += 35;
            }

            UIHelper.StyleTextBox(_txtFullName);
            _txtFullName.Text = ResultUser.FullName;
            AddInput("Full Name *", _txtFullName);

            UIHelper.StyleTextBox(_txtEmail);
            _txtEmail.Text = ResultUser.Email;
            AddInput("UE Email Address (@ue.edu.ph) *", _txtEmail);

            UIHelper.StyleComboBox(_cbRole);
            _cbRole.Items.AddRange(new object[] { "Student", "Faculty", "Admin" });
            _cbRole.SelectedItem = ResultUser.Role.ToString();
            AddInput("System Role *", _cbRole);

            UIHelper.StyleTextBox(_txtIdNumber);
            _txtIdNumber.Text = ResultUser.IdNumber;
            AddInput("ID Number (Student / Employee Number)", _txtIdNumber);

            UIHelper.StyleTextBox(_txtProgramOrTitle);
            _txtProgramOrTitle.Text = ResultUser.ProgramOrTitle;
            AddInput("Program / Designation (e.g. BSCS 3-A or Assistant Professor)", _txtProgramOrTitle);

            UIHelper.StyleTextBox(_txtPhone);
            _txtPhone.Text = ResultUser.Phone;
            AddInput("Contact Phone Number", _txtPhone);

            UIHelper.StyleComboBox(_cbStatus);
            _cbStatus.Items.AddRange(new object[] { "Active", "Inactive" });
            _cbStatus.SelectedItem = ResultUser.Status.ToString();
            AddInput("Account Status", _cbStatus);

            if (!_isEditMode) {
                UIHelper.StyleTextBox(_txtPassword);
                _txtPassword.Text = "password123";
                _txtPassword.PasswordChar = '●';
                AddInput("Temporary Password", _txtPassword);
            }

            Controls.Add(pnlCard);

            // Action Buttons
            var btnCancel = new Button {
                Text = "Cancel",
                Location = new Point(250, 545),
                Size = new Size(100, 36)
            };
            UIHelper.StyleSecondaryButton(btnCancel);
            btnCancel.Click += (s, e) => { DialogResult = DialogResult.Cancel; Close(); };
            Controls.Add(btnCancel);

            var btnSave = new Button {
                Text = _isEditMode ? "Save Changes" : "Create User",
                Location = new Point(360, 545),
                Size = new Size(125, 36)
            };
            UIHelper.StylePrimaryButton(btnSave);
            btnSave.Click += (s, e) => {
                if (string.IsNullOrWhiteSpace(_txtFullName.Text)) {
                    MessageBox.Show("Please enter the user's full name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(_txtEmail.Text) || !_txtEmail.Text.Contains("@")) {
                    MessageBox.Show("Please enter a valid UE email address.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ResultUser.FullName = _txtFullName.Text.Trim();
                ResultUser.Email = _txtEmail.Text.Trim();
                ResultUser.Role = Enum.TryParse<UserRole>(_cbRole.SelectedItem?.ToString(), out var r) ? r : UserRole.Student;
                ResultUser.IdNumber = _txtIdNumber.Text.Trim();
                ResultUser.ProgramOrTitle = _txtProgramOrTitle.Text.Trim();
                ResultUser.Phone = _txtPhone.Text.Trim();
                ResultUser.Status = Enum.TryParse<AccountStatus>(_cbStatus.SelectedItem?.ToString(), out var st) ? st : AccountStatus.Active;
                if (!_isEditMode) {
                    ResultUser.Password = string.IsNullOrWhiteSpace(_txtPassword.Text) ? "password123" : _txtPassword.Text.Trim();
                }

                DialogResult = DialogResult.OK;
                Close();
            };
            Controls.Add(btnSave);
        }
    }
}
