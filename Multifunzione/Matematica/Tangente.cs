namespace Multifunzione.Matematica;

internal class Tangente : BaseFunction
{
    public override string GetMenuTitle() => "Calcolo Tangente";

    public override void RunFunction()
    {
        Tangentefunction();
    }

    private static void Tangentefunction()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("");

        Console.Write("INSERISCI L'ANGOLO IL QUALE VUOI CALCOLARE LA TANGENTE --> ");
        double Angolo = Convert.ToDouble(Console.ReadLine());

        double Angolor = (Angolo * Math.PI) / 180;
        double Tangente = Math.Sin(Angolor) / Math.Cos(Angolor);

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("");
        Console.WriteLine($"la tangente di {Angolo} è ----> {Tangente}");
    }
}