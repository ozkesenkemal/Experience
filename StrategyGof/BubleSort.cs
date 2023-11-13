namespace StrategyGof
{
    public class BubleSort : ISort
    {
        public List<int> Sort(List<int> list)
        {
            int temp;
            for (int i = 0; i < list.Count - 2; i++)
            {
                for (int j = 0; j < list.Count - 2; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        temp = list[j + 1];
                        list[j + 1] = list[j];
                        list[j] = temp;
                    }
                }
            }
            return list;
        }
    }
}
