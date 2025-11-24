using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class CakeFactory
    {
        private static int _index = 0;
        public static Cake MakeACake()
        {
            _index++;
            return new Cake { id = _index, type = "Unknown" };
        }
    }
}
