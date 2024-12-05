using System.Runtime.CompilerServices;

namespace _12_vierfacheVererbung;

public class Program
{
    public static void Main(string[] args)
    {
        Hund hoellenhund = new Hoellenhund(50, 50, 50);
        Hund daemnonhund = new Daemonenhund(50, 50);
    }
}