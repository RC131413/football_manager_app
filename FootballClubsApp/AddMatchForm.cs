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
    public partial class AddMatchForm : Form
    {
        private Club _selectedHome;
        private Club _selectedAway;
        private bool isSelectingHome = true;
        private Competition _selectedCompetition;
        private Match _editingMatch = null;

        public AddMatchForm()
        {
            InitializeComponent();
            LoadClubs();
            LoadCompetitions();
        }
        public AddMatchForm(Match matchToEdit) : this() // wywołuje konstruktor domyślny, który ładuje kluby i rozgrywki
        {
            _editingMatch = matchToEdit;

            // Uzupełnij pola formularza danymi meczu
            dtpDate.Value = matchToEdit.Date;
            _selectedHome = matchToEdit.HomeClub;
            _selectedAway = matchToEdit.AwayClub;
            _selectedCompetition = matchToEdit.Competition;

            lblSelectedHome.Text = $"Gospodarz: {_selectedHome.Name}";
            lblSelectedAway.Text = $"Gość: {_selectedAway.Name}";
            lblSelectedCompetition.Text = $"Wybrana rozgrywka: {_selectedCompetition.Name} ({_selectedCompetition.Season})";

            txtScore.Text = $"{matchToEdit.HomeScore}:{matchToEdit.AwayScore}";
            isSelectingHome = false; // domyślnie po edycji nie wybierasz gospodarza
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (_selectedHome == null || _selectedAway == null)
            {
                MessageBox.Show("Wybierz oba kluby!");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtScore.Text) || !txtScore.Text.Contains(":"))
            {
                MessageBox.Show("Podaj wynik w formacie np. 2:1");
                return;
            }
            if (_selectedCompetition == null)
            {
                MessageBox.Show("Wybierz rozgrywki z tabeli!");
                return;
            }

            // Pobranie wyniku z TextBoxa
            var scoreParts = txtScore.Text.Split(':');
            if (scoreParts.Length != 2 ||
                !int.TryParse(scoreParts[0], out int homeScore) ||
                !int.TryParse(scoreParts[1], out int awayScore))
            {
                MessageBox.Show("Wynik musi być w formacie liczba:liczba, np. 2:1");
                return;
            }

            if (_editingMatch == null)
            {
                // Dodawanie nowego meczu
                var newMatch = new Match
                {
                    Date = dtpDate.Value,
                    HomeClub = _selectedHome,
                    AwayClub = _selectedAway,
                    HomeScore = homeScore,
                    AwayScore = awayScore,
                    Competition = _selectedCompetition
                };
                Database.SaveMatch(newMatch);
            }
            else
            {
                // Edycja istniejącego meczu
                _editingMatch.Date = dtpDate.Value;
                _editingMatch.HomeClub = _selectedHome;
                _editingMatch.AwayClub = _selectedAway;
                _editingMatch.HomeScore = homeScore;
                _editingMatch.AwayScore = awayScore;
                _editingMatch.Competition = _selectedCompetition;

                Database.UpdateMatch(_editingMatch);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void LoadClubs()
        {
            // Przykład: pobierz kluby z bazy lub listy
            var clubs = Database.GetClubs(); // Zwraca List<Club>
            dgvClubs.DataSource = clubs;
            dgvClubs.Columns["Id"].Visible = false; // Ukryj kolumnę ID jeśli jest
            dgvClubs.Columns["Name"].HeaderText = "Nazwa klubu";
            // Dodaj inne kolumny według potrzeb
        }

        private void LoadCompetitions()
        {
            var competitions = Database.GetCompetitions();
            dgvCompetitions.DataSource = competitions;
            dgvCompetitions.Columns["Id"].Visible = false;
            dgvCompetitions.Columns["Name"].HeaderText = "Nazwa rozgrywki";
            dgvCompetitions.Columns["Season"].HeaderText = "Sezon";
        }

        private void dgvClubs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // ignoruj kliknięcie nagłówka

            var selectedClub = dgvClubs.Rows[e.RowIndex].DataBoundItem as Club;
            if (selectedClub == null) return;


            if (isSelectingHome)
            {
                _selectedHome = selectedClub;
                lblSelectedHome.Text = $"Gospodarz: {_selectedHome.Name}";
            }
            else
            {
                if (_selectedHome != null && selectedClub.Id == _selectedHome.Id)
                {
                    MessageBox.Show("Gość nie może być tym samym klubem co gospodarz!");
                    return;
                }
                _selectedAway = selectedClub;
                lblSelectedAway.Text = $"Gość: {_selectedAway.Name}";
            }
        }

        private void btnConfirmHome_Click(object sender, EventArgs e)
        {
            if (_selectedHome == null)
            {
                MessageBox.Show("Wybierz gospodarza z tabeli!");
                return;
            }
            isSelectingHome = false; // Teraz wybierasz gościa
            MessageBox.Show("Teraz wybierz gościa z tabeli.");
        }

        private void dgvCompetitions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            _selectedCompetition = dgvCompetitions.Rows[e.RowIndex].DataBoundItem as Competition;
            if (_selectedCompetition != null)
                lblSelectedCompetition.Text = $"Wybrana rozgrywka: {_selectedCompetition.Name} ({_selectedCompetition.Season})";
        }
    }
}
