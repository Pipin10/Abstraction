using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//menggunakan using Abstraction.AbstractClass;    // dengan untuk Abstract Class
using Abstraction.Interface;      // dengan untuk Interface

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            /*AlasKaki;          // Menggunakan Abstract Class

            Console.WriteLine();
            AlasKaki = new Wedges();
            AlasKaki.Sepatu();
            Console.WriteLine();

            AlasKaki = new Flatshoes();
            AlasKaki.Sepatu();
            Console.WriteLine();

            AlasKaki = new Sneakers();
            AlasKaki.Sepatu();
            Console.WriteLine();

            AlasKaki = new Highheels();
            AlasKaki.Sepatu();
            Console.WriteLine();*/

            IAlasKaki AlasKaki;       // Menggunakan Interface

            Console.WriteLine();
            AlasKaki = new Wedges();
            AlasKaki.Sepatu();
            Console.WriteLine();

            AlasKaki = new Flatshoes();
            AlasKaki.Sepatu();
            Console.WriteLine();

            AlasKaki = new Sneakers();
            AlasKaki.Sepatu();
            Console.WriteLine();

            AlasKaki = new Highheels();
            AlasKaki.Sepatu();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}