namespace Chess
{
    public class Player
    {
        private readonly string gamerName;
        public string GamerName { get { return gamerName; } }

        private readonly string gamerColor;
        protected string GamerColor { get { return gamerColor; } }
        public Player(string gamerName, string color)
        {
            this.gamerName = gamerName;
            this.gamerColor = color;
        }
    }
}
