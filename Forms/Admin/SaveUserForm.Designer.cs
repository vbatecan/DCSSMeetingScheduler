namespace DCSSMeetingScheduler.Admin
{
    partial class SaveUserForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Label lblIdNumber;
        private System.Windows.Forms.TextBox txtIdNumber;
        private System.Windows.Forms.Label lblProgramOrDept;
        private System.Windows.Forms.TextBox txtProgramOrDept;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.CheckBox chkMustChangePassword;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblSubtitle = new Label();
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            chkShowPassword = new CheckBox();
            lblRole = new Label();
            cmbRole = new ComboBox();
            lblIdNumber = new Label();
            txtIdNumber = new TextBox();
            lblProgramOrDept = new Label();
            txtProgramOrDept = new TextBox();
            chkIsActive = new CheckBox();
            chkMustChangePassword = new CheckBox();
            lblErrorMessage = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();

            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(85, 121, 69);
            lblTitle.Location = new Point(35, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(410, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Add New User";

            lblSubtitle.Font = new Font("Segoe UI", 9F);
            lblSubtitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblSubtitle.Location = new Point(35, 48);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(410, 20);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Enter account details to create a new user";

            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblFirstName.Location = new Point(35, 78);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(64, 15);
            lblFirstName.TabIndex = 2;
            lblFirstName.Text = "First Name";

            txtFirstName.Font = new Font("Segoe UI", 9.5F);
            txtFirstName.Location = new Point(35, 96);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "Enter first name";
            txtFirstName.Size = new Size(195, 24);
            txtFirstName.TabIndex = 3;

            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblLastName.Location = new Point(250, 78);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(63, 15);
            lblLastName.TabIndex = 4;
            lblLastName.Text = "Last Name";

            txtLastName.Font = new Font("Segoe UI", 9.5F);
            txtLastName.Location = new Point(250, 96);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Enter last name";
            txtLastName.Size = new Size(195, 24);
            txtLastName.TabIndex = 5;

            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblEmail.Location = new Point(35, 130);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(56, 15);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "UE Email";

            txtEmail.Font = new Font("Segoe UI", 9.5F);
            txtEmail.Location = new Point(35, 148);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "name@ue.edu.ph";
            txtEmail.Size = new Size(410, 24);
            txtEmail.TabIndex = 7;

            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblPassword.Location = new Point(35, 182);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 15);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Password";

            txtPassword.Font = new Font("Segoe UI", 9.5F);
            txtPassword.Location = new Point(35, 200);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Minimum 6 characters";
            txtPassword.Size = new Size(300, 24);
            txtPassword.TabIndex = 9;
            txtPassword.UseSystemPasswordChar = true;

            chkShowPassword.AutoSize = true;
            chkShowPassword.Font = new Font("Segoe UI", 9F);
            chkShowPassword.Location = new Point(345, 202);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(55, 19);
            chkShowPassword.TabIndex = 10;
            chkShowPassword.Text = "Show";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;

            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblRole.Location = new Point(35, 234);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(30, 15);
            lblRole.TabIndex = 11;
            lblRole.Text = "Role";

            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.Font = new Font("Segoe UI", 9.5F);
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Admin", "Faculty", "Student" });
            cmbRole.Location = new Point(35, 252);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(195, 24);
            cmbRole.TabIndex = 12;

            lblIdNumber.AutoSize = true;
            lblIdNumber.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblIdNumber.Location = new Point(250, 234);
            lblIdNumber.Name = "lblIdNumber";
            lblIdNumber.Size = new Size(66, 15);
            lblIdNumber.TabIndex = 13;
            lblIdNumber.Text = "ID Number";

            txtIdNumber.Font = new Font("Segoe UI", 9.5F);
            txtIdNumber.Location = new Point(250, 252);
            txtIdNumber.Name = "txtIdNumber";
            txtIdNumber.PlaceholderText = "e.g. 2022-0001";
            txtIdNumber.Size = new Size(195, 24);
            txtIdNumber.TabIndex = 14;

            lblProgramOrDept.AutoSize = true;
            lblProgramOrDept.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblProgramOrDept.Location = new Point(35, 286);
            lblProgramOrDept.Name = "lblProgramOrDept";
            lblProgramOrDept.Size = new Size(125, 15);
            lblProgramOrDept.TabIndex = 15;
            lblProgramOrDept.Text = "Program / Department";

            txtProgramOrDept.Font = new Font("Segoe UI", 9.5F);
            txtProgramOrDept.Location = new Point(35, 304);
            txtProgramOrDept.Name = "txtProgramOrDept";
            txtProgramOrDept.PlaceholderText = "e.g. DCSS, BSCS, BSIT";
            txtProgramOrDept.Size = new Size(410, 24);
            txtProgramOrDept.TabIndex = 16;

            chkIsActive.AutoSize = true;
            chkIsActive.Checked = true;
            chkIsActive.CheckState = CheckState.Checked;
            chkIsActive.Font = new Font("Segoe UI", 9F);
            chkIsActive.Location = new Point(35, 342);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(106, 19);
            chkIsActive.TabIndex = 17;
            chkIsActive.Text = "Active Account";
            chkIsActive.UseVisualStyleBackColor = true;

            chkMustChangePassword.AutoSize = true;
            chkMustChangePassword.Checked = true;
            chkMustChangePassword.CheckState = CheckState.Checked;
            chkMustChangePassword.Font = new Font("Segoe UI", 9F);
            chkMustChangePassword.Location = new Point(210, 342);
            chkMustChangePassword.Name = "chkMustChangePassword";
            chkMustChangePassword.Size = new Size(150, 19);
            chkMustChangePassword.TabIndex = 18;
            chkMustChangePassword.Text = "Must Change Password";
            chkMustChangePassword.UseVisualStyleBackColor = true;

            lblErrorMessage.Font = new Font("Segoe UI", 9F);
            lblErrorMessage.ForeColor = Color.FromArgb(220, 38, 38);
            lblErrorMessage.Location = new Point(35, 372);
            lblErrorMessage.Name = "lblErrorMessage";
            lblErrorMessage.Size = new Size(410, 22);
            lblErrorMessage.TabIndex = 19;
            lblErrorMessage.TextAlign = ContentAlignment.MiddleLeft;

            btnSave.BackColor = Color.FromArgb(85, 121, 69);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(35, 404);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(410, 38);
            btnSave.TabIndex = 20;
            btnSave.Text = "Save User";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;

            btnCancel.BackColor = Color.FromArgb(245, 245, 245);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9.5F);
            btnCancel.ForeColor = Color.FromArgb(70, 70, 70);
            btnCancel.Location = new Point(35, 450);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(410, 34);
            btnCancel.TabIndex = 21;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;

            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = btnCancel;
            ClientSize = new Size(480, 505);
            Controls.Add(lblTitle);
            Controls.Add(lblSubtitle);
            Controls.Add(lblFirstName);
            Controls.Add(txtFirstName);
            Controls.Add(lblLastName);
            Controls.Add(txtLastName);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(chkShowPassword);
            Controls.Add(lblRole);
            Controls.Add(cmbRole);
            Controls.Add(lblIdNumber);
            Controls.Add(txtIdNumber);
            Controls.Add(lblProgramOrDept);
            Controls.Add(txtProgramOrDept);
            Controls.Add(chkIsActive);
            Controls.Add(chkMustChangePassword);
            Controls.Add(lblErrorMessage);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SaveUserForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "DCSS Meeting Scheduler - Save User";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
