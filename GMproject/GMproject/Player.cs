using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMproject
{
    public abstract class Player
    {
        public enum type
        {
            Offense,
            Defense,
            SpecialTeams,
        }
        public enum _position
        {
            QB,
            C,
            RB,
            FB,
            WR,
            TE,
            G,
            ILB,
            K,
            LB,
            LS,
            NT,
            OLB,
            P,
            SS,
            T,
        }
        protected string name { get; set; }
        protected int age { get; set; }
        protected int weight { get; set; }
        protected string position { get; set; }
        protected double overallRating { get; set; }
        public virtual void action()
        {

        }
        public override string ToString()
        {
            return "Name: " + name + " | " + "Age: " + age + " | " + "Weight: " + weight + " | " + "Position: " + position + " | " + "Overall Rating: " + overallRating;
        }
    }
}
