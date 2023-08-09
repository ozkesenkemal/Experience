﻿namespace Chess
{
    public class Elephant : Stone
    {
        public Elephant(string color, string name, short xLocation, short yLocation, Player player)
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
                if (Math.Abs(Ylocation - yLocationTo) == Math.Abs(Xlocation - xLocationTo))// fill çapraz gider
                {
                    return true;
                }

                return false;
            }

            return false;
        }
    }
}
