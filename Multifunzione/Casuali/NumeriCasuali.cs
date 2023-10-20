
using Multifunzione.Matematica;

namespace Multifunzione.Casuali;

internal class NumeriCasuali : BaseFunction
{
    public override string GetMenuTitle() => "Numeri Casuali";
    public override void RunFunction()
    {
        Numeri_Random();
    }

    private static void Numeri_Random()
    {
        Random random = new Random();
        int numeri_generati = 0;

        int numeri = Inserisci_Intervallo();

        for (int i = 0; i < numeri; i++)
        {
            int numeri_start = Inserisci_Primo_numero_Intervallo(i);
            int numeri_end = Inserisci_Ultimo_numero_Intervallo(i);

            Console.WriteLine("");

            if (numeri_start < numeri_end)
                numeri_generati = random.Next(numeri_start, numeri_end + 1);
            else
                numeri_generati = random.Next(numeri_end, numeri_start + 1);

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"{i + 1} numero generato è ---> {numeri_generati}");
        }
    }

    private static int Inserisci_Intervallo()
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;

        Console.Write("inserisci numero numeri casuali da calcolare ---> ");
        int numeri = Convert.ToInt32(Console.ReadLine());

        return numeri;
    }

    private static int Inserisci_Primo_numero_Intervallo(int i)
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("");

        Console.Write($"inserisci primo numero intervallo numeri casuali per il {i + 1} numero ---> ");
        int numeri_start = Convert.ToInt32(Console.ReadLine());

        return numeri_start;
    }
    private static int Inserisci_Ultimo_numero_Intervallo(int i)
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;

        Console.Write($"inserisci primo ultimo intervallo numeri casuali per il {i + 1} numero ---> ");
        int numeri_end = Convert.ToInt32(Console.ReadLine());

        return numeri_end;
    }
}