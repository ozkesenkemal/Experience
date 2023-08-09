namespace Chess
{
    public class Castle : Stone
    {
        public Castle(string color, string name, short xLocation, short yLocation, Player player)
            : base(color, name, xLocation, yLocation, player)
        {
        }
        public override bool CanMoveTo(Board board, short xLocationTo, short yLocationTo, Stone stone)
        {
            if(!ValidateStone(board, Xlocation, Ylocation, xLocationTo,yLocationTo, stone))
            {
                return false;
            }
            else if(board.StoneList[xLocationTo.ToString() + yLocationTo.ToString()] == null ||
                board.StoneList[xLocationTo.ToString() + yLocationTo.ToString()].Player != Player)
            {
                if((Ylocation == yLocationTo && Math.Abs(Xlocation - xLocationTo) < 8) ||
                   (Xlocation == xLocationTo && Math.Abs(Ylocation - yLocationTo) < 8))
                {
                    return true;
                }

                return false;
            }

            return false;
        }
    }
}
