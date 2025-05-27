using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballClubsApp
{
    public class MatchEvent
    {
        public int Id { get; set; }
        public int Minute { get; set; }
        public int PlayerId { get; set; }
        public string PlayerName { get; set; } 
        public string EventType { get; set; }
    }
}
