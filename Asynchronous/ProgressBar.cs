using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asynchronous
{
    internal class ProgressBar
    {

        static int progress { get; set; } = 0;

        public void Progres()
        {
            for (int i = 0; i < 100; i++)
            {
                Task.Delay(1000).Wait();
                ++progress;
            }
        }

        public void ShowProgress()
        {
            while (true)
            {
                Task.Delay(3000).Wait();
                Console.WriteLine(progress);
            }
        }
    }
}
