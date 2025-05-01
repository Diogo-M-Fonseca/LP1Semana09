namespace PlayerManager2
{
    public class Player
    {
        private string Name {get;}
        public int Score;
        public Player(string Name, int Score)
        {
            this.Name = Name;
            this.Score = Score;
        }       

    }
}