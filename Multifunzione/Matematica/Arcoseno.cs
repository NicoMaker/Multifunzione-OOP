namespace Multifunzione.Matematica;

internal class Arcoseno : BaseFunction
{
    public override string GetMenuTitle() => "Calcolo ArcoSeno";

    public override void RunFunction()
    {
        ArcoSeneno();
    }

    private static void ArcoSeneno()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("");

        Console.Write("INSERISCI L'ANGOLO IL QUALE VUOI CALCOLARE L' ARCOSENO --> ");
        double Angolo = Convert.ToDouble(Console.ReadLine());

        double Angolor = (Angolo * Math.PI) / 180;
        double ArcSen = Math.Asin(Angolor);

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("");
        Console.WriteLine($"l'arcoseno di {Angolo} è ----> {ArcSen}");
    }
}