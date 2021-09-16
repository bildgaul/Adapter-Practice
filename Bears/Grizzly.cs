using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bears
{
    class Grizzly : IBear
    {
        public void Maul()
        {
            Console.WriteLine("The bear mauls you!");
        }

        public void Hibernate()
        {
            Console.WriteLine("The bear goes into hibernation.");
        }
    }
}
