using _11_Lidl;

public class Program
{
    static void Main(string[] args)
    {
        var person1 = new Person();
        var kunde1 = new Kunde();
        var lagerist1 = new Lagerist();

        person1.Name = "Hans";
        person1.Vorname = "Jochen";

        kunde1.Name = "kunde";
        kunde1.Vorname = "Kundenvorname";
        kunde1.Umsatz = 1000;

        lagerist1.Name = "lagerist";
        lagerist1.Vorname = "lageristenvorname";
        lagerist1.Groesse = 187;

        person1.Essen();
        kunde1.Essen();
        kunde1.kaufen();

        lagerist1.Essen();
        lagerist1.LagereEin();
    }
}