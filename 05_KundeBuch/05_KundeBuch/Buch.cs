using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Buch
{
    private Kunde Kunde { get; set; }

    public Buch()
    {
        
    }

    public Buch(Kunde Kunde)
    {
        this.Kunde = Kunde;
    }

    public void kundeSetzen(Kunde Kunde)
    {
        this.Kunde = Kunde;
    }
}