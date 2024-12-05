using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Firma
{
    private List<Mitarbeiter> MitarbeiterListe { get; set; }

    public Firma()
    {
        createInstanceOfList();
    }

    public Firma(Mitarbeiter mitarbeiter)
    {
        createInstanceOfList();
        MitarbeiterListe.Add(mitarbeiter);
    }

    public Firma(List<Mitarbeiter> liste)
    {
        MitarbeiterListe = liste;
    }

    public void mitarbeiterHinzufügen(Mitarbeiter mitarbeiter)
    {
        MitarbeiterListe.Add(mitarbeiter);
    }

    public void mitarbeiterHinzufügenListe(List<Mitarbeiter> liste)
    {
        for(int i = 0; i < liste.Count; i++)
        {
            MitarbeiterListe.Add(liste[i]);
        }
    }

    private void createInstanceOfList()
    {
        MitarbeiterListe = new List<Mitarbeiter>();

    }
}