using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballClubsApp
{
    public class Match
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Club HomeClub { get; set; }
        public Club AwayClub { get; set; }
        public int HomeScore { get; set; }
        public int AwayScore { get; set; }
        public Competition Competition { get; set; }

        // Właściwości pomocnicze do wyświetlania w DataGridView
        public string DataMeczu => Date.ToShortDateString();
        public string Gospodarz => HomeClub?.Name ?? "";
        public string Gosc => AwayClub?.Name ?? "";
        public string Wynik => $"{HomeScore}:{AwayScore}";
        public string NazwaRozgrywki => Competition?.Name ?? "";
        public string Sezon => Competition?.Season ?? "";
    }
}
