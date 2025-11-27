using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FactoryPattern
{
    public class CakeServive
    {
        public List<Cake> GetAllCakes(List<Cake> cake)
        {
            return CakeFactory.GetAll;
        }
    }
}
