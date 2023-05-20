using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Football
{
    public class Game
    {
        public Team TeamOne { get; set; }
        public Team TeamTwo { get; set; }
        public Referee Referee { get; set; }
        public Referee[] TwoAssistantReferees { get; set; }
        public Goal[] Goals { get; set; }
        public string GameResult { get; set; }
        public Team Winner { get; set; }
        public Game(Team teamOne, Team teamTwo, Referee referee, Referee[] referees)
        {
            this.TeamOne = teamOne;
            this.TeamTwo = teamTwo;
            this.Referee = referee;
            this.TwoAssistantReferees = referees;
        }
        public void AddGoal(int minute, FootballPlayer player)
        {
            Goal goal = new Goal(minute, player);
            if (Goals == null)
            {
                Goals = new Goal[] { goal };
            }
            else
            {
                return;
            }
        }
        public void SetResult(string result, Team winner)
        {
            this.GameResult = result;
            this.Winner = winner;
        }
    }
}
