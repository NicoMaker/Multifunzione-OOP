namespace Multifunzione.Matematica;

internal class PrintTabellinan : BaseFunction
{
    public override string GetMenuTitle() => "STAMPA TABELLINA FINO A POSIZIONE N";

    public override void RunFunction()
    {
        StampaNnumeriDivisibilipperN();
    }

    private static void StampaNnumeriDivisibilipperN()
    {

        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("");

        Console.Write("INSERISCI NUMERO DI VALORI DA VEDERE --> ");
        int numero = Convert.ToInt32(Console.ReadLine());

        Console.Write("INSERISCI IL NUMERO IL QUALE VUOI VEDERE I DIVISIBILI ---> ");
        int divisibili = Convert.ToInt32(Console.ReadLine());

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("");

        Console.WriteLine($"------------------ I NUMERI DIVISIBILI DI {divisibili} PER {numero} VOLTE SONO I SEGUENTI ------------------");
        Console.WriteLine("");

        for (int i = 0, j = 0; j < numero; i++)
        {
            if (i % divisibili == 0)
            {
                Console.Write(" " + i);
                j++;
            }
        }

        Console.WriteLine("");
        Console.WriteLine("");
    }
}