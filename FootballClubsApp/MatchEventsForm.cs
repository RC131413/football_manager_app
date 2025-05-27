using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballClubsApp
{
    public partial class MatchEventsForm : Form
    {
        private Match _currentMatch;
        private List<Player> _allPlayers;
        private BindingList<MatchEvent> _events;

        public MatchEventsForm(Match match)
        {
            if (match == null)
                throw new ArgumentNullException(nameof(match), "Mecz nie może być null!");

            InitializeComponent();
            InitializeEventsGrid();
            _currentMatch = match;
            dgvEvents.CellContentClick += dgvEvents_CellContentClick;

            // Pobierz pełne dane klubów z bazy (z zawodnikami)
            _currentMatch.HomeClub = Database.GetClubWithPlayers(_currentMatch.HomeClub.Id);
            _currentMatch.AwayClub = Database.GetClubWithPlayers(_currentMatch.AwayClub.Id);
            _events = new BindingList<MatchEvent>(Database.GetMatchEvents(_currentMatch.Id));
            dgvEvents.DataSource = _events;

            LoadPlayers();
        }

        private void LoadPlayers()
        {
            // Inicjalizuj pustą listę
            var allPlayers = new List<Player>();

            // Sprawdź i dodaj zawodników tylko jeśli kluby i ich listy nie są null
            if (_currentMatch.HomeClub?.Players != null)
            {
                allPlayers.AddRange(_currentMatch.HomeClub.Players);
            }

            if (_currentMatch.AwayClub?.Players != null)
            {
                allPlayers.AddRange(_currentMatch.AwayClub.Players);
            }

            // Komunikat jeśli brak zawodników
            if (allPlayers.Count == 0)
            {
                MessageBox.Show("Brak zawodników w wybranym meczu!");
                return;
            }

            _allPlayers = allPlayers;
        }

        private void InitializeEventsGrid()
        {
            dgvEvents.AutoGenerateColumns = false;
            dgvEvents.Columns.Clear();

            dgvEvents.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Minute",
                HeaderText = "Minuta"
            });

            dgvEvents.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PlayerName",
                HeaderText = "Zawodnik"
            });

            dgvEvents.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "EventType",
                HeaderText = "Typ zdarzenia"
            });

            var btnDelete = new DataGridViewButtonColumn
            {
                Name = "btnDelete",
                HeaderText = "Akcja",
                Text = "Usuń",
                UseColumnTextForButtonValue = true
            };
            dgvEvents.Columns.Add(btnDelete);
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            var addEventForm = new AddMatchEventForm(_allPlayers);
            if (addEventForm.ShowDialog() == DialogResult.OK)
            {
                if (addEventForm.SelectedPlayer == null)
                {
                    MessageBox.Show("Nie wybrano zawodnika!");
                    return;
                }

                var newEvent = new MatchEvent
                {
                    Minute = addEventForm.Minute,
                    PlayerId = addEventForm.SelectedPlayer.Id,
                    PlayerName = addEventForm.SelectedPlayer.FullName,
                    EventType = addEventForm.EventType
                };

                Database.SaveMatchEvent(_currentMatch.Id, newEvent);

                _events.Add(newEvent);
                var sortedEvents = _events.OrderBy(ev => ev.Minute).ToList();
                _events = new BindingList<MatchEvent>(sortedEvents);
                dgvEvents.DataSource = _events;
            }
        }

        private void dgvEvents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvEvents.Columns[e.ColumnIndex].Name == "btnDelete")
            {
                var matchEvent = dgvEvents.Rows[e.RowIndex].DataBoundItem as MatchEvent;
                if (matchEvent == null) return;

                var result = MessageBox.Show(
                    $"Czy na pewno chcesz usunąć zdarzenie: {matchEvent.Minute}' {matchEvent.PlayerName} {matchEvent.EventType}?",
                    "Potwierdź usunięcie",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    Database.DeleteMatchEvent(matchEvent.Id); 
                                                              
                    var events = Database.GetMatchEvents(_currentMatch.Id);
                    dgvEvents.DataSource = new BindingList<MatchEvent>(events);
                }
            }
        }

    }

}
