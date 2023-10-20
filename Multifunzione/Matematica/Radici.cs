
namespace Multifunzione.Matematica;

internal class Radici : BaseFunction
{
    public override string GetMenuTitle() => "Radici";

    public override void RunFunction()
    {
        RadiciFunction();
    }

    private static void RadiciFunction()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("");

        Console.Write("inserisci il numero il quale vuoi calcolare la radice ---> ");
        double numero = Convert.ToDouble(Console.ReadLine());

        Console.Write("inserisci l'esponente della radice---> ");
        double esponente = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("");
        double esponente_radice = 1 / esponente;

        double radice = Math.Pow(numero, esponente_radice);

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("");
        Console.WriteLine($"LA RADICE {esponente} di {numero} è  ----> {radice}");
    }
}
