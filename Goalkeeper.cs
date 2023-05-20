using System;
using System.Collections.Generic;
using System.Text;

namespace Football
{
    public class Goalkeeper : FootballPlayer
    {
        public Goalkeeper(string name, int number, int age, int height)
        {
            this.Name = name;
            this.Number = number;
            this.Age = age;
            this.Height = height;
        }
    }
}
