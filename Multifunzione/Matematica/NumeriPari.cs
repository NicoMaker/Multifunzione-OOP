namespace Multifunzione.Matematica;

internal class NumeriPari : BaseFunction 
{
    public override string GetMenuTitle() => "Stampa numeri pari";

    public override void RunFunction()
    {
        StampaPari();
    }

    private static void StampaPari()
    {
        int numero = 0, contap = 0;

        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("");

        do
        {

            Console.Write("INSERISCI NUMERO PARI FINO A CHE NUMERO STAMPARE TUTTI I PARI --> ");
            numero = Convert.ToInt32(Console.ReadLine());

        } while (numero % 2 != 0);


        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("");

        Console.WriteLine($"------------------ I NUMERI PARI FINO A {numero} SONO I SEGUENTI -----------------");
        Console.WriteLine("");

        for (int i = 0; i <= numero; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(" " + i);
                contap++;
            }
        }

        Console.WriteLine("");
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine($" PER IL NUMERO {numero} CI SONO ---> {contap} NUMERI PARI");
    }
}