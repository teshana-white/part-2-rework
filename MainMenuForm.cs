using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ST10085201_PROG7312_POE_Part1
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
            // Disable options that are not yet implemented as stated by the question paper
            btnServiceStatus.Enabled = false;
        }

        // Opens the Report Issues Form so that user may record an issue on the application 
        private void btnReportIssues_Click_1(object sender, EventArgs e)
        {
            ReportIssuesForm reportForm = new ReportIssuesForm();
            reportForm.Show();
            this.Hide(); // Hides the main form
        }

        // Opens the Local Events and Announcements Form so that user may record an issue on the application 
        private void btnLocalEvents_Click_1(object sender, EventArgs e)
        {
            LocalEventsForm eventsAndAnnouncementsForm = new LocalEventsForm();
            eventsAndAnnouncementsForm.Show();
            this.Hide(); // Hides the main form
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e) // fixed the exit button that previously did not work
        {
            // Closes the application
            Application.Exit();
        }

        private void MainMenuForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
