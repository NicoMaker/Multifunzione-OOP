namespace Multifunzione.Casuali;

internal class NomiSenzaRipetizione :BaseFunction
{
    public override string GetMenuTitle() => "Nomi Senza Ripetizione";
    public override void RunFunction()
    {
        Visualizza();
    }

    private static void Visualizza()
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Inserisci();
    }

    private static void Inserisci()
    {
        Console.Write("INSERISCI QUANTI NUMERI CASUALI VUOI GENERARE CASUALMENTE TUTTI DIVERSI ---> ");
        int numero = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");

        string[] nomi = new string[numero];

        InserisciNomi(nomi, numero);
        Console.WriteLine("");

        Funzione(numero, nomi);
    }

    private static void InserisciNomi(string[] nomi, int numero)
    {
        for (int i = 0; i < numero; i++)
        {
            Console.Write($"inserisci {i + 1} nome ---> ");
            nomi[i] = Console.ReadLine();
        }
    }

    private static void Funzione(int numero, string[] nomi)
    {
        Random numberrandom = new Random();
        int[] numeri = new int[numero];
        bool controllo = false;
        string[] nomirandom = new string[numero];

        for (int i = 0; i < numero; i++)
        {
            numeri[i] = numberrandom.Next(1, numero + 1);

            if (i > 0)
            {
                do
                {
                    controllo = false;

                    for (int j = 0; j < i; j++)
                    {
                        if (numeri[i] == numeri[j])
                        {
                            controllo = true;
                            numeri[i] = numberrandom.Next(1, numero + 1);
                        }
                    }
                } while (controllo);

            }

            nomirandom[i] = nomi[numeri[i] - 1];
        }

        for (int i = 0; i < numero; i++)
        {
            Console.Clear();

            Console.Write($"ci sono {nomi.Length} ---> nomi (");
            for (int k = 0; k < numero; k++)
            {
                if (k == numero - 1)
                    Console.Write($"{nomi[k]})");
                else
                    Console.Write($"{nomi[k]} , ");
            }

            Console.WriteLine("");

            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.WriteLine($"{i + 1} nome è ----> {nomirandom[i]}");

            for (int j = 0; j <= i; j++)
            {
                if (j == numero - 1)
                    Console.Write(nomirandom[j] + " ");
                else
                    Console.Write(nomirandom[j] + " , ");
            }

            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("PREMI UN TASTO PER CONTINUARE ---> ");
            Console.ReadKey();
            Console.WriteLine("");
        }
    }
}
