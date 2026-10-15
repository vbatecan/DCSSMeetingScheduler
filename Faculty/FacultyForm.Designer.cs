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
            label4 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            panelhome = new Panel();
            lblhomesub = new Label();
            lblhometitle = new Label();
            tabrequest = new TabPage();
            tabsetting = new TabPage();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            panel5 = new Panel();
            panel8 = new Panel();
            tabavail = new TabPage();
            label5 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            tabfaculty.SuspendLayout();
            tabhome.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panelhome.SuspendLayout();
            tabrequest.SuspendLayout();
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
            tabfaculty.Name = "tabfaculty";
            tabfaculty.SelectedIndex = 0;
            tabfaculty.Size = new Size(1258, 664);
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
            tabhome.Location = new Point(4, 34);
            tabhome.Name = "tabhome";
            tabhome.Padding = new Padding(3);
            tabhome.Size = new Size(1250, 626);
            tabhome.TabIndex = 0;
            tabhome.Text = "Home";
            tabhome.UseVisualStyleBackColor = true;
            tabhome.Click += tabhome_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(label4);
            panel4.Location = new Point(665, 309);
            panel4.Name = "panel4";
            panel4.Size = new Size(539, 150);
            panel4.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 17);
            label4.Name = "label4";
            label4.Size = new Size(93, 25);
            label4.TabIndex = 0;
            label4.Text = "DECLINED";
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Location = new Point(47, 309);
            panel3.Name = "panel3";
            panel3.Size = new Size(539, 150);
            panel3.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 12);
            label2.Name = "label2";
            label2.Size = new Size(102, 25);
            label2.TabIndex = 0;
            label2.Text = "APPROVED";
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Location = new Point(665, 135);
            panel2.Name = "panel2";
            panel2.Size = new Size(539, 150);
            panel2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 14);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 0;
            label3.Text = "PENDING";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(47, 135);
            panel1.Name = "panel1";
            panel1.Size = new Size(539, 150);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 16);
            label1.Name = "label1";
            label1.Size = new Size(140, 25);
            label1.TabIndex = 0;
            label1.Text = "TOTAL REQUEST";
            // 
            // panelhome
            // 
            panelhome.BackColor = Color.Gainsboro;
            panelhome.Controls.Add(lblhomesub);
            panelhome.Controls.Add(lblhometitle);
            panelhome.Dock = DockStyle.Top;
            panelhome.Location = new Point(3, 3);
            panelhome.Name = "panelhome";
            panelhome.Size = new Size(1244, 117);
            panelhome.TabIndex = 0;
            // 
            // lblhomesub
            // 
            lblhomesub.AutoSize = true;
            lblhomesub.Location = new Point(25, 64);
            lblhomesub.Name = "lblhomesub";
            lblhomesub.Size = new Size(432, 25);
            lblhomesub.TabIndex = 1;
            lblhomesub.Text = "Monitor and manage your student meeting requests.";
            // 
            // lblhometitle
            // 
            lblhometitle.AutoSize = true;
            lblhometitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblhometitle.Location = new Point(15, 16);
            lblhometitle.Name = "lblhometitle";
            lblhometitle.Size = new Size(372, 48);
            lblhometitle.TabIndex = 0;
            lblhometitle.Text = "Dashboard Overview";
            // 
            // tabrequest
            // 
            tabrequest.Controls.Add(flowLayoutPanel1);
            tabrequest.Controls.Add(label5);
            tabrequest.Controls.Add(button5);
            tabrequest.Controls.Add(button4);
            tabrequest.Controls.Add(button3);
            tabrequest.Controls.Add(button2);
            tabrequest.Controls.Add(button1);
            tabrequest.Controls.Add(textBox1);
            tabrequest.Location = new Point(4, 34);
            tabrequest.Name = "tabrequest";
            tabrequest.Padding = new Padding(3);
            tabrequest.Size = new Size(1250, 626);
            tabrequest.TabIndex = 1;
            tabrequest.Text = "Request";
            tabrequest.UseVisualStyleBackColor = true;
            tabrequest.Click += tabrequest_Click;
            // 
            // tabsetting
            // 
            tabsetting.Location = new Point(4, 34);
            tabsetting.Name = "tabsetting";
            tabsetting.Padding = new Padding(3);
            tabsetting.Size = new Size(1250, 626);
            tabsetting.TabIndex = 3;
            tabsetting.Text = "Settings";
            tabsetting.UseVisualStyleBackColor = true;
            tabsetting.Click += tabsetting_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(139, 17);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1092, 31);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(21, 14);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "SEARCH";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            button2.Location = new Point(661, 557);
            button2.Name = "button2";
            button2.Size = new Size(125, 42);
            button2.TabIndex = 3;
            button2.Text = "APPROVE";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            button3.Location = new Point(953, 557);
            button3.Name = "button3";
            button3.Size = new Size(125, 42);
            button3.TabIndex = 4;
            button3.Text = "REFRESH";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            button4.Location = new Point(807, 557);
            button4.Name = "button4";
            button4.Size = new Size(125, 42);
            button4.TabIndex = 5;
            button4.Text = "DECLINE";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            button5.Location = new Point(1096, 557);
            button5.Name = "button5";
            button5.Size = new Size(125, 42);
            button5.TabIndex = 6;
            button5.Text = "COMPLETE";
            button5.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Location = new Point(38, 40);
            panel5.Name = "panel5";
            panel5.Size = new Size(616, 150);
            panel5.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.Location = new Point(672, 40);
            panel8.Name = "panel8";
            panel8.Size = new Size(549, 150);
            panel8.TabIndex = 3;
            panel8.Paint += panel8_Paint;
            // 
            // tabavail
            // 
            tabavail.Controls.Add(panel8);
            tabavail.Controls.Add(panel5);
            tabavail.Location = new Point(4, 34);
            tabavail.Name = "tabavail";
            tabavail.Padding = new Padding(3);
            tabavail.Size = new Size(1250, 626);
            tabavail.TabIndex = 2;
            tabavail.Text = "Availability";
            tabavail.UseVisualStyleBackColor = true;
            tabavail.Click += tabavail_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(21, 62);
            label5.Name = "label5";
            label5.Size = new Size(178, 25);
            label5.TabIndex = 7;
            label5.Text = "MEETING REQUEST";
            label5.Click += label5_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(32, 99);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1189, 334);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // FacultyForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 664);
            Controls.Add(tabfaculty);
            Name = "FacultyForm";
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
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label5;
        private TabPage tabavail;
        private Panel panel8;
        private Panel panel5;
    }
}