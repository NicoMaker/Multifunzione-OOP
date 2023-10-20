
namespace Multifunzione.Matematica;

internal class Seno : BaseFunction
{
    public override string GetMenuTitle() => "Calcolo Seno";

    public override void RunFunction()
    {
        SenoFunction();
    }

    private static void SenoFunction()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("");

        Console.Write("INSERISCI L'ANGOLO IL QUALE VUOI CALCOLARE IL SENO ---> ");
        double Angolo = Convert.ToDouble(Console.ReadLine());

        double Angolor = (Angolo * Math.PI) / 180;
        double Seno = Math.Sin(Angolor);

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("");
        Console.WriteLine($"il seno di {Angolo} è ----> {Seno}");
    }
}