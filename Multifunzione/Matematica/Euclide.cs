namespace Multifunzione.Matematica;

internal class Euclide : BaseFunction
{
    public override string GetMenuTitle() => "Euclide";

    public override void RunFunction()
    {
        int numero1 = Inserisci1();
        int numero2 = Inserisci2();
        Visualizza(numero1 , numero2);
    }

    private static int Inserisci1()
    {
        Console.Write("INSERISCI PRIMO NUMERO ---> ");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        return numero1;
    }

    private static int Inserisci2()
    {
        Console.Write("INSERISCI SECONDO NUMERO ---> ");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        return numero2;
    }

    private static void Visualizza(int numero1, int numero2)
    {
        int passaggio = 0;
        int resto = numero1 % numero2;
        int quoziente = numero1 / numero2;

        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.DarkGreen;

        while (resto > 0)
        {
            passaggio++;
            Console.WriteLine($"{passaggio} passaggio ----> {numero1} = {numero2} * {quoziente} + {resto}");
            numero1 = numero2;
            numero2 = resto;
            resto = numero1 % numero2;
            quoziente = numero1 / numero2;
        }

        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.DarkCyan;

        Console.WriteLine($"Per ricavare l'MCD sono serviti ---> {passaggio} passaggi");
        Console.WriteLine("MCD ----> " + numero2);
    }
}