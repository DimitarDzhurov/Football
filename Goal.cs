using System;
using System.Collections.Generic;
using System.Text;

namespace Football
{
    public class Goal
    {
        public double Minute { get; set; }
        public FootballPlayer Player { get; set; }
        public Goal(double minute, FootballPlayer player)
        {
            this.Minute = minute;
            this.Player = player;
            Console.WriteLine(minute);
            Console.WriteLine(player.Name);
        }
    }
}
