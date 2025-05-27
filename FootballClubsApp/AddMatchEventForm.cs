using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballClubsApp
{
    public partial class AddMatchEventForm : Form
    {
        private Player _selectedPlayer;
        public int Minute { get; private set; }
        public Player SelectedPlayer => _selectedPlayer;
        public string EventType { get; private set; }
        private List<Player> _players;

        public AddMatchEventForm(List<Player> players)
        {
            InitializeComponent();
            _players = players;
            InitializePlayersGrid();
            LoadPlayers();
            LoadEventTypes();
            lblSelectedPlayer.Text = "Wybrany zawodnik: brak";
        }

        // Inicjalizacja kolumn DataGridView
        private void InitializePlayersGrid()
        {
            dgvPlayers.AutoGenerateColumns = false;
            dgvPlayers.Columns.Clear();

            dgvPlayers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FirstName",
                HeaderText = "Imię"
            });
            dgvPlayers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "LastName",
                HeaderText = "Nazwisko"
            });
            dgvPlayers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Position",
                HeaderText = "Pozycja"
            });
            dgvPlayers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Number",
                HeaderText = "Numer"
            });
        }

        // Załaduj zawodników do DataGridView
        private void LoadPlayers()
        {
            dgvPlayers.DataSource = null;
            dgvPlayers.DataSource = _players;
        }

        // Załaduj typy zdarzeń do ComboBoxa
        private void LoadEventTypes()
        {
            cbEventType.Items.Clear();
            cbEventType.Items.AddRange(new string[] { "Gol", "Faul", "Żółta kartka", "Czerwona kartka", "Zchodzi", "Wchodzi" });
        }

        // Obsługa kliknięcia w tabeli zawodników
        private void dgvPlayers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            _selectedPlayer = dgvPlayers.Rows[e.RowIndex].DataBoundItem as Player;
            lblSelectedPlayer.Text = _selectedPlayer != null
                ? $"Wybrany zawodnik: {_selectedPlayer.FirstName} {_selectedPlayer.LastName}"
                : "Wybrany zawodnik: brak";
        }

        // Obsługa przycisku OK
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;

            Minute = (int)numMinute.Value;
            EventType = cbEventType.SelectedItem?.ToString();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Walidacja formularza
        private bool ValidateForm()
        {
            if (_selectedPlayer == null)
            {
                MessageBox.Show("Najpierw wybierz zawodnika z tabeli!");
                return false;
            }

            if (cbEventType.SelectedItem == null)
            {
                MessageBox.Show("Wybierz typ zdarzenia!");
                return false;
            }

            if (numMinute.Value < 0 || numMinute.Value > 120)
            {
                MessageBox.Show("Minuta musi być między 0 a 120!");
                return false;
            }
            return true;
        }
    }
}
