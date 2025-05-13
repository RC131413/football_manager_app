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

            // Przykładowe kolumny 
            dgvMatches.Columns.Add("Data", "Data meczu");
            dgvMatches.Columns.Add("Gospodarz", "Gospodarz");
            dgvMatches.Columns.Add("Gosc", "Gość");
            dgvMatches.Columns.Add("Wynik", "Wynik");
            dgvMatches.Columns.Add("Rozgrywki", "Rozgrywki");

            // Przykładowy wiersz
            dgvMatches.Rows.Add("2024-05-10", "FC Przykład", "KS Test", "2:1", "Ekstraklasa");
        }

        private void btnAddMatch_Click(object sender, EventArgs e)
        {
            AddMatchForm addMatchForm = new AddMatchForm();
            if (addMatchForm.ShowDialog() == DialogResult.OK)
            {
                // Tutaj bedzie pobieranie danych z addMatchForm i dodawanie meczu do bazy lub listy
    
            }
        }
    }
}
