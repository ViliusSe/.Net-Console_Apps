using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20231130HomeWork.ASYNC
{
    internal class FileReader
    {

        public async Task<string> ReadFile(string filename)
        {
            string text = await Task.Run(()=>File.ReadAllText($@"C:\Users\v.senkus\Desktop\30HW\{filename}.txt"));
            string cuttedext = text.Substring(text.Length - (text.Length / 10000));
            Console.WriteLine($"START of FIle {filename} --- {cuttedext} --- end of File {filename} \n");
            return cuttedext;

        }

        
    }
}
