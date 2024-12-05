using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Trainer : Person
{
    public Sportchef Sportchef { get; set; }
    public List<Person> Spieler { get; set; } = [];
    public List<Person> Ersatzspieler { get; set; } = [];

    public List<Person> Goalie { get; set; } = [];
}