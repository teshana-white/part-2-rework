﻿namespace ST10085201_PROG7312_POE_Part1
{
    partial class LocalEventsForm
    {
        private System.ComponentModel.IContainer components = null;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocalEventsForm));
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbSearchResults = new System.Windows.Forms.ListBox();
            this.lblSearchResults = new System.Windows.Forms.Label();
            this.lbAnnouncements = new System.Windows.Forms.ListBox();
            this.lbAllEvents = new System.Windows.Forms.ListBox();
            this.lblAllEvents = new System.Windows.Forms.Label();
            this.lblAnnouncements = new System.Windows.Forms.Label();
            this.dtpSearchDate = new System.Windows.Forms.DateTimePicker();
            this.cmbSearchCategory = new System.Windows.Forms.ComboBox();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbSearchHistory = new System.Windows.Forms.ListBox();
            this.lblSearchHistory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(16, 18);
            this.txtSearchName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(223, 26);
            this.txtSearchName.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(572, 13);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(78, 37);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbSearchResults
            // 
            this.lbSearchResults.FormattingEnabled = true;
            this.lbSearchResults.ItemHeight = 20;
            this.lbSearchResults.Location = new System.Drawing.Point(16, 91);
            this.lbSearchResults.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbSearchResults.Name = "lbSearchResults";
            this.lbSearchResults.Size = new System.Drawing.Size(202, 44);
            this.lbSearchResults.TabIndex = 2;
            this.lbSearchResults.SelectedIndexChanged += new System.EventHandler(this.lbSearchResults_SelectedIndexChanged);
            // 
            // lblSearchResults
            // 
            this.lblSearchResults.AutoSize = true;
            this.lblSearchResults.Location = new System.Drawing.Point(12, 66);
            this.lblSearchResults.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchResults.Name = "lblSearchResults";
            this.lblSearchResults.Size = new System.Drawing.Size(103, 20);
            this.lblSearchResults.TabIndex = 3;
            this.lblSearchResults.Text = "Search Results:";
            // 
            // lbAnnouncements
            // 
            this.lbAnnouncements.FormattingEnabled = true;
            this.lbAnnouncements.ItemHeight = 20;
            this.lbAnnouncements.Location = new System.Drawing.Point(447, 91);
            this.lbAnnouncements.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbAnnouncements.Name = "lbAnnouncements";
            this.lbAnnouncements.Size = new System.Drawing.Size(203, 324);
            this.lbAnnouncements.TabIndex = 4;
            // 
            // lbAllEvents
            // 
            this.lbAllEvents.FormattingEnabled = true;
            this.lbAllEvents.ItemHeight = 20;
            this.lbAllEvents.Location = new System.Drawing.Point(16, 251);
            this.lbAllEvents.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbAllEvents.Name = "lbAllEvents";
            this.lbAllEvents.Size = new System.Drawing.Size(423, 164);
            this.lbAllEvents.TabIndex = 5;
            this.lbAllEvents.SelectedIndexChanged += new System.EventHandler(this.lbAllEvents_SelectedIndexChanged);
            // 
            // lblAllEvents
            // 
            this.lblAllEvents.AutoSize = true;
            this.lblAllEvents.Location = new System.Drawing.Point(12, 226);
            this.lblAllEvents.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAllEvents.Name = "lblAllEvents";
            this.lblAllEvents.Size = new System.Drawing.Size(73, 20);
            this.lblAllEvents.TabIndex = 6;
            this.lblAllEvents.Text = "All Events:";
            this.lblAllEvents.Click += new System.EventHandler(this.lblAllEvents_Click);
            // 
            // lblAnnouncements
            // 
            this.lblAnnouncements.AutoSize = true;
            this.lblAnnouncements.Location = new System.Drawing.Point(443, 66);
            this.lblAnnouncements.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnnouncements.Name = "lblAnnouncements";
            this.lblAnnouncements.Size = new System.Drawing.Size(109, 20);
            this.lblAnnouncements.TabIndex = 7;
            this.lblAnnouncements.Text = "Announcements:";
            // 
            // dtpSearchDate
            // 
            this.dtpSearchDate.Location = new System.Drawing.Point(246, 18);
            this.dtpSearchDate.Name = "dtpSearchDate";
            this.dtpSearchDate.Size = new System.Drawing.Size(185, 26);
            this.dtpSearchDate.TabIndex = 8;
            // 
            // cmbSearchCategory
            // 
            this.cmbSearchCategory.FormattingEnabled = true;
            this.cmbSearchCategory.Location = new System.Drawing.Point(437, 18);
            this.cmbSearchCategory.Name = "cmbSearchCategory";
            this.cmbSearchCategory.Size = new System.Drawing.Size(128, 28);
            this.cmbSearchCategory.TabIndex = 9;
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.Location = new System.Drawing.Point(145, 423);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(169, 50);
            this.btnBackToMenu.TabIndex = 10;
            this.btnBackToMenu.Text = "Back to Main Menu";
            this.btnBackToMenu.UseVisualStyleBackColor = true;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(320, 423);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(169, 50);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // lbSearchHistory
            // 
            this.lbSearchHistory.FormattingEnabled = true;
            this.lbSearchHistory.ItemHeight = 20;
            this.lbSearchHistory.Location = new System.Drawing.Point(16, 171);
            this.lbSearchHistory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbSearchHistory.Name = "lbSearchHistory";
            this.lbSearchHistory.Size = new System.Drawing.Size(202, 44);
            this.lbSearchHistory.TabIndex = 12;
            // 
            // lblSearchHistory
            // 
            this.lblSearchHistory.AutoSize = true;
            this.lblSearchHistory.Location = new System.Drawing.Point(12, 146);
            this.lblSearchHistory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchHistory.Name = "lblSearchHistory";
            this.lblSearchHistory.Size = new System.Drawing.Size(100, 20);
            this.lblSearchHistory.TabIndex = 13;
            this.lblSearchHistory.Text = "Search History:";
            this.lblSearchHistory.Click += new System.EventHandler(this.lblSearchHistory_Click);
            // 
            // LocalEventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 483);
            this.Controls.Add(this.lblSearchHistory);
            this.Controls.Add(this.lbSearchHistory);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBackToMenu);
            this.Controls.Add(this.cmbSearchCategory);
            this.Controls.Add(this.dtpSearchDate);
            this.Controls.Add(this.lblAnnouncements);
            this.Controls.Add(this.lblAllEvents);
            this.Controls.Add(this.lbAllEvents);
            this.Controls.Add(this.lbAnnouncements);
            this.Controls.Add(this.lblSearchResults);
            this.Controls.Add(this.lbSearchResults);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchName);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LocalEventsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Local Events and Announcements";
            this.Load += new System.EventHandler(this.LocalEventsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox lbSearchResults;
        private System.Windows.Forms.Label lblSearchResults;
        private System.Windows.Forms.ListBox lbAnnouncements;
        private System.Windows.Forms.ListBox lbAllEvents;
        private System.Windows.Forms.Label lblAllEvents;
        private System.Windows.Forms.Label lblAnnouncements;
        private System.Windows.Forms.DateTimePicker dtpSearchDate;
        private System.Windows.Forms.ComboBox cmbSearchCategory;
        private System.Windows.Forms.Button btnBackToMenu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lbSearchHistory;
        private System.Windows.Forms.Label lblSearchHistory;
    }
}