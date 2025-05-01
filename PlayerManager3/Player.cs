using System;

namespace PlayerManager3
{
    public class Player : IComparable<Player>
    {
        public string Name {get;}
        public int Score {get; set;}
        
        public Player(string Name, int Score)
        {
            this.Name = Name;
            this.Score = Score;
        }       
        public int CompareTo(Player other)
        {
            if (other == null) return -1;

            int result = other.Score.CompareTo(this.Score);
            if (result != 0)
            {
                return result;
            }

            return string.Compare(this.Name, other.Name, StringComparison.OrdinalIgnoreCase);
        }

        public override string ToString()
        {
            return $"{Name} - {Score}";
        }

    }
}
