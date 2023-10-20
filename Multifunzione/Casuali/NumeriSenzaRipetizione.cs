namespace Multifunzione.Casuali;

internal class NumeriSenzaRipetizione : BaseFunction
{
    public override string GetMenuTitle() => "Numeri Senza Ripetizione";

    public override void RunFunction()
    {
        Visualizza();
    }

    private static void Visualizza()
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        int numero = Inserisci();
        Funzione(numero);
    }

    private static int Inserisci()
    {
        Console.Write("INSERISCI QUANTI NUMERI CASUALI VUOI GENERARE CASUALMENTE TUTTI DIVERSI ---> ");
        int numero = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");

        return numero;
    }

    private static void Funzione(int numero)
    {
        Random numberrandom = new Random();
        int[] numeri = new int[numero];
        bool controllo = false;

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
        }

        for (int i = 0; i < numero; i++)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Numero scelto ---> " + numero);
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            if (i == numero - 1)
            {
                Console.WriteLine("");
                Console.WriteLine($"{i + 1} numero generato è ----> {numeri[i]}");

                for (int j = 0; j <= i; j++)
                    Console.Write(numeri[j] + " ");

                Console.WriteLine("");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine($"{i + 1} numero generato è ----> {numeri[i]}");

                for (int j = 0; j <= i; j++)
                    Console.Write(numeri[j] + " ");

                Console.WriteLine("");
                Console.WriteLine("");

                Console.Write("PREMI UN TASTO PER CONTINUARE ---> ");
                Console.ReadKey();
            }
        }
    }
}