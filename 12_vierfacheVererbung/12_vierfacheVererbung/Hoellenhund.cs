namespace _12_vierfacheVererbung;

public class Hoellenhund : Daemonenhund
{
    protected int Verderbtheitsfaktor;
    protected int Gefaehrlichkeit;

    public Hoellenhund(int verderbtheitsfaktor, int anzahlSeelen, int hechelfrequenz) : base(hechelfrequenz,
        anzahlSeelen)
    {
        Gefaehrlichkeit = verderbtheitsfaktor * verderbtheit;
        Verderbtheitsfaktor = verderbtheitsfaktor;
        Console.WriteLine("Verderbtheit ist bei Höllenhunden immer 17");
    }
}