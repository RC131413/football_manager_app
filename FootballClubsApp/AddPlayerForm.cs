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
    public partial class AddPlayerForm : Form
    {
        private Club _selectedClub;
        public Player NewPlayer { get; private set; }

        // Konstruktor domyślny (jeśli chcesz wywoływać bez parametrów)
        public AddPlayerForm()
        {
            InitializeComponent();
            var clubs = Database.GetClubs();
            LoadClubs(clubs);
            dgvClubs.CellClick += dgvClubs_CellClick;
        }

        // Konstruktor z listą klubów
        public AddPlayerForm(List<Club> clubs)
        {
            InitializeComponent();
            LoadClubs(clubs);
            dgvClubs.CellClick += dgvClubs_CellClick;
        }

        // Ładowanie klubów do DataGridView
        private void LoadClubs(List<Club> clubs)
        {
            dgvClubs.DataSource = clubs;
            if (dgvClubs.Columns["Id"] != null)
                dgvClubs.Columns["Id"].Visible = false;
            if (dgvClubs.Columns["Players"] != null)
                dgvClubs.Columns["Players"].Visible = false;
            if (dgvClubs.Columns["Name"] != null)
                dgvClubs.Columns["Name"].HeaderText = "Nazwa klubu";
            if (dgvClubs.Columns["City"] != null)
                dgvClubs.Columns["City"].HeaderText = "Miasto";
            if (dgvClubs.Columns["Stadium"] != null)
                dgvClubs.Columns["Stadium"].HeaderText = "Stadion";
            if (dgvClubs.Columns["FoundedDate"] != null)
                dgvClubs.Columns["FoundedDate"].HeaderText = "Data założenia";
        }

        // Obsługa kliknięcia w wiersz tabeli klubów
        private void dgvClubs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            _selectedClub = dgvClubs.Rows[e.RowIndex].DataBoundItem as Club;
            lblSelectedClub.Text = _selectedClub != null
                ? $"Wybrany klub: {_selectedClub.Name}"
                : "Nie wybrano klubu!";
        }

        // Obsługa przycisku OK (zapis zawodnika)
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                // Walidacja klubu
                if (_selectedClub == null)
                {
                    MessageBox.Show("Wybierz klub z tabeli!");
                    return;
                }

                // Walidacja imienia
                string firstName = txtFirstName.Text.Trim();
                if (string.IsNullOrWhiteSpace(firstName) || firstName.Length < 2 || !firstName.All(char.IsLetter))
                {
                    MessageBox.Show("Imię musi mieć co najmniej 2 litery i zawierać tylko litery.");
                    return;
                }

                // Walidacja nazwiska
                string lastName = txtLastName.Text.Trim();
                if (string.IsNullOrWhiteSpace(lastName) || lastName.Length < 2 || !lastName.All(char.IsLetter))
                {
                    MessageBox.Show("Nazwisko musi mieć co najmniej 2 litery i zawierać tylko litery.");
                    return;
                }

                // Walidacja pozycji
                string position = txtPosition.Text.Trim();
                if (string.IsNullOrWhiteSpace(position) || position.Length < 2 || !position.All(c => char.IsLetter(c) || c == ' '))
                {
                    MessageBox.Show("Pozycja musi mieć co najmniej 2 znaki i zawierać tylko litery lub spacje.");
                    return;
                }

                // Walidacja numeru
                if (!int.TryParse(txtNumber.Text, out int number))
                {
                    MessageBox.Show("Numer musi być liczbą całkowitą!");
                    return;
                }
                if (number < 1 || number > 99)
                {
                    MessageBox.Show("Numer musi być w zakresie od 1 do 99!");
                    return;
                }

                // Utwórz nowego zawodnika
                NewPlayer = new Player
                {
                    FirstName = txtFirstName.Text.Trim(),
                    LastName = txtLastName.Text.Trim(),
                    Position = txtPosition.Text.Trim(),
                    Number = int.TryParse(txtNumber.Text, out number) ? number : 0,
                    ClubId = _selectedClub.Id // Klucz obcy do bazy
                };

                // Zapisz do bazy
                Database.SavePlayer(NewPlayer);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd zapisu zawodnika: {ex.Message}");
            }
        }
    }
}
