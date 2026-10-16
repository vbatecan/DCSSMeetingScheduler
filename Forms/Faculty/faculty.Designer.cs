namespace DCSSMeetingScheduler.Forms.Faculty
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
            tabPage2 = new TabPage();
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
            tabControl1.SuspendLayout();
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
            tabPage1.Location = new Point(4, 34);
            tabPage1.Margin = new Padding(4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1256, 566);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Home";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1256, 566);
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
            // 
            // textBox2
            // 
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
            // 
            // groupBox1
            // 
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
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1256, 537);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Availabillity";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 29);
            tabPage4.Margin = new Padding(2);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1256, 537);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Setting";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // faculty
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 690);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(tabControl1);
            Margin = new Padding(2);
            Name = "faculty";
            Text = "Faculty Form";
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage AvailabilityPage;
        private TabPage tabPage4;
    }
}