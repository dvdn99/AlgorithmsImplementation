using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class Sort
    {
        #region quicksort
        public static void QuickSort(int[] arr, int low, int high)
        {
            if (high <= low) return;

            int pivotIndex = partition(arr, low, high);

            QuickSort(arr, low, pivotIndex - 1);
            QuickSort(arr, pivotIndex, high);
        }

        private static int partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];

            int temp_pivot_index = low - 1;

            for (int j = low; j < high; j++)
            {
                if (arr[j] <= pivot)
                {
                    temp_pivot_index++;
                    swap(arr, temp_pivot_index, j);
                }
            }

            temp_pivot_index++;
            swap(arr, temp_pivot_index, high);
            return temp_pivot_index;
        }

        private static void swap(int[] a, int i, int j)
        {
            var temp = a[i];
            a[i] = a[j];
            a[j] = temp;
        }

        #endregion
    }
}
