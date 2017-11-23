using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class NextGreater
    {
        public void NextGreaterValue()
        {
            List<int> arr = new List<int>();
            arr.Add(4);
            arr.Add(5);
            arr.Add(2);
            arr.Add(10);

            List<int> res = new List<int>(arr.Count());

            for (int i = 0; i < arr.Count(); i++)
            {
                int found = 0;

                for (int j = i + 1; j < arr.Count(); j++)
                {

                    if (arr[i] < arr[j])
                    {
                        res.Add(arr[j]);
                        found = 1;
                        break;
                    }

                }
                if (found == 0)
                {
                    res.Add(-1);
                }
            }

        }
    }
}
