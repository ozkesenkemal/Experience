namespace StrategyGof
{
    public class Sorter
    {
        private readonly ISort _sorter;

        public Sorter(ISort sorter)
        {
            _sorter = sorter;
        }

        public void Sort(List<int> list)
        {
            list = _sorter.Sort(list);
            PrintArr(list);
        }

        private void PrintArr(List<int> list)
        {
            foreach (int i in list)
            {
                Console.Write(i.ToString() + "  ");
            }
            Console.WriteLine();
        }
    }
}
