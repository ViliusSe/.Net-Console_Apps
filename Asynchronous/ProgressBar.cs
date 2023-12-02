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
        
        public int Progres()
        {
            return ++progress;
        }
    }
}
