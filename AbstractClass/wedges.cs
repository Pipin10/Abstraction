using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.AbstractClass
{
    public class Wedges : AlasKaki
    {
        public override void Sepatu()
        {
            Console.WriteLine("Sepatu ini memiliki bentuk segitiga dan lebih rendah pada bagian depan.");
            Console.WriteLine("Sepatu ini pilihan tepat buat kamu yang ingin terlihat tinggi.");
            Console.WriteLine("Wedges sangat cocok digunakan dalam segala acara baik formal maupun infoemal.");
        }
    }
}