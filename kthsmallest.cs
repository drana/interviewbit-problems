using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class KthElement
    {
        public int kthsmallest(List<int> A, int B)
        {

            List<int> arr = A;
            int n = arr.Count();

            //use selection sort to sort elements and return the kth element
            for (int i = 0; i < n - 1; i++)
            {
                // sort min values to left of array
                int min_id = i;
                for (int j = i + 1; j < n; j++)
                    if (arr[j] < arr[min_id])
                        min_id = j;

                // Swap elements
                int temp = arr[min_id];
                arr[min_id] = arr[i];
                arr[i] = temp;
            }

            return arr[B - 1];

        }
    }
}
