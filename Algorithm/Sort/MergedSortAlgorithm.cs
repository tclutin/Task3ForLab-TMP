using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Algorithm.Sort
{
    //MergedSort | O(nlogn)
    public class MergedSortAlgorithm : IAlgorithm<string>
    {
        public void Execute(string[] array)
        {
            MergedSort(array);
        }

        public void MergedSort(string[] arr)
        {
            if (arr.Length > 1)
            {
                int mid = arr.Length / 2;

                string[] leftArr = new string[mid];
                string[] rightArr = new string[arr.Length - mid];

                for (int i = 0; i < mid; i++)
                {
                    leftArr[i] = arr[i];
                }

                for (int i = mid; i < arr.Length; i++)
                {
                    rightArr[i - mid] = arr[i];
                }

                MergedSort(leftArr);
                MergedSort(rightArr);

                int a = 0;
                int b = 0;
                int c = 0;

                while (a < leftArr.Length && b < rightArr.Length)
                {
                    if (string.Compare(leftArr[a], rightArr[b]) < 0)
                    {
                        arr[c] = leftArr[a];
                        a++;
                    }
                    else
                    {
                        arr[c] = rightArr[b];
                        b++;
                    }
                    c++;
                }

                while (a < leftArr.Length)
                {
                    arr[c] = leftArr[a];
                    a++;
                    c++;
                }

                while (b < rightArr.Length)
                {
                    arr[c] = rightArr[b];
                    b++;
                    c++;
                }
            }
        }
    }
}
