using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballClubsApp
{
    public class Club
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Stadium { get; set; }
        public string FoundedDate { get; set; }
        public List<Player> Players { get; set; } = new List<Player>();

    }
}
