using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Kunde
{
    private List<Buch> Bücher { get; set; }

    public Kunde()
    {
        Bücher = new List<Buch>();
    }

    public void buchHinzufügen(Buch buch)
    {
        Bücher.Add(buch);
    }
}
