using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMproject
{
    class Program
    {
        static void Main(string[] args)
        {
            Packers pack = new Packers();
            pack.roster();
            pack.rost.avgAge(pack.AvgAge());
            pack.rost.avgWeight(pack.allWeight());
            pack.rost.avgRating(pack.allRating());

            Console.ReadLine();
        }
    }
}
