namespace Multifunzione.Matematica;

internal class Numeri_Primi : BaseFunction
{
    public override string GetMenuTitle() => "Verifica se nunero Prino";

    public override void RunFunction()
    {
        int numero = Inserisci();
        Visualizza(numero);
    }

    private static int Inserisci()
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;

        Console.Write("INSERISCI IL NUMERO IL QUALE VEDERE SE E' NUMERO PRIMO -----> ");
        int numero = Convert.ToInt32(Console.ReadLine());

        return numero;
    }

    private static void Visualizza(int numero)
    {
        const int Vettore = 30000000;
        int[] Numeripr = new int[Vettore];

        Console.WriteLine("");
        int conta = 0;

        for (int i = 1; i <= numero; i++)
        {
            if (numero % i == 0)
            {
                Numeripr[i] = i;
                conta++;
            }
            else
                Numeripr[i] = 0;
        }

        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine($"------------------ I NUMERI DIVISIBILI PER {numero} SONO I SEGUENTI -------------------");
        Console.WriteLine("");

        for (int i = 1; i <= numero; i++)
        {
            if (Numeripr[i] != 0)
                Console.Write($" {Numeripr[i]}");
        }

        Console.WriteLine("");
        Console.WriteLine("");

        Console.ForegroundColor = ConsoleColor.DarkGreen;

        Console.WriteLine("");

        if (conta == 2)
            Console.WriteLine($"\t \t IL NUMERO {numero} è primo");
        else
            Console.WriteLine($"\t \t IL NUMERO {numero} non è primo");

        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("IL NUMERO " + numero + " E' DIVISIBILE PER " + conta + " NUMERI");

    }
}