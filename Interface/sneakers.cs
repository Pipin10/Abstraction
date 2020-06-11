using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interface
{
    public class Sneakers : IAlasKaki
    {
        public  void Sepatu()
        {
            Console.WriteLine("Sepatu ini sangat populer di kalangan semua umur.");
            Console.WriteLine("Sepatu ini tidak hanya digunakan untuk olahraga saja, namun sekarang menjadi tren dikehidupan,");
            Console.WriteLine("sepatu ini berkarakter kasual dan sporty yang membuat nyaman digunakan dalam sehari-hari.");
        }
    }
}