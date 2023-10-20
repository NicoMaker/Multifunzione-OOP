namespace Multifunzione.Casuali;

internal class Dadi : BaseFunction
{
    public override string GetMenuTitle() => "Lancio Dadi";

    public override void RunFunction()
    {
        int lanci = Inserisci();
        int risultato = Visualizza(lanci);

        Console.WriteLine("il risultato è " + risultato);
    }

    private static int Inserisci()
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;

        Console.Write("Inserisci quanti dadi vuoi lanciare ---> ");
        int lanci = Convert.ToInt32(Console.ReadLine());

        return lanci;
    }

    private static int Visualizza(int lanci)
    {
        int numero = 0;
        int[] valori_numeri_dadi = new int[7];

        Console.ForegroundColor = ConsoleColor.DarkGreen;

        for (int i = 1; i <= lanci; i++)
        {
            Random generatore = new Random();
            int numero_generato = generatore.Next(1, 7);
            valori_numeri_dadi[numero_generato]++;
            numero += numero_generato;
            Console.Write(numero_generato + " ");
        }
        Console.WriteLine("");
        Console.WriteLine("");

        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("-------------- NUMERI USCITI QUANTE VOLTE  --------------");
        Console.WriteLine("");

        for (int i = 1; i <= 6; i++)
            Console.WriteLine("numero " + i + " ----> uscito " + valori_numeri_dadi[i] + " volte");

        Console.WriteLine(" ");
        return numero;
    }
}