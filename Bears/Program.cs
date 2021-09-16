using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bears
{
    class Program
    {
        static void Main(string[] args)
        {
            IBear bear = new Grizzly();
            bear.Maul();
            bear.Hibernate();

            IToyBear toy = new TeddyBear();
            toy.Hug();

            IToyBear adapt = new BearAdapter(bear);
            adapt.Hug();
        }
    }
}
