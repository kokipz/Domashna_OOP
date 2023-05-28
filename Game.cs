using System;
using System.Collections.Generic;
using System.Text;

namespace domashna_OOP
{
    class Game
    {
        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
        public Referee Referee { get; set; }
        public string[] AssistantReferees { get; set; }
        public Goal[] Goals { get; set; }
        public string Result { get; set; }
        public Team Winner { get; set; }

        public Game(Team team1, Team team2, Referee referee, string[] assistantReferees)
        {
            Team1 = team1;
            Team2 = team2;
            Referee = referee;
            AssistantReferees = assistantReferees;
            Goals = new Goal[0];
            Result = "";
            Winner = null;
        }

        public void AddGoal(string minute, FootballPlayer scorer)
        {
            Goal goal = new Goal(minute, scorer);
            Array.Resize( ref Goals, newSize: Goals.Length + 1);
            Goals[Goals.Length - 1] = goal;
        }

        public void SetResult(string result, Team winner)
        {
            Result = result;
            Winner = winner;
        }
    }

}
