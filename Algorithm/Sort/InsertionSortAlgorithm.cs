using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab4.Algorithm.Sort
{
    public class InsertionSortAlgorithm : IAlgorithm<string>
    {
        public void Execute(string[] array)
        {
            InsertionSort(array);
        }

        public void InsertionSort(string[] array)
        {
            int n = array.Length;
            for (int i = 1; i < n; i++)
            {
                string key = array[i];
                int j = i - 1;

                while (j >= 0 && string.Compare(array[j], key, StringComparison.OrdinalIgnoreCase) > 0)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j + 1] = key;
            }
        }
    }
}
