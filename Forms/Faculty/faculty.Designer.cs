namespace DCSSMeetingScheduler.Faculty
{
    partial class faculty
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel4 = new Panel();
            label10 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            label9 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            label12 = new Label();
            label6 = new Label();
            panel2 = new Panel();
            label11 = new Label();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
<<<<<<< HEAD
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            label7 = new Label();
            label8 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
=======
            AvailabilityPage = new TabPage();
            groupBox2 = new GroupBox();
            Tips = new TextBox();
            EditBTN = new Button();
            DeleteBTN = new Button();
            SearchBTN = new Button();
            textBox2 = new TextBox();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            AddBTN = new Button();
            textBox1 = new TextBox();
            label5 = new Label();
            dateTimePicker3 = new DateTimePicker();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            tabPage4 = new TabPage();
            button1 = new Button();
            tabControl1.SuspendLayout();
            AvailabilityPage.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
>>>>>>> 46f27ea334064e4e1fb8ec2aa9f13c242e032cb1
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(AvailabilityPage);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(0, 94);
            tabControl1.Margin = new Padding(2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1011, 512);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2);
            tabPage1.Size = new Size(1003, 479);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Home";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
<<<<<<< HEAD
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(641, 108);
            panel4.Name = "panel4";
            panel4.Size = new Size(584, 108);
            panel4.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(45, 42);
            label10.Name = "label10";
            label10.Size = new Size(37, 45);
            label10.TabIndex = 1;
            label10.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(20, 17);
            label4.Name = "label4";
            label4.Size = new Size(81, 25);
            label4.TabIndex = 0;
            label4.Text = "Pending";
=======
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2);
            tabPage2.Size = new Size(1003, 479);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Request";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // AvailabilityPage
            // 
            AvailabilityPage.BackColor = Color.Transparent;
            AvailabilityPage.Controls.Add(groupBox2);
            AvailabilityPage.Controls.Add(groupBox1);
            AvailabilityPage.Location = new Point(4, 29);
            AvailabilityPage.Margin = new Padding(2);
            AvailabilityPage.Name = "AvailabilityPage";
            AvailabilityPage.Padding = new Padding(2);
            AvailabilityPage.Size = new Size(1003, 479);
            AvailabilityPage.TabIndex = 2;
            AvailabilityPage.Text = "Availabillity";
            AvailabilityPage.Click += AvailabilityPage_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Tips);
            groupBox2.Controls.Add(EditBTN);
            groupBox2.Controls.Add(DeleteBTN);
            groupBox2.Controls.Add(SearchBTN);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(332, 89);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(655, 385);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Weekly Consultation Hours";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // Tips
            // 
            Tips.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Tips.Location = new Point(6, 342);
            Tips.Name = "Tips";
            Tips.Size = new Size(462, 27);
            Tips.TabIndex = 5;
            Tips.Text = "Tips Click \"Add New\" to create new  consultation hours. ";
            // 
            // EditBTN
            // 
            EditBTN.Location = new Point(488, 340);
            EditBTN.Name = "EditBTN";
            EditBTN.Size = new Size(67, 29);
            EditBTN.TabIndex = 4;
            EditBTN.Text = "Edit";
            EditBTN.UseVisualStyleBackColor = true;
            // 
            // DeleteBTN
            // 
            DeleteBTN.Location = new Point(561, 340);
            DeleteBTN.Name = "DeleteBTN";
            DeleteBTN.Size = new Size(67, 29);
            DeleteBTN.TabIndex = 3;
            DeleteBTN.Text = "Delete";
            DeleteBTN.UseVisualStyleBackColor = true;
            // 
            // SearchBTN
            // 
            SearchBTN.Location = new Point(401, 15);
            SearchBTN.Name = "SearchBTN";
            SearchBTN.Size = new Size(67, 29);
            SearchBTN.TabIndex = 1;
            SearchBTN.Text = "Search";
            SearchBTN.UseVisualStyleBackColor = true;
>>>>>>> 46f27ea334064e4e1fb8ec2aa9f13c242e032cb1
            // 
            // textBox2
            // 
<<<<<<< HEAD
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(30, 108);
            panel1.Name = "panel1";
            panel1.Size = new Size(584, 108);
            panel1.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(50, 42);
            label9.Name = "label9";
            label9.Size = new Size(37, 45);
            label9.TabIndex = 1;
            label9.Text = "0";
=======
            textBox2.Location = new Point(401, 17);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(227, 27);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.FromArgb(240, 243, 246);
            dataGridView1.Location = new Point(6, 50);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(622, 284);
            dataGridView1.TabIndex = 0;
>>>>>>> 46f27ea334064e4e1fb8ec2aa9f13c242e032cb1
            // 
            // groupBox1
            // 
<<<<<<< HEAD
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(18, 17);
            label3.Name = "label3";
            label3.Size = new Size(125, 25);
            label3.TabIndex = 0;
            label3.Text = "Total Request";
            // 
            // panel3
            // 
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(641, 232);
            panel3.Name = "panel3";
            panel3.Size = new Size(584, 108);
            panel3.TabIndex = 7;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(45, 42);
            label12.Name = "label12";
            label12.Size = new Size(37, 45);
            label12.TabIndex = 2;
            label12.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(20, 17);
            label6.Name = "label6";
            label6.Size = new Size(85, 25);
            label6.TabIndex = 0;
            label6.Text = "Declined";
            // 
            // panel2
            // 
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(30, 232);
            panel2.Name = "panel2";
            panel2.Size = new Size(584, 108);
            panel2.TabIndex = 6;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(50, 42);
            label11.Name = "label11";
            label11.Size = new Size(37, 45);
            label11.TabIndex = 1;
            label11.Text = "0";
=======
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(AddBTN);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dateTimePicker3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(13, 89);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(297, 385);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add / Consultation Hours";
            // 
            // AddBTN
            // 
            AddBTN.Location = new Point(33, 294);
            AddBTN.Name = "AddBTN";
            AddBTN.Size = new Size(95, 30);
            AddBTN.TabIndex = 1;
            AddBTN.Text = "+   Add";
            AddBTN.UseVisualStyleBackColor = true;
            AddBTN.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(20, 241);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(255, 27);
            textBox1.TabIndex = 2;
            textBox1.Text = "  e.g Room 101, Online etc.";
>>>>>>> 46f27ea334064e4e1fb8ec2aa9f13c242e032cb1
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(20, 221);
            label5.Name = "label5";
            label5.Size = new Size(119, 17);
            label5.TabIndex = 6;
            label5.Text = "Location (Optional)";
            // 
<<<<<<< HEAD
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 49);
            label2.Name = "label2";
            label2.Size = new Size(228, 25);
            label2.TabIndex = 3;
            label2.Text = "Overview of faculty request";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(19, 21);
            label1.Name = "label1";
            label1.Size = new Size(243, 32);
            label1.TabIndex = 2;
            label1.Text = "HOME DASHBOARD";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1256, 537);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Request";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 34);
            tabPage3.Margin = new Padding(4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(4);
            tabPage3.Size = new Size(1256, 537);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Availabillity";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 34);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1256, 537);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Setting";
            tabPage4.UseVisualStyleBackColor = true;
=======
            // dateTimePicker3
            // 
            dateTimePicker3.CustomFormat = "hh:mm";
            dateTimePicker3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.Location = new Point(24, 181);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.ShowUpDown = true;
            dateTimePicker3.Size = new Size(251, 27);
            dateTimePicker3.TabIndex = 5;
>>>>>>> 46f27ea334064e4e1fb8ec2aa9f13c242e032cb1
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(20, 161);
            label4.Name = "label4";
            label4.Size = new Size(62, 17);
            label4.TabIndex = 4;
            label4.Text = "End Time";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "hh:mm";
            dateTimePicker1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(24, 118);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Size = new Size(251, 27);
            dateTimePicker1.TabIndex = 1;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
<<<<<<< HEAD
=======
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 98);
            label3.Name = "label3";
            label3.Size = new Size(67, 17);
            label3.TabIndex = 3;
            label3.Text = "Start Time";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" });
            comboBox1.Location = new Point(20, 50);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(255, 28);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 30);
            label2.Name = "label2";
            label2.Size = new Size(81, 17);
            label2.TabIndex = 2;
            label2.Text = "Day of Week";
            label2.Click += label2_Click;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 29);
            tabPage4.Margin = new Padding(2);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(2);
            tabPage4.Size = new Size(1003, 479);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Setting";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(163, 294);
            button1.Name = "button1";
            button1.Size = new Size(95, 30);
            button1.TabIndex = 7;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            // 
>>>>>>> 46f27ea334064e4e1fb8ec2aa9f13c242e032cb1
            // faculty
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 617);
            Controls.Add(tabControl1);
            Margin = new Padding(2);
            Name = "faculty";
            Text = "faculty";
            tabControl1.ResumeLayout(false);
<<<<<<< HEAD
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
=======
            AvailabilityPage.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
>>>>>>> 46f27ea334064e4e1fb8ec2aa9f13c242e032cb1
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage AvailabilityPage;
        private TabPage tabPage4;
        private GroupBox groupBox1;
        private ComboBox comboBox1;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker3;
        private Label label4;
        private Button button2;
        private Button AddBTN;
        private TextBox textBox1;
        private Label label5;
<<<<<<< HEAD
        private Label label7;
        private Label label8;
        private Label label10;
        private Label label9;
        private Label label12;
        private Label label11;
=======
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private TextBox textBox2;
        private Button SearchBTN;
        private TextBox Tips;
        private Button EditBTN;
        private Button DeleteBTN;
        private Button button1;
>>>>>>> 46f27ea334064e4e1fb8ec2aa9f13c242e032cb1
    }
}