namespace DCSSMeetingScheduler.Admin {
    partial class AdminForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            tabControl1 = new TabControl();
            tabHome = new TabPage();
            tabUsers = new TabPage();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            btnSearch = new Button();
            txtSearchName = new TextBox();
            label2 = new Label();
            dgvUsers = new DataGridView();
            panel1 = new Panel();
            lblGreeting = new Label();
            btnLogout = new Button();
            label1 = new Label();
            tabControl1.SuspendLayout();
            tabUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabHome);
            tabControl1.Controls.Add(tabUsers);
            tabControl1.Location = new Point(10, 68);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1242, 610);
            tabControl1.TabIndex = 1;
            // 
            // tabHome
            // 
            tabHome.BorderStyle = BorderStyle.FixedSingle;
            tabHome.Location = new Point(4, 22);
            tabHome.Name = "tabHome";
            tabHome.Padding = new Padding(3);
            tabHome.Size = new Size(1234, 584);
            tabHome.TabIndex = 0;
            tabHome.Text = "Home";
            tabHome.UseVisualStyleBackColor = true;
            // 
            // tabUsers
            // 
            tabUsers.BorderStyle = BorderStyle.FixedSingle;
            tabUsers.Controls.Add(btnDelete);
            tabUsers.Controls.Add(btnUpdate);
            tabUsers.Controls.Add(btnSave);
            tabUsers.Controls.Add(btnSearch);
            tabUsers.Controls.Add(txtSearchName);
            tabUsers.Controls.Add(label2);
            tabUsers.Controls.Add(dgvUsers);
            tabUsers.Font = new Font("Microsoft Sans Serif", 12.25F);
            tabUsers.Location = new Point(4, 24);
            tabUsers.Name = "tabUsers";
            tabUsers.Padding = new Padding(8);
            tabUsers.Size = new Size(1234, 582);
            tabUsers.TabIndex = 1;
            tabUsers.Text = "Users";
            tabUsers.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Tomato;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = SystemColors.Control;
            btnDelete.Location = new Point(849, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 31);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.CornflowerBlue;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = SystemColors.Control;
            btnUpdate.Location = new Point(975, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 31);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(85, 121, 69);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = SystemColors.Control;
            btnSave.Location = new Point(1101, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 31);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.CornflowerBlue;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Microsoft Sans Serif", 10.25F);
            btnSearch.ForeColor = SystemColors.Control;
            btnSearch.Location = new Point(660, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(120, 32);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearchName
            // 
            txtSearchName.Location = new Point(152, 5);
            txtSearchName.Name = "txtSearchName";
            txtSearchName.Size = new Size(502, 26);
            txtSearchName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 8);
            label2.Name = "label2";
            label2.Size = new Size(135, 20);
            label2.TabIndex = 1;
            label2.Text = "Search by name:";
            // 
            // dgvUsers
            // 
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvUsers.BackgroundColor = SystemColors.Control;
            dgvUsers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(11, 37);
            dgvUsers.MultiSelect = false;
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.Size = new Size(1210, 534);
            dgvUsers.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(85, 121, 69);
            panel1.Controls.Add(lblGreeting);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.Control;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1264, 63);
            panel1.TabIndex = 2;
            // 
            // lblGreeting
            // 
            lblGreeting.AutoSize = true;
            lblGreeting.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGreeting.Location = new Point(14, 29);
            lblGreeting.Name = "lblGreeting";
            lblGreeting.Size = new Size(190, 17);
            lblGreeting.TabIndex = 2;
            lblGreeting.Text = "Welcome Vince Angelo Batecan";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(192, 0, 0);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Location = new Point(1173, 19);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(79, 27);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 8);
            label1.Name = "label1";
            label1.Size = new Size(340, 21);
            label1.TabIndex = 0;
            label1.Text = "DCSS Meeting Scheduler Admin Dashboard";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 690);
            Controls.Add(panel1);
            Controls.Add(tabControl1);
            Font = new Font("Microsoft Sans Serif", 8.25F);
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Form";
            Load += AdminForm_Load;
            tabControl1.ResumeLayout(false);
            tabUsers.ResumeLayout(false);
            tabUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabHome;
        private TabPage tabUsers;
        private Panel panel1;
        private Button btnLogout;
        private Label label1;
        private Label lblGreeting;
        private Button btnSearch;
        private TextBox txtSearchName;
        private Label label2;
        private DataGridView dgvUsers;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnSave;
    }
}