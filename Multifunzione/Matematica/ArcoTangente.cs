namespace Multifunzione.Matematica;

internal class ArcoTangente : BaseFunction
{
    public override string GetMenuTitle() => "Calcolo ArcoTangente";

    public override void RunFunction()
    {
        ArcoTangenteFuncrion();
    }

    public static void ArcoTangenteFuncrion()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("");

        Console.Write("INSERISCI L'ANGOLO IL QUALE VUOI CALCOLARE L' ARCOCOTANGENTE --> ");
        double Angolo = Convert.ToDouble(Console.ReadLine());

        double Angolor = (Angolo * Math.PI) / 180;
        double ArcTan = Math.Atan(Angolor);

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("");
        Console.WriteLine($"l'arcocoseno di {Angolo} è ----> {ArcTan}");
    }
}