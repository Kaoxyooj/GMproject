using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMproject
{
    public class Packers
    {
        public Roster rost = new Roster();
        Quarterback A_Rodgers = new Quarterback()
        {
            Name = "Aaron Rodgers",
            Position = " | " + Player.type.Offense.ToString() + " " + Player._position.QB.ToString(),
            Age = 32,
            Weight = 225,
            passPercentage = 60.7,
            passRating = 92.7,
            OverallRating = 92.7,
        };
        Quarterback S_Tozien = new Quarterback()
        {
            Name = "Scott Tolzien",
            Position = " | " + Player.type.Offense.ToString() + " " + Player._position.QB.ToString(),
            Age = 28,
            Weight = 213,
            passPercentage = 100,
            passRating = 83.3,
            OverallRating = 83.3,
        };
        Runningback E_Lacy = new Runningback()
        {
            Name = "Eddie Lacy",
            Position = " | " + Player.type.Offense.ToString() + " " + Player._position.RB.ToString(),
            Age = 25,
            Weight = 234,
            rushAttmpts = 187,
            rushYards = 758,
            touchdowns = 3,
            OverallRating = 80,
        };
        Center JC_Tretter = new Center()
        {
            Name = "JC Tretter",
            Position = " | " + Player.type.Offense.ToString() + " " + Player._position.C.ToString(),
            Age = 24,
            Weight = 307,
            OverallRating = 80,
        };
        WideReciever R_Cobb = new WideReciever()
        {
            Name = "Randall Cobb",
            Position = " | " + Player.type.Offense.ToString() + " " + Player._position.WR.ToString(),
            Age = 25,
            Weight = 192,
            receptions = 79,
            yards = 829,
            touchdowns = 6,
            OverallRating = 80,
        };
        public void roster()
        {
            Console.WriteLine("Green Bay Packers Roster");
            Console.WriteLine("------------------------");
            rost.players = new List<Player>();
            rost.players.Add(A_Rodgers);
            rost.players.Add(S_Tozien);
            rost.players.Add(E_Lacy);
            rost.players.Add(R_Cobb);
            rost.players.Add(JC_Tretter);
            foreach (object i in rost.players)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("------------------------");
        }
        public double allRating()
        {
            double allRatingAdded = A_Rodgers.OverallRating + E_Lacy.OverallRating + JC_Tretter.OverallRating + R_Cobb.OverallRating + S_Tozien.OverallRating;
            return allRatingAdded;
        }
        public int AvgAge()
        {
            int allAgeAdded = A_Rodgers.Age + E_Lacy.Age + JC_Tretter.Age + R_Cobb.Age + S_Tozien.Age;
            return allAgeAdded;
        }
        public int allWeight()
        {
            int allWeightAdded = A_Rodgers.Weight + E_Lacy.Weight + JC_Tretter.Weight + R_Cobb.Weight + S_Tozien.Weight;
            return allWeightAdded;
        }
    }
}
