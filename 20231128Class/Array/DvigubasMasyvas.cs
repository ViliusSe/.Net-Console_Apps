using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20231128Class.Array
{
    internal class DvigubasMasyvas
    {
        private List<int> repeaters = new List<int>();
        public void RepeatingNumbers(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    int x = (arr[i, j]);

                    for (int z = i; z < arr.GetLength(0); z++)
                    {
                        for (int h = j + 1; h < arr.GetLength(1) - 1; h++)
                        {
                            if (x == arr[z, h]) repeaters.Add(x);
                        }

                    }
                }
            }

            foreach (int i in repeaters)
            {
                Console.WriteLine(i);
            }
        }

    }
}

