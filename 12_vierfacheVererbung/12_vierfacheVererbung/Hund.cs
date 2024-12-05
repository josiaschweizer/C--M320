namespace _12_vierfacheVererbung;

public class Hund : Tier
{
    protected int Hechelfrequenz;

    protected Hund(int hechelfrequenz) : base("Fifi")
    {
        Hechelfrequenz = hechelfrequenz;
        Console.WriteLine("Alle Hunde heissen natürlich Fifi");
    }
}