using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class UniquePermutations
    {
        public List<List<int>> permute(List<int> A)
        {
            List<List<int>> result = new List<List<int>>();
            permute(A, 0, result);

            return result;

        }

        private static void permute(List<int> num, int i, List<List<int>> result)
        {
            List<int> temp = new List<int>();
            temp.AddRange(num);
            if (i >= num.Count())
            {
                result.Add(temp);
            }
            for (int j = i; j <= num.Count() - 1; j++)
            {
                if (containsDuplicate(num, i, j))
                {
                    swap(num, i, j);
                    permute(num, i + 1, result);
                    swap(num, i, j);
                }
            }
        }

        private static void swap(List<int> num, int i, int j)
        {
            int temp = num[i];
            num[i] = num[j];
            num[j] = temp;
        }

        private static Boolean containsDuplicate(List<int> num, int i, int j)
        {
            for (int k = i; k <= j - 1; k++)
            {
                if (num[k] == num[j])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
