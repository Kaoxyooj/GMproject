using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMproject
{
    public class Roster
    {
        public List<Player> players;

        public double avgRating(double allRatingAdded)
        {
            int numOfPlayers = players.Count();
            Console.WriteLine("Average Rating : "+allRatingAdded / numOfPlayers);
            return allRatingAdded / numOfPlayers;
        }
        public int avgAge(int allAgeAdded)
        {
            int numOfPlayers = players.Count();
            Console.WriteLine("Average Age: "+allAgeAdded / numOfPlayers);
            return allAgeAdded / numOfPlayers;
        }
        public int avgWeight(int allWeightAdded)
        {
            int numOfPlayers = players.Count();
            Console.WriteLine("Average Weight: "+allWeightAdded / numOfPlayers);
            return allWeightAdded / numOfPlayers;
        }
    }
}
