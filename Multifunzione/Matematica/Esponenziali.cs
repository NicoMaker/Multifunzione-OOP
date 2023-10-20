namespace Multifunzione.Matematica;

internal class Esponenziali : BaseFunction
{
    public override string GetMenuTitle() => "Esponenzilali";

    public override void RunFunction()
    {
        Esponenzili();
    }

    private static void Esponenzili()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("");
        
        Console.Write("inserisci il numero il quale vuoi calcolare l'espoonenzile ---> ");
        double numero = Convert.ToDouble(Console.ReadLine());

        Console.Write("inserisci l'esponente dell' esponenziale---> ");
        double esponente = Convert.ToDouble(Console.ReadLine());

        double esponenziale = Math.Pow(numero, esponente);

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("");
        Console.WriteLine($"il risultato di  {numero} ^ {esponente}  è ----> {esponenziale}");
    }
}