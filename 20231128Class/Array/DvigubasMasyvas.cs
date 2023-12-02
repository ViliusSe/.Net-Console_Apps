using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20231128Class.Array
{
    internal class DvigubasMasyvas
    {
        public int[,] masyvas = { { 1, 2, 3 }, { 2, 4, 1 } };
        public void RepeatingNumbers(int[,] arr)
        {
            int[] repeaters = { };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    int x = (arr[i, j]);
                    // reikia isvesti pasikartojancius skaicius
                }
            }
        }
    }
}
