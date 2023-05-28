using System;

namespace domashna_OOP
{
    class Program
    {
        static void Main()
        {
        
            Goalkeeper goalkeeper1 = new Goalkeeper("John Doe", 25, 1, 180);
            Defender defender1 = new Defender("Jane Smith", 28, 2, 170);
            Midfield midfield1 = new Midfield("David Johnson", 24, 3, 175);
            Striker striker1 = new Striker("Michael Brown", 26, 4, 185);

            FootballPlayer[] players1 = { goalkeeper1, defender1, midfield1, striker1 };

            
            Coach coach1 = new Coach("Alex Ferguson", 50);
            Team team1 = new Team(coach1, players1);

            
            Referee referee1 = new Referee("Mark Davis", 35);

            
            Game game1 = new Game(team1, null, referee1, new string[2] { "Assistant Referee 1", "Assistant Referee 2" });
            
            game1.AddGoal("15", striker1);
            game1.AddGoal("30", midfield1);

            game1.SetResult("2-0", team1);

            Console.WriteLine("Result: " + game1.Result);
            Console.WriteLine("Winner: " + game1.Winner.Coach.Name);

            Console.WriteLine("Average Player Age: " + team1.GetAveragePlayerAge());
        }

    }      
}

