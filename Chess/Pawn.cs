namespace Chess
{
    public class Pawn : Stone
    {
        private readonly short initialXLocation;
        private readonly short initialYLocation;
        private readonly bool upperDirection;
        public Pawn(string color, string name, short xLocation, short yLocation,bool direction, Player player)
            : base(color, name, xLocation, yLocation, player)
        {
            this.initialXLocation = xLocation;
            this.initialYLocation = yLocation;
            upperDirection = direction;
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
                if (Xlocation == initialXLocation && Ylocation == initialYLocation) // ilk hamlede 2 kare gidebilir
                {
                    if (upperDirection)
                    {
                        return (xLocationTo - Xlocation) <= 2;
                    }
                    else
                    {
                        return (Xlocation - xLocationTo) <= 2;
                    }
                }
                else
                {
                    if (Math.Abs(Ylocation - yLocationTo) <= 1) // ylocation yönden bağımsız 1 den fazla olamaz
                    {
                        if (upperDirection) // ya boş ileri gider ya sol sağ çaprazdaki taşları yiyerek ilerler
                        {
                            return (xLocationTo - Xlocation) <= 1;
                        }
                        else
                        {
                            return (Xlocation - xLocationTo) <= 1;
                        }
                    }
                }

                return false;
            }

            return false;
        }

        public override bool CanEat(Board board, short xLocationTo, short yLocationTo)
        {
            if (board.StoneList[xLocationTo.ToString() + yLocationTo.ToString()] == null)
            {
                return true;
            }

            if (board.StoneList[xLocationTo.ToString() + yLocationTo.ToString()].Player != Player)
            {
                if(Math.Abs(Ylocation - yLocationTo) == 1)// sadece çapraz yer can move da direction kontrolü yapıldı.
                {
                    return true;
                }

                return false;
            }

            return false;
        }
    }
}
