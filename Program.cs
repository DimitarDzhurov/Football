using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Football
{
    class Program
    {
        static void Main(string[] args)
        {
            FootballPlayer player1 = new Goalkeeper("Valdes", 1, 25, 185);
            FootballPlayer player2 = new Defender("Puyol", 5, 30, 180);
            FootballPlayer player3 = new Defender("Pique", 3, 28, 190);
            FootballPlayer player4 = new Defender("Abidal", 22, 32, 180);
            FootballPlayer player5 = new Defender("Alves", 2, 28, 173);
            FootballPlayer player6 = new Midfielder("Busquets", 16, 24, 180);
            FootballPlayer player7 = new Midfielder("Xavi", 6, 30, 170);
            FootballPlayer player8 = new Midfielder("Iniesta", 8, 28, 177);
            FootballPlayer player9 = new Striker("Villa", 7, 30, 180);
            FootballPlayer player10 = new Striker("Messi", 10, 24, 170);
            FootballPlayer player11 = new Striker("Pedro", 17, 27, 170);
            Coach coach1 = new Coach("Tito Vilanova", 45);
            Team team1 = new Team(coach1, new FootballPlayer[] { player1, player2, player3, player4,player5,player6,player7,player8,player9,player10,player11 });
            FootballPlayer player12 = new Goalkeeper("Casillas", 1, 30, 190);
            FootballPlayer player13 = new Defender("Pepe", 3, 29, 190);
            FootballPlayer player14 = new Defender("Ramos", 4, 26, 187);
            FootballPlayer player15 = new Defender("Marcelo", 12, 27, 175);
            FootballPlayer player16 = new Defender("Carvalho", 2, 35, 170);
            FootballPlayer player17 = new Midfielder("Xabi Alonso", 14, 25, 185);
            FootballPlayer player18 = new Midfielder("Khedira", 6, 24, 183);
            FootballPlayer player19 = new Midfielder("Ozil", 10, 22, 185);
            FootballPlayer player20 = new Striker("Di Maria", 22, 23, 180);
            FootballPlayer player21 = new Striker("Higuain", 20, 23, 184);
            FootballPlayer player22 = new Striker("Ronaldo", 7, 26, 187);
            Coach coach2 = new Coach("Carlo Ancelotti", 44);
            Team team2 = new Team(coach2, new FootballPlayer[] { player12, player13, player14, player15, player16, player17, player18, player19, player20, player21, player22 });
            Referee referee = new Referee("Mark", 40);
            Referee assistantReferee1 = new Referee("Tom", 35);
            Referee assistantReferee2 = new Referee("Ben", 37);
            Referee[] assistantReferees = new Referee[] { assistantReferee1, assistantReferee2 };
            Game game1 = new Game(team1, team2, referee, assistantReferees);
            game1.AddGoal(15, player10);
            game1.SetResult("1-0", team1);
            Console.WriteLine("Result: " + game1.GameResult);
            Console.WriteLine("Winner: " + game1.Winner.Coach.Name);
        }
    }
}
