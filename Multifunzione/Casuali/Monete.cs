namespace Multifunzione.Casuali;

internal class Monete : BaseFunction
{
    public override string GetMenuTitle() => "lancia Monete";

    public override void RunFunction()
    {
        int lanci = Iserisci();
        Visualizza(lanci);
    }
    private static int Iserisci()
    {
        int lanci2 = 0;

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("");
        Console.Write("inserisci quante monete vuoi lanciare ---> ");
        string lanci = Console.ReadLine();
        lanci2 = Convert.ToInt32(lanci);

        return lanci2;
    }

    private static void Visualizza(int lanci2)
    {

        int testa = 0, croce = 0, casuale_testa_croce = 0;

        Console.ForegroundColor = ConsoleColor.DarkYellow;

        Console.WriteLine("");
        Console.WriteLine("il numero delle monete è ---> " + lanci2);
        Console.WriteLine("");

        Console.ForegroundColor = ConsoleColor.White;
        for (int tentativi = 0; tentativi < lanci2; tentativi++)
        {
            Random generatore = new Random();
            casuale_testa_croce = generatore.Next(0, 10);

            Console.Write(casuale_testa_croce + " ");

            if (casuale_testa_croce % 2 == 0)
                testa++;
            else
                croce++;
        }

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("--------------- I RISULTATI SONO : ---------------");
        Console.WriteLine("");
        Console.WriteLine("\t \t TESTA -----> {0}", testa);
        Console.WriteLine("\t \t CROCE -----> {0}", croce);
        Console.WriteLine("");

        Console.WriteLine("");

        if (testa > croce)
            Console.WriteLine("\t \t HA VINTO TESTA");
        else
            Console.WriteLine(croce > testa ? "\t \t HA VINTO CROCE" : "\t NON HA VINTO NESSUNO PERCHE' SONO UGUALI");


        Console.WriteLine("");
    }
}