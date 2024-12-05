using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Laus
{
    private Hund Hund;

    public Laus(Hund hund)
    {
        if (hund != null)
        {
            Hund = hund;
            hund.LäuseHinzufügen(this);
        }
    }
}
