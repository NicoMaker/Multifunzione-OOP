namespace Multifunzione.Matematica;

internal class ValoriAssoluti : BaseFunction
{
    public override string GetMenuTitle() => "Valori Assoluti";
    public override void RunFunction()
    {
        Valori_assolutiFunction();
    }

    private static void Valori_assolutiFunction()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("");

        Console.Write("INSERISCI IL NUMERO IL QUALE VUOI CALCOLARE IL VALORE ASSOLUTO ---> ");
        double numero = Convert.ToDouble(Console.ReadLine());

        double valore_assoluto = 0;

        if (numero < 0)
            valore_assoluto = numero * -1;
        else
            valore_assoluto = numero;

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("");
        Console.WriteLine($"il valore assoluto di {numero} è ----> {valore_assoluto}");
    }
}