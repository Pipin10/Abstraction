using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.AbstractClass
{
    public class Flatshoes : AlasKaki
    {
        public override void Sepatu()
        {
            Console.WriteLine("Flatshoes merupakan sepatu yang paling nyaman dan sehat sebagai pelindung kaki.");
            Console.WriteLine("Memakai sepatu ini dijamin tidak akan membuat kaki terasa pegal meski dipakai seharian,");
            Console.WriteLine("karena nyaman dan sepatu ini cocok digunakan dalam berbagai macam aktivitas.");
        }
    }
}