namespace _12_vierfacheVererbung;

public class Daemonenhund : Hund
{
    protected readonly int verderbtheit;
    protected int AnzahlSeelen;


    public Daemonenhund(int hechelfrequenz, int anzahlSeelen) : base(hechelfrequenz)
    {
        verderbtheit = anzahlSeelen * hechelfrequenz;
        this.AnzahlSeelen = anzahlSeelen;
    }
}