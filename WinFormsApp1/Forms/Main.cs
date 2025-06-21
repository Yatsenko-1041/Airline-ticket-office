using System.Windows.Forms;
using WinFormsApp1.Models; // Замінити на ваш namespace, якщо інший

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        private AirportSystem airportSystem;

        public MainForm()
        {
            InitializeComponent();
            airportSystem = new AirportSystem();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string route = txtSearch.Text.Trim();
            var flights = airportSystem.TicketOffice.SearchFlight(route);

            lstFlights.DataSource = null;
            lstFlights.DataSource = flights;
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            var selectedFlight = lstFlights.SelectedItem as Flight;
            if (selectedFlight != null)
            {
                bool booked = airportSystem.TicketOffice.BookTicket(selectedFlight);
                MessageBox.Show(booked ? "Ticket successfully booked!" : "No seats available.");
            }
        }
    }
}