using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DCSSMeetingScheduler.Faculty
{
    public partial class FacultyForm : Form
    {
        public FacultyForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabhome_Click(object sender, EventArgs e)
        {
            tabfaculty.SelectedTab = tabhome;
        }

        private void tabrequest_Click(object sender, EventArgs e)
        {
            tabfaculty.SelectedTab = tabrequest;
        }

        private void tabavail_Click(object sender, EventArgs e)
        {
            tabfaculty.SelectedTab = tabavail;
        }

        private void tabsetting_Click(object sender, EventArgs e)
        {
            tabfaculty.SelectedTab = tabsetting;
        }

        private void tabfaculty_TabIndexChanged(object sender, EventArgs e)
        {
            if (tabfaculty.SelectedTab == tabhome)
            {
                LoadDashboardCounts();
                LoadRecentRequests();
            }
            else if (tabfaculty.SelectedTab == tabrequest)
            {
                Loadrequests();
            }
            else if (tabfaculty.SelectedTab == tabavail)
            {
                Loadavailability();
            }
            else if (tabfaculty.SelectedTab == tabsetting) ;
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
}
