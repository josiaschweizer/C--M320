using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Kunde
{
    private List<Konto> Kontos { get; set; }


    public Kunde()
    {
        createInstanceOfList();
        Kontos.Add(new Konto(this));
    }
    public Kunde(Konto konto)
    {
        createInstanceOfList();
        Kontos.Add(konto);
    }

    public Kunde(List<Konto> kontos)
    {
        if (kontos == null)
        {
            throw new ArgumentNullException();
        }
        else if (kontos.Count <= 5)
        {
            Kontos = kontos;
        }
        else
        {
            createInstanceOfList();
            for (int i = 0; i < 5; i++)
            {
                Kontos.Add(kontos[i]);
            }
        }
    }

    private void createInstanceOfList()
    {
        Kontos = new List<Konto>();
    }

    public void kontoHinzufügen(Konto konto)
    {
        if (Kontos.Count <= 4)
        {
            Kontos.Add(konto);
        }
    }
}
