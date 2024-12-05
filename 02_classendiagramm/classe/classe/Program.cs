public class Program
{
    public int Einnahme { get; set; }
    public int Ausgabe { get; set; }
    public double Zins { get; set; } = 2.00;
    private bool Gemahnt { get; set; }
    protected int Anzahl { get; set; }
    internal string Name { get; set; } = "Meier";
    public int Guthaben => Einnahme - Ausgabe;

    public readonly int Jahrgang;
}
