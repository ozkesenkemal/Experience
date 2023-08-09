namespace Chess
{
    public class Horse : Stone
    {
        public Horse(string color, string name, short xLocation, short yLocation, Player player)
            : base(color, name, xLocation, yLocation, player)
        {
        }
        public override bool CanMoveTo(Board board, short xLocationTo, short yLocationTo, Stone stone)
        {
            if (!ValidateStone(board, Xlocation, Ylocation, xLocationTo, yLocationTo, stone))
            {
                return false;
            }
            else if (board.StoneList[xLocationTo.ToString() + yLocationTo.ToString()] == null ||
                board.StoneList[xLocationTo.ToString() + yLocationTo.ToString()].Player != Player)
            {
                if ((Math.Abs(Ylocation - yLocationTo) == 1 && Math.Abs(Xlocation - xLocationTo) == 2) ||
                    (Math.Abs(Ylocation - yLocationTo) == 2 && Math.Abs(Xlocation - xLocationTo) == 1)) // At L gider
                {
                    return true;
                }

                return false;
            }

            return false;
        }
    }
}
