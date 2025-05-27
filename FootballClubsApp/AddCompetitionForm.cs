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
    public partial class AddCompetitionForm : Form
    {
        public Competition NewCompetition { get; private set; }

        public AddCompetitionForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string name = txtCompetitionName.Text.Trim();
            string season = txtSeason.Text.Trim();

            // Walidacja nazwy
            if (string.IsNullOrWhiteSpace(name) || name.Length < 3)
            {
                MessageBox.Show("Nazwa rozgrywek musi mieć co najmniej 3 znaki.");
                return; // Formularz NIE zostanie zamknięty!
            }

            // Walidacja sezonu
            bool validSeason = false;
            if (Regex.IsMatch(season, @"^\d{4}$")) // Format "RRRR"
            {
                validSeason = true;
            }
            else if (Regex.IsMatch(season, @"^\d{4}/\d{4}$")) // Format "RRRR/RRRR"
            {
                string[] years = season.Split('/');
                if (years.Length == 2 && int.TryParse(years[0], out int y1) && int.TryParse(years[1], out int y2))
                {
                    if (y2 == y1 + 1)
                        validSeason = true;
                    else
                    {
                        MessageBox.Show("Drugi rok w sezonie musi być o 1 większy od pierwszego (np. 2024/2025).");
                        return; // Formularz NIE zostanie zamknięty!
                    }
                }
            }

            if (!validSeason)
            {
                MessageBox.Show("Sezon musi być w formacie RRRR lub RRRR/RRRR (np. 2024 lub 2024/2025).");
                return; // Formularz NIE zostanie zamknięty!
            }

            // Jeśli walidacja przebiegła pomyślnie:
            NewCompetition = new Competition { Name = name, Season = season };
            this.DialogResult = DialogResult.OK; // Zamknij formularz z wynikiem OK
            this.Close();
        }



    }

}
