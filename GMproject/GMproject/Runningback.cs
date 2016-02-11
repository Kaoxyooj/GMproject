using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMproject
{
    public class Runningback : Player
    {
        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }
        public int Weight { get { return weight; } set { weight = value; } }
        public string Position { get { return position; } set { position = value; } }
        public double OverallRating { get { return overallRating; } set { overallRating = value; } }
        public int rushAttmpts { get; set; }
        public double rushYards { get; set; }
        public int touchdowns { get; set; }

        public override void action()
        {
            Console.WriteLine("Runs!");
        }
    }
}
