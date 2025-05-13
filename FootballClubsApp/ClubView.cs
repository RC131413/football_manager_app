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
        }

        private void btnAddClub_Click(object sender, EventArgs e)
        {
            AddClubForm addClubForm = new AddClubForm();
            if (addClubForm.ShowDialog() == DialogResult.OK)
            {
                // Tutaj bedzie pobieranie danych z addMatchForm i dodawanie meczu do bazy lub listy
            }
        }
    }
}
