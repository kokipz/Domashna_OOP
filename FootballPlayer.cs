using System;
using System.Collections.Generic;
using System.Text;

namespace domashna_OOP
{
    class FootballPlayer
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Number { get; set; }
        public double Height { get; set; }

        public FootballPlayer(string name, int age, int number, double height)
            : base(name, age, number, height)
        {
            Number = number;
            Height = height;
        }

    }
}
