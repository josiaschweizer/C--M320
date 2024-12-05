using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Lidl
{
    internal class Person
    {
        public String Name { get; set; }
        public String Vorname { get; set; }

        public void Essen()
        {
            System.Console.WriteLine("Ich als Person {0} {1} esse mit Messer und Gabel", Vorname, Name);
        }
    }
}
