using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Vogelvoliere
{
    public class Voliere
    {
        public int Höhe { get; set; }
        public int Fläche { get; set; }

        public List<Vogel> Bewohner { get; set; } = new List<Vogel>();

        public void AddBewohner(Vogel vogel)
        {
            Bewohner.Add(vogel);
            Console.WriteLine($"Ein(e) {vogel.GetType().Name} wurde in Voliere untergebracht.");
        }

        public void ZeigeBewohner()
        {
            foreach (var item in Bewohner)
            {
                Console.WriteLine(item.GetType().Name + " wohnt im Voliere.");
            }
        }
    }
}
