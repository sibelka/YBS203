using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("YBS 203 - HAFTA 1\n");
            Console.WriteLine("İki tam sayı girin: ");
            var input = Console.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            Console.Write("Toplam: ");
            Console.WriteLine(a + b);
        }
    }
}
