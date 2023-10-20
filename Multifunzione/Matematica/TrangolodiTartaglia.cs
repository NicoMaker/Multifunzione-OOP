namespace Multifunzione.Matematica;

internal class TrangolodiTartaglia : BaseFunction
{
    public override string GetMenuTitle() => "Triangolo di Tartaglia";

    public override void RunFunction()
    {
        Triangolo_di_Tartaglia();
    }

    private static void Triangolo_di_Tartaglia()
    {
        const int numero_max = 32;

        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("");

        int righe = 0;
        int[,] Tartaglia = new int[numero_max, numero_max];

        do
        {
            Console.Write("inserisci numero righe per il triangolo di tartaglia ---> ");
            righe = Convert.ToInt32(Console.ReadLine());

        } while ((righe >= numero_max) || (righe < 1));

        Console.WriteLine("");


        // prima righa
        Tartaglia[0, 0] = 1;

        for (int j = 1; j < numero_max; j++)
            Tartaglia[0, j] = 0;

        //calcolo le altre righe		
        for (int i = 1; i < numero_max; i++)
        {
            Tartaglia[i, 0] = 1;

            for (int j = 1; j < righe; j++)
                Tartaglia[i, j] = Tartaglia[i - 1, j - 1] + Tartaglia[i - 1, j];
        }

        Console.ForegroundColor = ConsoleColor.DarkRed;
        //visualizzazione triangolo di tartaglia

        for (int i = 0; i < righe; i++)
        {
            Console.Write($"{i + 1} riga ---> ");

            for (int j = 0; j <= i; j++)
                Console.Write(Tartaglia[i, j] + " ");

            Console.WriteLine("");
        }

        Console.WriteLine("");
    }
}