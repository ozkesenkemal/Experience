namespace Chess
{
    public abstract class Stone
    {
        public Stone(string color, string name, short xLocation, short yLocation, Player player)
        {
            this.color = color;
            this.name = name;
            Xlocation = xLocation;
            Ylocation = yLocation;
            this.player = player;
        }

        private string color;
        private string name;
        private Player player;
        public string Color { get { return color; } }
        public string Name { get { return name; } }
        public Player Player { get { return player; } }

        public short Xlocation;
        public short Ylocation;

        public abstract bool CanMoveTo(Board board, short xLocationTo, short yLocationTo, Stone stone);
        public bool MoveTo(Board board, short xLocationTo, short yLocationTo, Stone stone)
        {
            if (CanMoveTo(board, xLocationTo, yLocationTo, stone))
            {
                if (CanEat(board, xLocationTo, yLocationTo))
                {
                    Eat(board, xLocationTo, yLocationTo, stone);
                }
                Console.WriteLine("Stone Moved");
                return true;
            }
            return false;
        }

        public virtual bool CanEat(Board board, short xLocationTo, short yLocationTo)
        {
            if (board.StoneList[xLocationTo.ToString() + yLocationTo.ToString()] == null)
            {
                return true;
            }

            if (board.StoneList[xLocationTo.ToString() + yLocationTo.ToString()].Player != player)
            {
                return true;
            }

            return false;
        }

        private void Eat(Board board, short xLocationTo, short yLocationTo, Stone stone)
        {
            board.StoneList[xLocationTo.ToString() + yLocationTo.ToString()] = stone;
            board.StoneList[stone.Xlocation.ToString() + stone.Ylocation.ToString()] = null;
            stone.Xlocation = xLocationTo;
            stone.Ylocation = yLocationTo;
        }

        public bool ValidateStone(Board board, short xLocation, short yLocation, short xLocationTo, short yLocationTo, Stone stone)
        {
            if (xLocation == xLocationTo && yLocation == yLocationTo ||
                board.StoneList[xLocationTo.ToString() + yLocationTo.ToString()]?.Player == Player) // kendi kendine hareket edemez.
            {
                return false;
            }

            if (yLocationTo >= 8 || yLocationTo < 0 ||
                xLocationTo >= 8 || xLocation < 0) // board dışına çıkmasın
            {
                return false;
            }

            return true;
        }
    }
}