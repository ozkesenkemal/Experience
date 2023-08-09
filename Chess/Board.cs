namespace Chess
{
    public class Board
    {
        private short xStoneCount;
        private short yStoneCount;
        public short XStoneCount { get { return xStoneCount; } }
        public short YStoneCount { get { return yStoneCount; } }
        public Dictionary<string, Stone> StoneList { get; }

        public Board(short xStoneCount, short yStoneCount)
        {
            this.xStoneCount = xStoneCount;
            this.yStoneCount = yStoneCount;
            StoneList = new Dictionary<string, Stone>();
            AddDefaultStoneList();
        }

        private void AddDefaultStoneList()
        {
            for (int i = 0; i < xStoneCount; i++)
            {
                for (int y = 0; y < yStoneCount; y++)
                {
                    StoneList.Add(i.ToString() + y.ToString(), null);
                }

            }
        }

        public void SetStoneList(short xLocation, short yLocation, Stone stone)
        {
            StoneList[xLocation.ToString() + yLocation.ToString()] = stone;
            Console.WriteLine("Stone Added: {0}, {1}", stone.Color, stone.Name);
        }
    }
}
