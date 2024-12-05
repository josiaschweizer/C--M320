using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Konto
{
    private Kunde Kunde { get; set; }

    public Konto(Kunde kunde)
    {
        Kunde = kunde;
    }


    public void changeKunde(Kunde newKunde)
    {
        Kunde = newKunde;
    }
}