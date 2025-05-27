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
    public partial class PlayersView : UserControl
    {
        public PlayersView()
        {
            InitializeComponent();
            InitializePlayersGrid();
            LoadPlayers();

            dgvPlayers.CellContentClick += dgvPlayers_CellContentClick;

        }

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

            dgvPlayers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ClubName",
                HeaderText = "Klub"
            });

            var btnDelete = new DataGridViewButtonColumn
            {
                Name = "btnDelete",
                HeaderText = "Akcja",
                Text = "Usuń",
                UseColumnTextForButtonValue = true
            };
            dgvPlayers.Columns.Add(btnDelete);
        }

        private void LoadPlayers()
        {
            var players = Database.GetPlayers();
            dgvPlayers.DataSource = players;
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            var clubs = Database.GetClubs();
            var addPlayerForm = new AddPlayerForm(clubs);

            if (addPlayerForm.ShowDialog() == DialogResult.OK)
            {
                LoadPlayers();
            }
        }
        private void dgvPlayers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Sprawdź, czy kliknięto przycisk "Usuń"
            if (dgvPlayers.Columns[e.ColumnIndex].Name == "btnDelete")
            {
                var player = dgvPlayers.Rows[e.RowIndex].DataBoundItem as Player;
                if (player == null) return;

                var result = MessageBox.Show(
                    $"Czy na pewno chcesz usunąć zawodnika: {player.FirstName} {player.LastName}?",
                    "Potwierdź usunięcie",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    Database.DeletePlayer(player.Id); // Usuwanie z bazy
                    LoadPlayers(); // Odśwież widok
                }
            }
        }

    }
}
