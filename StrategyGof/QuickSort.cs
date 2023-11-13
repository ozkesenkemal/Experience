namespace StrategyGof
{
    public class QuickSort : ISort
    {
        public List<int> Sort(List<int> list)
        {
            Sort(ref list, 0, list.Count - 1);
            return list;
        }

        private void Sort(ref List<int> arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(ref arr, left, right);

                Sort(ref arr, left, pivot - 1);
                Sort(ref arr, pivot + 1, right);
            }
        }

        private int Partition(ref List<int> arr, int left, int right)
        {
            int pivot = arr[right];
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            int temp1 = arr[i + 1];
            arr[i + 1] = arr[right];
            arr[right] = temp1;

            return i + 1;
        }
    }
}
