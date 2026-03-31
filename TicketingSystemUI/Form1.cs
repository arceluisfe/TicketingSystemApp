using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TicketingSystemUI
{
    public partial class Form1 : Form
    {
        // 1. These MUST be here at the top (The Definitions)
        private List<TicketingSystemApp.Models.Ticket> myTickets = new List<TicketingSystemApp.Models.Ticket>();
        private ListBox lstDashboard = new ListBox();
        private TextBox txtTitle = new TextBox();
        private ComboBox cmbPriority = new ComboBox();
        private Label lblTitle = new Label();
        private Label lblPriority = new Label();

        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(450, 550);
            this.Text = "Advanced Ticket Creator";

            // Setup Title Input
            lblTitle.Text = "Issue Title:";
            lblTitle.Location = new Point(20, 20);
            txtTitle.Location = new Point(20, 40);
            txtTitle.Size = new Size(200, 25);

            // Setup Priority Input
            lblPriority.Text = "Priority:";
            lblPriority.Location = new Point(240, 20);
            cmbPriority.Location = new Point(240, 40);
            cmbPriority.Size = new Size(120, 25);
            cmbPriority.Items.AddRange(new string[] { "Low", "Medium", "High", "Critical" });
            cmbPriority.SelectedIndex = 0;

            // Setup Button
            Button btnCreate = new Button();
            btnCreate.Text = "Add to System";
            btnCreate.Location = new Point(20, 80);
            btnCreate.Size = new Size(340, 35);
            btnCreate.BackColor = Color.LightBlue;

            // Setup Dashboard
            lstDashboard.Location = new Point(20, 130);
            lstDashboard.Size = new Size(390, 350);

            // Button Action
            btnCreate.Click += (s, e) => {
                if (!string.IsNullOrEmpty(txtTitle.Text)) {
                    var newT = new TicketingSystemApp.Models.Ticket { 
                        Id = myTickets.Count + 101, 
                        Title = txtTitle.Text, 
                        Priority = cmbPriority.SelectedItem.ToString() ?? "Low"
                    };
                    myTickets.Add(newT);
                    lstDashboard.Items.Add($"[{newT.Priority}] {newT.Title} (ID: {newT.Id})");
                    txtTitle.Clear();
                }
            };

            // Add all controls to the screen
            this.Controls.Add(lblTitle);
            this.Controls.Add(txtTitle);
            this.Controls.Add(lblPriority);
            this.Controls.Add(cmbPriority);
            this.Controls.Add(btnCreate);
            this.Controls.Add(lstDashboard);
        }
    }
}