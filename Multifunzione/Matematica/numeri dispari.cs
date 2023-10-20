namespace Multifunzione.Matematica;

internal class numeri_dispari : BaseFunction
{
    public override string GetMenuTitle() => "Stampa numeri dispari";

    public override void RunFunction()
    {
       StampaDispari();
    }

    private  static void StampaDispari()
    {
        int numero = 0, contad = 0;

        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("");

        do
        {

            Console.Write("INSERISCI NUMERO DISPARI FINO A CHE NUMERO STAMPARE TUTTI I DISPARI --> ");
            numero = Convert.ToInt32(Console.ReadLine());

        } while (numero % 2 != 1);


        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("");

        Console.WriteLine($"------------------ I NUMERI DISPARI FINO {numero} SONO I SEGUENTI ------------------");
        Console.WriteLine("");

        for (int i = 0; i <= numero; i++)
        {
            if (i % 2 == 1)
            {
                Console.Write(" " + i);
                contad++;
            }
        }

        Console.WriteLine("");
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine($" PER IL NUMERO {numero} CI SONO ---> {contad} NUMERI PARI");
    }
}