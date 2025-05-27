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
    public partial class CompetitionsView: UserControl
    {
        public CompetitionsView()
        {
            InitializeComponent();
            InitializeCompetitionsGrid();
            LoadCompetitions();

            dgvCompetitions.CellContentClick += dgvCompetitions_CellContentClick;
        }

        private void InitializeCompetitionsGrid()
        {
            dgvCompetitions.AutoGenerateColumns = false;
            dgvCompetitions.Columns.Clear();

            dgvCompetitions.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Name",
                HeaderText = "Nazwa rozgrywek"
            });
            dgvCompetitions.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Season",
                HeaderText = "Sezon"
            });

            var btnDelete = new DataGridViewButtonColumn
            {
                Name = "btnDelete",
                HeaderText = "Akcja",
                Text = "Usuń",
                UseColumnTextForButtonValue = true
            };
            dgvCompetitions.Columns.Add(btnDelete);
        }

        private void LoadCompetitions()
        {
            var competitions = Database.GetCompetitions();
            dgvCompetitions.DataSource = competitions;
        }

        private void btnAddCompetition_Click(object sender, EventArgs e)
        {
            var addCompetitionForm = new AddCompetitionForm();
            if (addCompetitionForm.ShowDialog() == DialogResult.OK)
            {
                if (addCompetitionForm.NewCompetition != null) 
                {
                    Database.SaveCompetition(addCompetitionForm.NewCompetition);
                    LoadCompetitions();
                }
                else
                {
                    MessageBox.Show("Nie utworzono rozgrywki!");
                }
            }
        }
        private void dgvCompetitions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Sprawdź, czy kliknięto przycisk "Usuń"
            if (dgvCompetitions.Columns[e.ColumnIndex].Name == "btnDelete")
            {
                var competition = dgvCompetitions.Rows[e.RowIndex].DataBoundItem as Competition;
                if (competition == null) return;

                var result = MessageBox.Show(
                    $"Czy na pewno chcesz usunąć rozgrywkę: {competition.Name} ({competition.Season})?",
                    "Potwierdź usunięcie",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    Database.DeleteCompetition(competition.Id); // Usuwanie z bazy
                    LoadCompetitions(); // Odśwież widok
                }
            }
        }


    }
}
