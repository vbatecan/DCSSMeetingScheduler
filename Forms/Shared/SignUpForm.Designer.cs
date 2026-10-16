namespace DCSSMeetingScheduler
{
    partial class SignUpForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Label lblIdNumber;
        private System.Windows.Forms.TextBox txtIdNumber;
        private System.Windows.Forms.Label lblProgramOrDept;
        private System.Windows.Forms.TextBox txtProgramOrDept;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.Button btnSignUp;
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
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            lblSubtitle = new Label();
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblRole = new Label();
            cmbRole = new ComboBox();
            lblIdNumber = new Label();
            txtIdNumber = new TextBox();
            lblProgramOrDept = new Label();
            txtProgramOrDept = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblConfirmPassword = new Label();
            txtConfirmPassword = new TextBox();
            chkShowPassword = new CheckBox();
            lblErrorMessage = new Label();
            btnSignUp = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();

            pictureBox1.Image = Properties.Resources.dcss;
            pictureBox1.Location = new Point(185, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;

            lblTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblTitle.Location = new Point(35, 96);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(380, 30);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "DCSS Meeting Scheduler";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            lblSubtitle.Font = new Font("Segoe UI", 9.5F);
            lblSubtitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblSubtitle.Location = new Point(35, 126);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(380, 20);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Create a new account";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;

            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblFirstName.ForeColor = Color.FromArgb(51, 65, 85);
            lblFirstName.Location = new Point(35, 155);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(64, 15);
            lblFirstName.TabIndex = 3;
            lblFirstName.Text = "First Name";

            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Font = new Font("Segoe UI", 9.5F);
            txtFirstName.Location = new Point(35, 173);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "Enter first name";
            txtFirstName.Size = new Size(180, 24);
            txtFirstName.TabIndex = 4;

            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblLastName.ForeColor = Color.FromArgb(51, 65, 85);
            lblLastName.Location = new Point(235, 155);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(63, 15);
            lblLastName.TabIndex = 5;
            lblLastName.Text = "Last Name";

            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Font = new Font("Segoe UI", 9.5F);
            txtLastName.Location = new Point(235, 173);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Enter last name";
            txtLastName.Size = new Size(180, 24);
            txtLastName.TabIndex = 6;

            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(51, 65, 85);
            lblEmail.Location = new Point(35, 207);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(56, 15);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "UE Email";

            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 9.5F);
            txtEmail.Location = new Point(35, 225);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "name@ue.edu.ph";
            txtEmail.Size = new Size(380, 24);
            txtEmail.TabIndex = 8;

            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblRole.ForeColor = Color.FromArgb(51, 65, 85);
            lblRole.Location = new Point(35, 259);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(30, 15);
            lblRole.TabIndex = 9;
            lblRole.Text = "Role";

            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.Font = new Font("Segoe UI", 9.5F);
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Student", "Faculty" });
            cmbRole.Location = new Point(35, 277);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(180, 24);
            cmbRole.TabIndex = 10;

            lblIdNumber.AutoSize = true;
            lblIdNumber.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblIdNumber.ForeColor = Color.FromArgb(51, 65, 85);
            lblIdNumber.Location = new Point(235, 259);
            lblIdNumber.Name = "lblIdNumber";
            lblIdNumber.Size = new Size(66, 15);
            lblIdNumber.TabIndex = 11;
            lblIdNumber.Text = "ID Number";

            txtIdNumber.BorderStyle = BorderStyle.FixedSingle;
            txtIdNumber.Font = new Font("Segoe UI", 9.5F);
            txtIdNumber.Location = new Point(235, 277);
            txtIdNumber.Name = "txtIdNumber";
            txtIdNumber.PlaceholderText = "e.g. 2022-0001";
            txtIdNumber.Size = new Size(180, 24);
            txtIdNumber.TabIndex = 12;

            lblProgramOrDept.AutoSize = true;
            lblProgramOrDept.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblProgramOrDept.ForeColor = Color.FromArgb(51, 65, 85);
            lblProgramOrDept.Location = new Point(35, 311);
            lblProgramOrDept.Name = "lblProgramOrDept";
            lblProgramOrDept.Size = new Size(125, 15);
            lblProgramOrDept.TabIndex = 13;
            lblProgramOrDept.Text = "Program / Department";

            txtProgramOrDept.BorderStyle = BorderStyle.FixedSingle;
            txtProgramOrDept.Font = new Font("Segoe UI", 9.5F);
            txtProgramOrDept.Location = new Point(35, 329);
            txtProgramOrDept.Name = "txtProgramOrDept";
            txtProgramOrDept.PlaceholderText = "e.g. BSCS, BSIT, DCSS";
            txtProgramOrDept.Size = new Size(380, 24);
            txtProgramOrDept.TabIndex = 14;

            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblPassword.ForeColor = Color.FromArgb(51, 65, 85);
            lblPassword.Location = new Point(35, 363);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 15);
            lblPassword.TabIndex = 15;
            lblPassword.Text = "Password";

            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 9.5F);
            txtPassword.Location = new Point(35, 381);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Min. 6 characters";
            txtPassword.Size = new Size(180, 24);
            txtPassword.TabIndex = 16;
            txtPassword.UseSystemPasswordChar = true;

            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblConfirmPassword.ForeColor = Color.FromArgb(51, 65, 85);
            lblConfirmPassword.Location = new Point(235, 363);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(104, 15);
            lblConfirmPassword.TabIndex = 17;
            lblConfirmPassword.Text = "Confirm Password";

            txtConfirmPassword.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmPassword.Font = new Font("Segoe UI", 9.5F);
            txtConfirmPassword.Location = new Point(235, 381);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PlaceholderText = "Re-enter password";
            txtConfirmPassword.Size = new Size(180, 24);
            txtConfirmPassword.TabIndex = 18;
            txtConfirmPassword.UseSystemPasswordChar = true;

            chkShowPassword.AutoSize = true;
            chkShowPassword.Cursor = Cursors.Hand;
            chkShowPassword.Font = new Font("Segoe UI", 9F);
            chkShowPassword.ForeColor = Color.FromArgb(71, 85, 105);
            chkShowPassword.Location = new Point(35, 415);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(113, 19);
            chkShowPassword.TabIndex = 19;
            chkShowPassword.Text = "Show passwords";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;

            lblErrorMessage.Font = new Font("Segoe UI", 9F);
            lblErrorMessage.ForeColor = Color.FromArgb(220, 38, 38);
            lblErrorMessage.Location = new Point(35, 440);
            lblErrorMessage.Name = "lblErrorMessage";
            lblErrorMessage.Size = new Size(380, 36);
            lblErrorMessage.TabIndex = 20;
            lblErrorMessage.TextAlign = ContentAlignment.MiddleLeft;

            btnCancel.BackColor = Color.FromArgb(248, 250, 252);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9.5F);
            btnCancel.ForeColor = Color.FromArgb(71, 85, 105);
            btnCancel.Location = new Point(35, 484);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(180, 42);
            btnCancel.TabIndex = 22;
            btnCancel.Text = "Back to Login";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;

            btnSignUp.BackColor = Color.FromArgb(0, 64, 0);
            btnSignUp.Cursor = Cursors.Hand;
            btnSignUp.FlatAppearance.BorderSize = 0;
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnSignUp.ForeColor = Color.White;
            btnSignUp.Location = new Point(235, 484);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(180, 42);
            btnSignUp.TabIndex = 21;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;

            AcceptButton = btnSignUp;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = btnCancel;
            ClientSize = new Size(450, 545);
            Controls.Add(pictureBox1);
            Controls.Add(lblTitle);
            Controls.Add(lblSubtitle);
            Controls.Add(lblFirstName);
            Controls.Add(txtFirstName);
            Controls.Add(lblLastName);
            Controls.Add(txtLastName);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblRole);
            Controls.Add(cmbRole);
            Controls.Add(lblIdNumber);
            Controls.Add(txtIdNumber);
            Controls.Add(lblProgramOrDept);
            Controls.Add(txtProgramOrDept);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblConfirmPassword);
            Controls.Add(txtConfirmPassword);
            Controls.Add(chkShowPassword);
            Controls.Add(lblErrorMessage);
            Controls.Add(btnCancel);
            Controls.Add(btnSignUp);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SignUpForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DCSS Meeting Scheduler - Sign Up";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
