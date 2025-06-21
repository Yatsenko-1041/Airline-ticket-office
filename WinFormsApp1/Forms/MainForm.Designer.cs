namespace WinFormsApp1
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvFlights;
        private System.Windows.Forms.ComboBox cbDestination;
        private System.Windows.Forms.TextBox tbPassengerName;
        private System.Windows.Forms.NumericUpDown numTickets;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Button btnManifest;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepartureTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArrivalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;

        private void InitializeComponent()
        {
            this.dgvFlights = new System.Windows.Forms.DataGridView();
            this.cbDestination = new System.Windows.Forms.ComboBox();
            this.tbPassengerName = new System.Windows.Forms.TextBox();
            this.numTickets = new System.Windows.Forms.NumericUpDown();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.btnManifest = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.colDepartureTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArrivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();

            ((System.ComponentModel.ISupportInitialize)(this.dgvFlights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTickets)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();

            // dgvFlights
            this.dgvFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFlights.Location = new System.Drawing.Point(12, 12);
            this.dgvFlights.Name = "dgvFlights";
            this.dgvFlights.Size = new System.Drawing.Size(760, 200);
            this.dgvFlights.AutoGenerateColumns = false;
            this.dgvFlights.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colDepartureTime,
                this.colArrivalTime
            });

            // colDepartureTime
            this.colDepartureTime.DataPropertyName = "DepartureTime";
            this.colDepartureTime.HeaderText = "Departure Time";
            this.colDepartureTime.DefaultCellStyle.Format = "dd.MM.yyyy HH:mm";
            this.colDepartureTime.Name = "colDepartureTime";
            this.colDepartureTime.Width = 150;
            
            // colPrice — нова колонка
      
            this.colPrice.DataPropertyName = "Price";
            this.colPrice.HeaderText = "Price (€)";
            this.colPrice.DefaultCellStyle.Format = "C2"; // формат як валюта
            this.colPrice.Name = "colPrice";
            this.colPrice.Width = 100;


            // colArrivalTime
            this.colArrivalTime.DataPropertyName = "ArrivalTime";
            this.colArrivalTime.HeaderText = "Arrival Time";
            this.colArrivalTime.DefaultCellStyle.Format = "dd.MM.yyyy HH:mm";
            this.colArrivalTime.Name = "colArrivalTime";
            this.colArrivalTime.Width = 150;

            // cbDestination
            this.cbDestination.FormattingEnabled = true;
            this.cbDestination.Location = new System.Drawing.Point(12, 220);
            this.cbDestination.Name = "cbDestination";
            this.cbDestination.Size = new System.Drawing.Size(200, 23);
            // tbPassengerName
            this.tbPassengerName.Location = new System.Drawing.Point(12, 250);
            this.tbPassengerName.Name = "tbPassengerName";
            this.tbPassengerName.PlaceholderText = "Passenger Name";
            this.tbPassengerName.Size = new System.Drawing.Size(200, 23);

            // numTickets
            this.numTickets.Location = new System.Drawing.Point(12, 280);
            this.numTickets.Minimum = 1;
            this.numTickets.Name = "numTickets";
            this.numTickets.Size = new System.Drawing.Size(200, 23);
            this.numTickets.Value = 1;

            // btnSearch
            this.btnSearch.Location = new System.Drawing.Point(230, 220);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 23);
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            // btnBuy
            this.btnBuy.Location = new System.Drawing.Point(230, 250);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(100, 23);
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);

            // btnManifest
            this.btnManifest.Location = new System.Drawing.Point(230, 280);
            this.btnManifest.Name = "btnManifest";
            this.btnManifest.Size = new System.Drawing.Size(100, 23);
            this.btnManifest.Text = "Manifest";
            this.btnManifest.UseVisualStyleBackColor = true;
            this.btnManifest.Click += new System.EventHandler(this.btnManifest_Click);

            // statusStrip
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 320);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(784, 22);

            // toolStripStatusLabel1
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 341);
            this.Controls.Add(this.dgvFlights);
            this.Controls.Add(this.cbDestination);
            this.Controls.Add(this.tbPassengerName);
            this.Controls.Add(this.numTickets);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.btnManifest);
            this.Controls.Add(this.statusStrip);
            this.Name = "MainForm";
            this.Text = "Каса Аерофлоту";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTickets)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}



