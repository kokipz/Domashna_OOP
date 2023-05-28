using System;
using System.Collections.Generic;
using System.Text;

namespace domashna_OOP
{
    class Team
    {
        public Coach Coach { get; set; }
        public List<FootballPlayer> Players { get; set; }

        public double AverageAge()
        {
            int totalAge = 0;
            foreach (FootballPlayer player in Players)
            {
                totalAge += player.Age;
            }
            return (double)totalAge / Players.Count;
        }
    }
}
