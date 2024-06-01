using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum Player_role
{
    Goalkeeper,
    Defender,
    Midfielder,
    Attacker
}

namespace SoccerSim.BackEnd_Classes
{
     public abstract class Player
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public int Number {  get; set; }
        public string Team {  get; set; }
        public Player_role Role { get; set; }
        public Tuple<int, int> Init_position { get; set; }
        public int Pass_stat {  get; set; }
        public int Shot_stat { get; set; }
        public int Tackle_stat { get; set; }
        public int Dribble_stat { get; set; }
        public int Save_stat { get; set; }
        public int Speed_stat { get; set; }
        public Tuple<int, int> Position { get; set; }

    }

    public class GoalKeeper : Player
    {
        public GoalKeeper(string name) 
        {
            this.Name = name;
        }
    }
}
