namespace Multifunzione.Giochi;
internal class PartitaCalcio : BaseFunction
{
    public override string GetMenuTitle() => "Partita Calcio";

    public override void RunFunction()
    {
        Inserisci();
    }

    private static void Inserisci()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;

        int s = 0, gol1 = 0, gol2 = 0;
        List<string> punteggi = new List<string>();
        Random Genera = new Random();

        Console.Write("inserisci nome prima squadra --> ");
        string nome_prima_squadra = Console.ReadLine();
        Console.Write("inserisci nome seconda squadra --> ");
        string nome_seconda_squadra = Console.ReadLine();

        Console.WriteLine("");

        punteggi.Add(gol1 + " - " + gol2);

        do
        {
            s = Menu(Genera);

            switch (s)
            {
                case 1:
                    Console.WriteLine("");
                    gol1 = GolCasa(punteggi, gol1, gol2, nome_prima_squadra);
                    break;
                case 2:
                    Console.WriteLine("");
                    gol2 = GolTrasferta(punteggi, gol1, gol2, nome_seconda_squadra);
                    break;
                case 9:
                    Console.WriteLine("");
                    Risultato(punteggi, gol1, gol2, nome_prima_squadra, nome_seconda_squadra);
                    Console.WriteLine("");
                    break;

                default:
                    do
                    {
                        Console.Write("scelta casuale ---> ");
                        s = Genera.Next(1, 10);
                        Console.WriteLine(s);

                    } while (s != 1 && s != 2 && s != 9);

                    switch (s)
                    {
                        case 1:
                            Console.WriteLine("");
                            gol1 = GolCasa(punteggi, gol1, gol2, nome_prima_squadra);
                            break;
                        case 2:
                            Console.WriteLine("");
                            gol2 = GolTrasferta(punteggi, gol1, gol2, nome_seconda_squadra);
                            break;
                        case 9:
                            Console.WriteLine("");
                            Risultato(punteggi, gol1, gol2, nome_prima_squadra, nome_seconda_squadra);
                            Console.WriteLine("");
                            break;
                    }
                    break;
            }
            Console.WriteLine("");
            Console.Write("premi un tasto per continuare ---> ");
            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("");

        } while (s != 9);
    }
    private static int Menu(Random Genera)
    {
        int s;
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("1. gol prima squdra");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("2. gol seconda squadra");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("9. termina partita");
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.Write("scelta casuale ---> ");
        s = Genera.Next(1, 10);
        Console.WriteLine(s);

        return s;
    }

    private static int GolCasa(List<string> punteggi, int gol1, int gol2, string nome_prima_squadra)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;

        for (int i = 0; i < punteggi.Count; i++)
            Console.WriteLine(punteggi[i]);

        Console.WriteLine(" ");
        gol1++;
        Console.WriteLine("ha segnato " + nome_prima_squadra);
        Console.WriteLine($"risultato parziale {gol1} - {gol2}");
        punteggi.Add(gol1 + " - " + gol2);

        return gol1;
    }

    private static int GolTrasferta(List<string> punteggi, int gol1, int gol2, string nome_seconda_squadra)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        for (int i = 0; i < punteggi.Count; i++)
            Console.WriteLine(punteggi[i]);

        Console.WriteLine("");
        gol2++;
        Console.WriteLine("ha segnato " + nome_seconda_squadra);
        Console.WriteLine($"risultato parziale {gol1} - {gol2}");
        punteggi.Add(gol1 + " - " + gol2);

        return gol2;
    }

    private static void Risultato(List<string> punteggi, int gol1, int gol2, string nome_prima_squadra, string nome_seconda_squadra)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;

        for (int i = 0; i < punteggi.Count; i++)
            Console.WriteLine(punteggi[i]);

        Console.WriteLine("");

        if (gol1 > gol2)
            Console.WriteLine("ha vinto " + nome_prima_squadra);
        else
        {
            if (gol2 > gol1)
                Console.WriteLine("ha vinto " + nome_seconda_squadra);
            else
                Console.WriteLine("non ha vinto nessuno");
        }

        Console.WriteLine("");
    }
}