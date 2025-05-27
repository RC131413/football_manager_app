using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballClubsApp
{
    public class Player
    {
        public int Id { get; set; }
        public string FirstName { get; set; } 
        public string LastName { get; set; }
        public string Position { get; set; }
        public int Number { get; set; }
        public int ClubId { get; set; }
        public Club Club { get; set; }
        public string ClubName => Club?.Name ?? "";
        public string FullName => $"{FirstName} {LastName}";
    }
}
