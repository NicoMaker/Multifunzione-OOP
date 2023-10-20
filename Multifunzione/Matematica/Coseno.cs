namespace Multifunzione.Matematica;

internal class Coseno : BaseFunction
{
    public override string GetMenuTitle() => "Calcolo Coseno";

    public override void RunFunction()
    {
        CosenoFunction();
    }

    private static void CosenoFunction()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("");

        Console.Write("INSERISCI L'ANGOLO IL QUALE VUOI CALCOLARE IL COSENO---> ");
        double Angolo = Convert.ToDouble(Console.ReadLine());

        double Angolor = (Angolo * Math.PI) / 180;
        double Coseno = Math.Cos(Angolor);

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("");
        Console.WriteLine($"il coseno di {Angolo} è ----> {Coseno}");
    }
}