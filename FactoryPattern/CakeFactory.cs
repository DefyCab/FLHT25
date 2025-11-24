using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class CakeFactory
    {
        public static Cake MakeACake()
        {
            return new Cake { id = Index.Start.Value, price = 100, type = "princesstårta" };
        }
    }
}
