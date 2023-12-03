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
            foreach (int el in arr)
                repeaters.Add(el);

            repeaters.Sort();

            for (int i = 0; i < repeaters.Count(); i++)
            {
                if (i-2 <= repeaters.Count() && repeaters[i] == repeaters[i++])
                {
                    repeaters.Remove(i);
                    i--;
                }
            }

            Console.WriteLine("repeating numbers:");
            foreach (int el in repeaters)
                Console.Write($"{el}, ");
        }

        //masyvo prasukimo for loope pavyzdys.
        public void ListArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.WriteLine(arr[i, j]);
                }
            }
        }
    }
}

