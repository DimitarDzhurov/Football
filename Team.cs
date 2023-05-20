using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Football
{
    public class Team
    {
        public Coach Coach { get; set; }
        public List<FootballPlayer> Players { get; set; } = new List<FootballPlayer>();
        public Team(Coach coach, FootballPlayer[] players)
        {
            this.Coach = coach;
            if(Players.Count>=11 || Players.Count<=22)
            {
                Console.Write("");
            }
            else
                Console.WriteLine("Invalid team");
        }
        public double AverageAge
        {
            get { return AverageAge; }
            set => AverageAge = Players.Sum(x => x.Age) / Players.Count; 
        }
    }
}
