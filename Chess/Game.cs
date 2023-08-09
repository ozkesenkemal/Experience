namespace Chess
{
    public abstract class Game
    {
        private string gameName;
        protected string GameName { get { return gameName; } }

        public bool HasBoard { get; }

        private short playerCount;

        public List<Player> PlayerList { get; }
        protected Board board;
        public Board Board { get { return board; } }
        private short PlayerCount { get { return playerCount; } }
        public Game(string gameName, bool hasBoard, short playerCount)
        {
            this.gameName = gameName;
            this.HasBoard = hasBoard;
            this.playerCount = playerCount;
            this.PlayerList = new List<Player>();
        }

        public abstract Player AddPlayer(string playerName, string color);
        public virtual string AddBoard(short xsize, short ysize)
        {
            if (HasBoard)
            {
                this.board = new Board(xsize, ysize);
                return "Board added";
            }
            else
            {
                return "Game has no board!";
            }
        }
        public abstract string GetGameName();
    }
}
