using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Vogelvoliere
{
    public abstract class Vogel
    {
        public String Farbe {  get; set; }
        public String Schnabel { get; set; }

        public  abstract void Fliegen();

        public void Flattern()
        {
            
        }
    }
}
