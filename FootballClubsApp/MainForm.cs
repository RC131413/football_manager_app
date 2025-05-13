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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ShowHomeView();

        }

        private void ShowHomeView()
        {
            panelContent.Controls.Clear();
            HomeView homeView = new HomeView();
            homeView.Dock = DockStyle.Fill;
            panelContent.Controls.Add(homeView);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            ClubView clubsView = new ClubView();
            clubsView.Dock = DockStyle.Fill;
            panelContent.Controls.Add(clubsView);
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnMatches_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            MatchesView matchesView = new MatchesView();
            matchesView.Dock = DockStyle.Fill;
            panelContent.Controls.Add(matchesView);
        }

        private void btnCompetitions_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            CompetitionsView competitionsView = new CompetitionsView();
            competitionsView.Dock = DockStyle.Fill;
            panelContent.Controls.Add(competitionsView);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ShowHomeView();
        }
    }
}
