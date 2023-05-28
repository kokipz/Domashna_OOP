using System;

namespace domashna_OOP
{
    class Program
    {
        Goalkeeper player1 = new Goalkeeper { Name = "John Doe", Number = 1, Age = 25, Height = 185 };
        Defender player2 = new Defender { Name = "Alice Smith", Number = 4, Age = 28, Height = 170 };
        Midfielder player3 = new Midfielder { Name = "Bob Johnson", Number = 8, Age = 23, Height = 175 };
        Striker player4 = new Striker { Name = "Eve Brown", Number = 10, Age = 27, Height = 180 };

        Coach coach = new Coach { Name = "Michael Anderson", Age = 45 };


     }      
}

