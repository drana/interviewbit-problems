using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class RectangularPattern
    {
        public List<List<int>> prettyPrint(int A)
        {
            //intialize
            int size = (2 * A) - 1; // rows and columns of matrix
            int[,] result = new int[size, size];

            for (int i = 0; i < A; i++)
            {
                for (int j = 0; j < A; j++)
                {
                    if (j <= i)
                        result[i, j] = A - j;
                    else
                        result[i, j] = A - i;
                }

            }

            int counter = 1;
            for (int i = A; i < size; i++)
            {
                for (int j = 0; j < A; j++)
                {
                    result[i, j] = result[A - counter - 1, j];
                }
                counter++;
            }


            counter = 1;

            for (int j = A; j < size; j++)
            {
                for (int i = 0; i < size; i++)
                {
                    result[i, j] = result[i, A - counter - 1];
                }
                counter++;
            }


            List<List<int>> arr = new List<List<int>>();


            for (int i = 0; i < size; i++)
            {
                List<int> column = new List<int>();
                for (int j = 0; j < size; j++)
                {
                    //Console.Write(string.Format("{0} ", result[i, j]));
                    column.Add(result[i, j]);
                }
                arr.Add(column);
                //Console.Write(Environment.NewLine + Environment.NewLine);
            }

            return arr;

        }
    }
}
