namespace Multifunzione.Matematica;

internal class Logaritmi : BaseFunction
{
    public override string GetMenuTitle() => "Logaritmi";

    public override void RunFunction()
    {
        Logaritmo();
    }

    private static void Logaritmo()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("");

        Console.Write("INSERISCI IL NUMERO IL QUALE VUOI CALCOLARE IL LOGARITMO ---> ");
        double numero = Convert.ToDouble(Console.ReadLine());

        Console.Write("INSERISCI IL NUMERO DELLA BASE DEL LOGARITMO ---> ");
        double base_logaritmo = Convert.ToDouble(Console.ReadLine());

        double logaritmo = Math.Log(numero, base_logaritmo);

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("");
        Console.WriteLine($"il logaritmo in base {base_logaritmo} di {numero} è ----> {logaritmo}");

    }
}