using System.Xml.Linq;

public class Program
{
    static void Main(string[] args)
    {
        Sportchef sportchef = new() { Name = "Müller" };
        Trainer trainer = new() { Name = "Schmidt" };
        Goalie goalie = new() { Name = "Neuer" };
        Feldspieler feldspieler1 = new() { Name = "Müller" };
        Feldspieler feldspieler2 = new() { Name = "Meyer" };
        Ersatzbank ersatzspieler1 = new() { Name = "Schulz" };

        sportchef.Trainer = trainer;
        trainer.Sportchef = sportchef;
        trainer.Goalie.Add(goalie);
        trainer.Spieler.Add(feldspieler1);
        trainer.Spieler.Add(feldspieler2);
        trainer.Ersatzspieler.Add(ersatzspieler1);

        PrintAllSpieler(trainer);
    }

    static void PrintAllSpieler(Trainer trainer)
    {
        foreach (var mySpieler in trainer.Spieler)
        {
            Console.WriteLine(mySpieler.Name);
        }

        foreach (var ersatzspieler in trainer.Ersatzspieler)
        {
            Console.WriteLine(ersatzspieler.Name);
        }

        foreach (var goalie in trainer.Goalie)
        {
            Console.WriteLine(goalie.Name);
        }
    }
}