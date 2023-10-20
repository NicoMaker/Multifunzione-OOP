namespace Multifunzione.Matematica;

internal class ArcoCoseno : BaseFunction
{
    public override string GetMenuTitle() => "Calcolo ArcoCoseno";

    public override void RunFunction()
    {
        ArcoCosenofunction();
    }

    public static void ArcoCosenofunction()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("");

        Console.Write("INSERISCI L'ANGOLO IL QUALE VUOI CALCOLARE L' ARCOCOSENO --> ");
        double Angolo = Convert.ToDouble(Console.ReadLine());

        double Angolor = (Angolo * Math.PI) / 180;
        double ArcCos = Math.Acos(Angolor);

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("");
        Console.WriteLine($"l'arcocoseno di {Angolo} è ----> {ArcCos}");
    }
}