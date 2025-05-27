using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FootballClubsApp
{
    public partial class AddClubForm : Form
    {
        public Club NewClub { get; private set; }

        public AddClubForm()
        {
            InitializeComponent();
            dtpFoundedDate.Value = DateTime.Now;

            btnOK.Click += btnOK_Click;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string city = txtCity.Text.Trim();
            string stadium = txtStadium.Text.Trim();

            // Walidacja nazwy klubu
            if (string.IsNullOrWhiteSpace(name) || name.Length < 3 ||
                !System.Text.RegularExpressions.Regex.IsMatch(name, @"^[A-ZĄĆĘŁŃÓŚŹŻ][a-ząćęłńóśźżA-ZĄĆĘŁŃÓŚŹŻ0-9 \-]{1,}$"))
            {
                MessageBox.Show("Nazwa klubu musi zaczynać się wielką literą i mieć co najmniej 3 znaki (tylko litery, cyfry, spacje, myślniki).");
                return;
            }

            // Walidacja miasta
            if (string.IsNullOrWhiteSpace(city) || city.Length < 2 ||
                !System.Text.RegularExpressions.Regex.IsMatch(city, @"^[A-ZĄĆĘŁŃÓŚŹŻ][a-ząćęłńóśźżA-ZĄĆĘŁŃÓŚŹŻ \-]*$"))
            {
                MessageBox.Show("Miasto musi zaczynać się wielką literą i mieć co najmniej 2 znaki (tylko litery, spacje, myślniki).");
                return;
            }

            // Walidacja stadionu – tylko jeśli nie jest puste
            if (!string.IsNullOrWhiteSpace(stadium) &&
                (stadium.Length < 2 || !System.Text.RegularExpressions.Regex.IsMatch(stadium, @"^[A-Za-zĄĆĘŁŃÓŚŹŻąćęłńóśźż0-9 \-]+$")))
            {
                MessageBox.Show("Nazwa stadionu musi mieć co najmniej 2 znaki (litery, cyfry, spacje, myślniki) lub pozostać pusta.");
                return;
            }

            NewClub = new Club
            {
                Name = txtName.Text.Trim(),
                City = txtCity.Text.Trim(),
                Stadium = txtStadium.Text.Trim(),
                FoundedDate = dtpFoundedDate.Value.ToString("yyyy-MM-dd")
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }



    }

}
