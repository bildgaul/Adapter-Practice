using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bears
{
    class BearAdapter : IToyBear
    {
        IBear bear;
        public BearAdapter(IBear species)
        {
            bear = species;
        }

        public void Hug()
        {
            bear.Maul();
        }
    }
}
