using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballClubsApp
{
    public partial class MatchesView: UserControl
    {
        public MatchesView()
        {
            InitializeComponent();
            InitializeMatchesGrid();
            LoadMatches();

            dgvMatches.CellContentClick += dgvMatches_CellContentClick;
        }

        private void InitializeMatchesGrid()
        {
            dgvMatches.AutoGenerateColumns = false;
            dgvMatches.Columns.Clear();

            dgvMatches.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DataMeczu",
                HeaderText = "Data meczu"
            });

            dgvMatches.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Gospodarz",
                HeaderText = "Gospodarz"
            });

            dgvMatches.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Gosc",
                HeaderText = "Gość"
            });

            dgvMatches.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Wynik",
                HeaderText = "Wynik"
            });

            dgvMatches.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NazwaRozgrywki",
                HeaderText = "Rozgrywki"
            });

            dgvMatches.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Sezon",
                HeaderText = "Sezon"
            });

            var btnDelete = new DataGridViewButtonColumn
            {
                Name = "btnDelete",
                HeaderText = "Akcja",
                Text = "Usuń",
                UseColumnTextForButtonValue = true
            };
            dgvMatches.Columns.Add(btnDelete);
        }

        private void LoadMatches()
        {
            // Pobierz dane z bazy
            var matches = Database.GetMatches();
            dgvMatches.DataSource = null;
            dgvMatches.DataSource = matches;
        }

        private void btnAddMatch_Click(object sender, EventArgs e)
        {
            AddMatchForm addMatchForm = new AddMatchForm();
            if (addMatchForm.ShowDialog() == DialogResult.OK)
            {
                // Po dodaniu meczu odśwież widok
                LoadMatches();
            }
        }

        private void dgvMatches_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Sprawdź, czy kliknięto przycisk "Usuń"
            if (dgvMatches.Columns[e.ColumnIndex].Name == "btnDelete")
            {
                var match = dgvMatches.Rows[e.RowIndex].DataBoundItem as Match;
                if (match == null) return;

                DialogResult result = MessageBox.Show(
                    $"Czy na pewno chcesz usunąć mecz {match.Gospodarz} vs {match.Gosc}?",
                    "Potwierdź usunięcie",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        Database.DeleteMatch(match.Id);
                        LoadMatches(); // Odśwież widok
                        MessageBox.Show("Mecz usunięty!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Błąd: {ex.Message}");
                    }
                }
            }
        }

        private void dgvMatches_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var selectedMatch = dgvMatches.Rows[e.RowIndex].DataBoundItem as Match;
            if (selectedMatch == null)
            {
                MessageBox.Show("Wybrany mecz jest nieprawidłowy!");
                return;
            }

            var eventsForm = new MatchEventsForm(selectedMatch);
            eventsForm.ShowDialog();
        }
    }
}

