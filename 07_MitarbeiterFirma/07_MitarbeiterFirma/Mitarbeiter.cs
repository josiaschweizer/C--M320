using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Mitarbeiter
{
    private List<Firma> FirmaListe { get; set; }

    public Mitarbeiter()
    {
        createInstanceOfList();
    }

    public Mitarbeiter(Firma firma)
    {
        createInstanceOfList();
        FirmaListe.Add(firma);
    }

    public Mitarbeiter(List<Firma> liste)
    {
        FirmaListe = liste;
    }

    public void firmaHinzufügen(Firma mitarbeiter)
    {
        FirmaListe.Add(mitarbeiter);
    }

    public void firmaHinzufügenListe(List<Firma> liste)
    {
        for (int i = 0; i < liste.Count; i++)
        {
            FirmaListe.Add(liste[i]);
        }
    }

    private void createInstanceOfList()
    {
        FirmaListe = new List<Firma>();

    }
}