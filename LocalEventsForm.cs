using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ST10085201_PROG7312_POE_Part1
{
    public partial class LocalEventsForm : Form
    {
        private EventHandler eventHandler;

        public LocalEventsForm()
        {
            InitializeComponent();
            eventHandler = new EventHandler();
            LoadEvents();
            DisplayEvents();
        }

        private void LoadEvents()
        {
            // Load sample events
            eventHandler.AddEvent(new Events("CPT Jazz, Festival", "Cultural", new DateTime(2025, 04, 04), "Kaapse Klopse", false));

            eventHandler.AddEvent(new Events("AESIS 2024", "Professional", new DateTime(2024, 11, 28), "African Early Stage Investor Summit 2024", true));

            eventHandler.AddEvent(new Events("France Olympics", "Sports", new DateTime(2024, 07, 26), "Olympic games held in France", false));

            eventHandler.AddEvent(new Events("Budget speech", "Political", new DateTime(2024, 02, 21), "Discussion on national budget and allocation of tax funds", true));

            eventHandler.AddEvent(new Events("BRICS Parliament Forum", "Political", new DateTime(2023, 09, 27), "9th BRICS Parliament Forum 2023: South Africa", true));

            eventHandler.AddEvent(new Events("Teshana Day", "Other", new DateTime(2025, 05, 20), "Teshana's birthday", false));

            eventHandler.AddEvent(new Events("Niel Diamond Tribute", "Cultural", new DateTime(2024, 11, 01), "Niel Diamond Tribute ft Johan Liebenberg at the Music Kitchen", false));

            eventHandler.AddEvent(new Events("Golf Day", "Sports", new DateTime(2024, 11, 01), "St John's Centre of Concern Golf Day at Walmer Golf Club", false));

            eventHandler.AddEvent(new Events("NMB 10km", "Other", new DateTime(2024, 11, 02), "NMB Choose to Challenge 10km Non-Profit Event", true));

            eventHandler.AddEvent(new Events("LSSATS", "Professional", new DateTime(2024, 10, 28), "Leadership in Shaping South Africa's Transport Sector conference event", true));

            eventHandler.AddEvent(new Events("Final Submission", "Professional", new DateTime(2024, 11, 18), "Final submission for PROG7312", true));
        }

        private void DisplayEvents()
        {
            lbAllEvents.Items.Clear();
            lbAnnouncements.Items.Clear();
            lbSearchHistory.Items.Clear();

            // Display all events
            foreach (var ev in eventHandler.GetAllEvents())
            {
                lbAllEvents.Items.Add($"{ev.Name} - {ev.Date:MM/dd/yyyy}");
            }

            // Display announcements (only name and date)
            foreach (var ev in eventHandler.GetAnnouncements())
            {
                lbAnnouncements.Items.Add($"{ev.Name} - {ev.Date:MM/dd/yyyy}");
            }

            // Display search history
            foreach (var query in eventHandler.GetSearchHistory())
            {
                lbSearchHistory.Items.Add(query);
            }
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            // Return to main menu
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
            eventHandler.ClearSearchResults();
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = txtSearchName.Text;
            DateTime? date = dtpSearchDate.Checked ? dtpSearchDate.Value : (DateTime?)null;
            string category = cmbSearchCategory.SelectedItem?.ToString();

            lbSearchResults.Items.Clear();
            foreach (var ev in eventHandler.SearchEvents(name, date, category))
                lbSearchResults.Items.Add($"{ev.Name} - {ev.Date:yyyy/MM/dd}");

            // Update search history display
            lbSearchHistory.Items.Clear();
            foreach (var query in eventHandler.GetSearchHistory())
            {
                lbSearchHistory.Items.Add(query);
            }
        }

        private void DisplayEventDetails(string selectedEvent)
        {
            // Extract event name from the selected item (e.g., "Event Name - Date")
            string selectedEventName = selectedEvent?.Split('-')[0].Trim();

            // Find the selected event by name and display full details
            var ev = eventHandler.GetAllEvents().FirstOrDefault(e => e.Name == selectedEventName);
           
        }

        private void lbAnnouncements_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayEventDetails(lbAnnouncements.SelectedItem?.ToString());
        }

        private void lbSearchResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayEventDetails(lbSearchResults.SelectedItem?.ToString());
        }

        private void lbAllEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayEventDetails(lbAllEvents.SelectedItem?.ToString());
        }

        private void LocalEventsForm_Load(object sender, EventArgs e)
        {
            DisplayEvents();
        }

        private void LocalEventsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            eventHandler.ClearSearchResults();
        }

        private void lblSearchHistory_Click(object sender, EventArgs e)
        {

        }

        private void lblAllEvents_Click(object sender, EventArgs e)
        {

        }
    }
}


