using System;
using System.Windows.Forms;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        private readonly AirportSystem airportSystem = new AirportSystem();

        public MainForm()
        {
            InitializeComponent();
            LoadDestinations();
            RefreshFlights();
        }

        private void LoadDestinations()
        {
            cbDestination.Items.Clear();
            foreach (var flight in airportSystem.TicketOffice.Flights)
            {
                if (!cbDestination.Items.Contains(flight.Route))
                    cbDestination.Items.Add(flight.Route);
            }
        }

        private void RefreshFlights()
        {
            dgvFlights.DataSource = null;
            dgvFlights.AutoGenerateColumns = true;
            dgvFlights.DataSource = airportSystem.TicketOffice.Flights;
         

            if (dgvFlights.Columns["DepartureTime"] != null)
                dgvFlights.Columns["DepartureTime"].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm";

            if (dgvFlights.Columns["ArrivalTime"] != null)
                dgvFlights.Columns["ArrivalTime"].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm";

            if (dgvFlights.Columns["Price"] != null)
                dgvFlights.Columns["Price"].DefaultCellStyle.Format = "C2";
            dgvFlights.Refresh();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var destination = cbDestination.SelectedItem?.ToString();
            if (string.IsNullOrWhiteSpace(destination)) return;

            var flight = airportSystem.TicketOffice.FindNextFlight(destination);
            if (flight != null)
            {
                dgvFlights.DataSource = null;
                dgvFlights.AutoGenerateColumns = true;
                dgvFlights.DataSource = new[] { flight };

                if (dgvFlights.Columns["DepartureTime"] != null)
                    dgvFlights.Columns["DepartureTime"].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm";

                if (dgvFlights.Columns["ArrivalTime"] != null)
                    dgvFlights.Columns["ArrivalTime"].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm";

                dgvFlights.Refresh();

                toolStripStatusLabel1.Text = $"Знайдено рейс №{flight.FlightNumber} до {flight.Route}";
            }
            else
            {
                toolStripStatusLabel1.Text = "Немає доступного рейсу";
                dgvFlights.DataSource = null;
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (dgvFlights.CurrentRow?.DataBoundItem is not Flight flight) return;
            int count = (int)numTickets.Value;
            string name = tbPassengerName.Text.Trim();

            if (count <= 0 || string.IsNullOrWhiteSpace(name)) return;

            if (flight.AvailableSeats >= count)
            {
                for (int i = 0; i < count; i++)
                {
                    airportSystem.TicketOffice.SellTicket(flight, new Passenger { FullName = name });
                }

                RefreshFlights();
                toolStripStatusLabel1.Text = $"Продано {count} квитків на рейс №{flight.FlightNumber}";
            }
            else
            {
                toolStripStatusLabel1.Text = "Недостатньо вільних місць";
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            
            var euroCulture = new System.Globalization.CultureInfo("de-DE");
            System.Threading.Thread.CurrentThread.CurrentCulture = euroCulture;
            System.Threading.Thread.CurrentThread.CurrentUICulture = euroCulture;

            RefreshFlights(); // Оновити таблицю
        }
        private void btnManifest_Click(object sender, EventArgs e)
        {
            if (dgvFlights.CurrentRow?.DataBoundItem is not Flight flight) return;

            var manifest = airportSystem.TicketOffice.GetPassengerManifest(flight);
            MessageBox.Show(manifest, $"Пасажирська відомість рейсу {flight.FlightNumber}", MessageBoxButtons.OK);
        }
    }
}



