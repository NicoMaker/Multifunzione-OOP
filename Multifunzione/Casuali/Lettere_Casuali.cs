
namespace Multifunzione.Casuali;

internal class Lettere_Casuali : BaseFunction
{
    public override string GetMenuTitle() => "Lettera Casuali";

    public override void RunFunction()
    {
        int lettere = Inserisci();
        Visualizza(lettere);
    }

    private static int Inserisci()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;

        Console.Write("Inserisci quante lettere casuali vuoi generare ---> ");
        int lettere = Convert.ToInt32(Console.ReadLine());

        return lettere;
    }

    private static void Visualizza(int lettere)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;

        Console.WriteLine("il numero delle lettere da generare ----> " + lettere);

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("");

        Console.WriteLine("---------- ELENCO LETTERE CASUALI ---------");
        Console.WriteLine("");

        string lettera = "ABCDEFGHIJKLMNOPQRSTUVXYWZ";
        int[] posti_volte_lettra = new int[lettera.Length];

        for (int i = 1; i <= lettere; i++)
        {
            Random generatore = new Random();
            int casuale = generatore.Next(0, lettera.Length);
            posti_volte_lettra[casuale]++;

            Console.Write(lettera[casuale] + " ");
        }

        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.ForegroundColor = ConsoleColor.DarkCyan;

        Console.WriteLine("-------------- LETTERE USCITE QUANTE VOLTE  --------------");
        Console.WriteLine("");

        for (int i = 0; i < lettera.Length; i++)
            Console.WriteLine("lettera " + lettera[i] + " uscita ----> " + posti_volte_lettra[i] + " volte");

        Console.WriteLine("");
    }
}