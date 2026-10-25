

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadilarBayrami
{

    public class Canavar
    {
        protected string ad;
        protected float health;
        string Korkut() { return ad + " BOOO!"; }
        public Canavar() { }
    }

    public class Vampir : Canavar
    {
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("kurbağa 🍀");
        }
    }
}
