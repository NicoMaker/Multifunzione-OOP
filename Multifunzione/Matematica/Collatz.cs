namespace Multifunzione.Matematica;

internal class Collatz : BaseFunction
{
    public override string GetMenuTitle() => "Collatz";

    public override void RunFunction()
    {
        int numero = Inserisci();
        Visualizza(numero);
    }

    private static int Inserisci()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;

        Console.Write("INSERISCI IL NUMERO IL QUALE VOGLIO FARE COLLATZ ---> ");
        int numero = Convert.ToInt32(Console.ReadLine());

        return numero;
    }

    private static void Visualizza(int numero)
    {
        int k = 0;

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("");

        while (numero > 1)
        {
            Console.Write(" " + numero + " -->");

            if (numero % 2 == 0)
            {
                numero = numero / 2;
                k++;
            }
            else
            {
                numero = 3 * numero + 1;
                k++;
            }
        }

        Console.Write(" 1");

        Console.WriteLine("");
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine(" K ---> " + k);
    }
}
