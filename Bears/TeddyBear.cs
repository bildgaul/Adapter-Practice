using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bears
{
    class TeddyBear : IToyBear
    {
        public void Hug()
        {
            Console.WriteLine("The teddy bear hugs you! How sweet!");
        }
    }
}
