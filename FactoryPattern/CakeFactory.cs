using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class CakeFactory
    {
        public Cake MakeACake()
        {
            return new Cake();
        }
    }
}
