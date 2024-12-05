using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Hund
{
    private List<Laus> Läuse { get; set; }

    public Hund()
    {
        Läuse = new List<Laus>();
    }


    public void LäuseHinzufügen(Laus laus)
    {
        Läuse.Add(laus);
    }
}
