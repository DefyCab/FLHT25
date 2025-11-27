using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{

    public class CakeRepository
    {
        public static List<Cake> ListOfCakes { get; set; }
        public static List<Cake> GetAll()
        {
            return ListOfCakes;

        }
    }
}
