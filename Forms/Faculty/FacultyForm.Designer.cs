namespace DCSSMeetingScheduler.Faculty
{
    partial class FacultyForm
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
            tabfaculty = new TabControl();
            tabhome = new TabPage();
            panel4 = new Panel();
            label9 = new Label();
            label4 = new Label();
            panel3 = new Panel();
            label7 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            label8 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            label6 = new Label();
            label1 = new Label();
            panelhome = new Panel();
            lblhomesub = new Label();
            lblhometitle = new Label();
            tabrequest = new TabPage();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            tabavail = new TabPage();
            panel8 = new Panel();
            panel5 = new Panel();
            tabsetting = new TabPage();
            tabfaculty.SuspendLayout();
            tabhome.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panelhome.SuspendLayout();
            tabrequest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabavail.SuspendLayout();
            SuspendLayout();
            // 
            // tabfaculty
            // 
            tabfaculty.Controls.Add(tabhome);
            tabfaculty.Controls.Add(tabrequest);
            tabfaculty.Controls.Add(tabavail);
            tabfaculty.Controls.Add(tabsetting);
            tabfaculty.Dock = DockStyle.Fill;
            tabfaculty.Location = new Point(0, 0);
            tabfaculty.Margin = new Padding(2, 3, 2, 3);
            tabfaculty.Name = "tabfaculty";
            tabfaculty.SelectedIndex = 0;
            tabfaculty.Size = new Size(1007, 531);
            tabfaculty.TabIndex = 0;
            tabfaculty.TabIndexChanged += tabfaculty_TabIndexChanged;
            // 
            // tabhome
            // 
            tabhome.Controls.Add(panel4);
            tabhome.Controls.Add(panel3);
            tabhome.Controls.Add(panel2);
            tabhome.Controls.Add(panel1);
            tabhome.Controls.Add(panelhome);
            tabhome.Location = new Point(4, 29);
            tabhome.Margin = new Padding(2, 3, 2, 3);
            tabhome.Name = "tabhome";
            tabhome.Padding = new Padding(2, 3, 2, 3);
            tabhome.Size = new Size(999, 498);
            tabhome.TabIndex = 0;
            tabhome.Text = "Home";
            tabhome.UseVisualStyleBackColor = true;
            tabhome.Click += tabhome_Click;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(743, 111);
            panel4.Margin = new Padding(2, 3, 2, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(237, 87);
            panel4.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 18F);
            label9.Location = new Point(3, 33);
            label9.Name = "label9";
            label9.Size = new Size(32, 36);
            label9.TabIndex = 5;
            label9.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 13);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 0;
            label4.Text = "DECLINED";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(501, 111);
            panel3.Margin = new Padding(2, 3, 2, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(237, 87);
            panel3.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 18F);
            label7.Location = new Point(19, 33);
            label7.Name = "label7";
            label7.Size = new Size(32, 36);
            label7.TabIndex = 3;
            label7.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 9);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 0;
            label2.Text = "APPROVED";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(258, 111);
            panel2.Margin = new Padding(2, 3, 2, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(237, 87);
            panel2.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 18F);
            label8.Location = new Point(3, 33);
            label8.Name = "label8";
            label8.Size = new Size(32, 36);
            label8.TabIndex = 4;
            label8.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 9);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 0;
            label3.Text = "PENDING";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(16, 111);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(237, 87);
            panel1.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 18F);
            label6.Location = new Point(13, 33);
            label6.Name = "label6";
            label6.Size = new Size(32, 36);
            label6.TabIndex = 2;
            label6.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 13);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 0;
            label1.Text = "TOTAL REQUEST";
            // 
            // panelhome
            // 
            panelhome.BackColor = Color.FromArgb(85, 121, 69);
            panelhome.Controls.Add(lblhomesub);
            panelhome.Controls.Add(lblhometitle);
            panelhome.Dock = DockStyle.Top;
            panelhome.Location = new Point(2, 3);
            panelhome.Margin = new Padding(2, 3, 2, 3);
            panelhome.Name = "panelhome";
            panelhome.Size = new Size(995, 93);
            panelhome.TabIndex = 0;
            // 
            // lblhomesub
            // 
            lblhomesub.AutoSize = true;
            lblhomesub.ForeColor = SystemColors.Control;
            lblhomesub.Location = new Point(17, 56);
            lblhomesub.Margin = new Padding(2, 0, 2, 0);
            lblhomesub.Name = "lblhomesub";
            lblhomesub.Size = new Size(356, 20);
            lblhomesub.TabIndex = 1;
            lblhomesub.Text = "Monitor and manage your student meeting requests.";
            // 
            // lblhometitle
            // 
            lblhometitle.AutoSize = true;
            lblhometitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblhometitle.ForeColor = SystemColors.Control;
            lblhometitle.Location = new Point(11, 13);
            lblhometitle.Margin = new Padding(2, 0, 2, 0);
            lblhometitle.Name = "lblhometitle";
            lblhometitle.Size = new Size(312, 41);
            lblhometitle.TabIndex = 0;
            lblhometitle.Text = "Dashboard Overview";
            // 
            // tabrequest
            // 
            tabrequest.Controls.Add(dataGridView1);
            tabrequest.Controls.Add(label5);
            tabrequest.Controls.Add(button5);
            tabrequest.Controls.Add(button4);
            tabrequest.Controls.Add(button3);
            tabrequest.Controls.Add(button2);
            tabrequest.Controls.Add(button1);
            tabrequest.Controls.Add(textBox1);
            tabrequest.Location = new Point(4, 29);
            tabrequest.Margin = new Padding(2, 3, 2, 3);
            tabrequest.Name = "tabrequest";
            tabrequest.Padding = new Padding(2, 3, 2, 3);
            tabrequest.Size = new Size(999, 498);
            tabrequest.TabIndex = 1;
            tabrequest.Text = "Request";
            tabrequest.UseVisualStyleBackColor = true;
            tabrequest.Click += tabrequest_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 73);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(969, 365);
            dataGridView1.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(17, 49);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(145, 20);
            label5.TabIndex = 7;
            label5.Text = "MEETING REQUEST";
            label5.Click += label5_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            button5.Location = new Point(886, 443);
            button5.Margin = new Padding(2, 3, 2, 3);
            button5.Name = "button5";
            button5.Size = new Size(101, 43);
            button5.TabIndex = 6;
            button5.Text = "COMPLETE";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            button4.Location = new Point(675, 443);
            button4.Margin = new Padding(2, 3, 2, 3);
            button4.Name = "button4";
            button4.Size = new Size(101, 43);
            button4.TabIndex = 5;
            button4.Text = "DECLINE";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            button3.Location = new Point(781, 443);
            button3.Margin = new Padding(2, 3, 2, 3);
            button3.Name = "button3";
            button3.Size = new Size(101, 43);
            button3.TabIndex = 4;
            button3.Text = "REFRESH";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            button2.Location = new Point(570, 443);
            button2.Margin = new Padding(2, 3, 2, 3);
            button2.Name = "button2";
            button2.Size = new Size(101, 41);
            button2.TabIndex = 3;
            button2.Text = "APPROVE";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(17, 11);
            button1.Margin = new Padding(2, 3, 2, 3);
            button1.Name = "button1";
            button1.Size = new Size(89, 27);
            button1.TabIndex = 2;
            button1.Text = "SEARCH";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(111, 13);
            textBox1.Margin = new Padding(2, 3, 2, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(875, 27);
            textBox1.TabIndex = 0;
            // 
            // tabavail
            // 
            tabavail.Controls.Add(panel8);
            tabavail.Controls.Add(panel5);
            tabavail.Location = new Point(4, 29);
            tabavail.Margin = new Padding(2, 3, 2, 3);
            tabavail.Name = "tabavail";
            tabavail.Padding = new Padding(2, 3, 2, 3);
            tabavail.Size = new Size(999, 498);
            tabavail.TabIndex = 2;
            tabavail.Text = "Availability";
            tabavail.UseVisualStyleBackColor = true;
            tabavail.Click += tabavail_Click;
            // 
            // panel8
            // 
            panel8.Location = new Point(541, 32);
            panel8.Margin = new Padding(2, 3, 2, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(435, 120);
            panel8.TabIndex = 3;
            panel8.Paint += panel8_Paint;
            // 
            // panel5
            // 
            panel5.Location = new Point(24, 32);
            panel5.Margin = new Padding(2, 3, 2, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(449, 120);
            panel5.TabIndex = 0;
            panel5.Paint += panel5_Paint;
            // 
            // tabsetting
            // 
            tabsetting.Location = new Point(4, 29);
            tabsetting.Margin = new Padding(2, 3, 2, 3);
            tabsetting.Name = "tabsetting";
            tabsetting.Padding = new Padding(2, 3, 2, 3);
            tabsetting.Size = new Size(999, 498);
            tabsetting.TabIndex = 3;
            tabsetting.Text = "Settings";
            tabsetting.UseVisualStyleBackColor = true;
            tabsetting.Click += tabsetting_Click;
            // 
            // FacultyForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 531);
            Controls.Add(tabfaculty);
            Margin = new Padding(2, 3, 2, 3);
            Name = "FacultyForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FACULTY FORM";
            tabfaculty.ResumeLayout(false);
            tabhome.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelhome.ResumeLayout(false);
            panelhome.PerformLayout();
            tabrequest.ResumeLayout(false);
            tabrequest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabavail.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabfaculty;
        private TabPage tabhome;
        private TabPage tabrequest;
        private TabPage tabsetting;
        private Panel panelhome;
        private Label lblhomesub;
        private Label lblhometitle;
        private Panel panel4;
        private Label label4;
        private Panel panel3;
        private Label label2;
        private Panel panel2;
        private Label label3;
        private Panel panel1;
        private Label label1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox1;
        private Label label5;
        private TabPage tabavail;
        private Panel panel8;
        private Panel panel5;
        private Label label9;
        private Label label7;
        private Label label8;
        private Label label6;
        private DataGridView dataGridView1;
    }
}