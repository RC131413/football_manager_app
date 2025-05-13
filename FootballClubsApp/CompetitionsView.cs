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
        }

        private void btnAddCompetition_Click(object sender, EventArgs e)
        {
            AddCompetitionForm addCompetitionForm = new AddCompetitionForm();
            if (addCompetitionForm.ShowDialog() == DialogResult.OK)
            {
                // Tutaj bedzie pobieranie danych z addMatchForm i dodawanie meczu do bazy lub listy
            }
        }

    }
}
