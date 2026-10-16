using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DCSSMeetingScheduler.Student
{
    public partial class StudentForm : Form
    {

        private User? loggedInUser = null;

        public StudentForm()
        {
            InitializeComponent();
        }

        public StudentForm(User user)
        {
            InitializeComponent();
            loggedInUser = user;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
