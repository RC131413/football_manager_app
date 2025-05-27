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
    public partial class HomeView: UserControl
    {
        public HomeView()
        {
            InitializeComponent();
            LoadStats();
        }
        private void LoadStats()
        {
            lblMatchesCount.Text = Database.GetMatchesCount().ToString();
            lblClubsCount.Text = Database.GetClubsCount().ToString();
            lblCompetitionsCount.Text = Database.GetCompetitionsCount().ToString();
        }
    }
}
