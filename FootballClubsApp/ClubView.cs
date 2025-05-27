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
    public partial class ClubView: UserControl
    {
        public ClubView()
        {
            InitializeComponent();
            InitializeClubsGrid();
            LoadClubs();

            dgvClubs.CellContentClick += dgvClubs_CellContentClick;
        }

        private void btnAddClub_Click(object sender, EventArgs e)
        {
            var addClubForm = new AddClubForm();
            if (addClubForm.ShowDialog() == DialogResult.OK && addClubForm.NewClub != null)
            {
                Database.SaveClub(addClubForm.NewClub);
                LoadClubs();
            }
            
        }

        private void LoadClubs()
        {
            var clubs = Database.GetClubs();
            dgvClubs.DataSource = clubs;
        }

        private void InitializeClubsGrid()
        {
            dgvClubs.AutoGenerateColumns = false;
            dgvClubs.Columns.Clear();

            dgvClubs.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Name",
                HeaderText = "Nazwa klubu"
            });
            dgvClubs.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "City",
                HeaderText = "Miasto"
            });
            dgvClubs.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Stadium",
                HeaderText = "Stadion"
            });
            dgvClubs.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FoundedDate",
                HeaderText = "Data założenia"
            });

            var btnDelete = new DataGridViewButtonColumn
            {
                Name = "btnDelete",
                HeaderText = "Akcja",
                Text = "Usuń",
                UseColumnTextForButtonValue = true
            };
            dgvClubs.Columns.Add(btnDelete);
        }
        private void dgvClubs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvClubs.Columns[e.ColumnIndex].Name == "btnDelete")
            {
                var club = dgvClubs.Rows[e.RowIndex].DataBoundItem as Club;
                if (club == null) return;

                var result = MessageBox.Show(
                    $"Czy na pewno chcesz usunąć klub: {club.Name}?",
                    "Potwierdź usunięcie",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    Database.DeleteClub(club.Id); // Usuń z bazy
                    LoadClubs(); // Odśwież widok
                }
            }
        }
    }
}
