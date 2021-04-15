namespace ConsoleApp1
{
    public class Sort
    {
        void swap(ref int x, ref int y)
        {
            var t = x;
            x = y;
            y = t;
        }

        int Partition(int[] array, int minIndex, int maxIndex)
        {
            var pivot = minIndex - 1;
            for (var i = minIndex; i < maxIndex; i++)
            {
                if (array[i] < array[maxIndex])
                {
                    pivot++;
                    swap(ref array[pivot], ref array[i]);
                }
            }

            pivot++;
            swap(ref array[pivot], ref array[maxIndex]);
            return pivot;
        }

        public int[] QuickSort(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }

            var pivotIndex = Partition(array, minIndex, maxIndex);
            QuickSort(array, minIndex, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, maxIndex);

            return array;
        }

        public int[] QuickSort(int[] array)
        {
            return QuickSort(array, 0, array.Length - 1);
        }
    }
}
