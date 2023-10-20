namespace Multifunzione;

internal class Pasqua : BaseFunction
{
    public override string GetMenuTitle() => "Calcolo Pasqua";

    public override void RunFunction()
    {
        Crea();
    }

    private static void Crea()
    {
        int anno = 0, anno_corrente = 0, a = 0, b = 0, c = 0, d = 0, e = 0, f = 0;

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("");
        Console.Write("INSERISCI L'ANNO PER CUI CALCOLARE LA DATA DI PASQUA ---> ");
        anno = Convert.ToInt32(Console.ReadLine());

        Console.Write("INSERISCI L'ANNO CORRENTE ---> ");
        anno_corrente = Convert.ToInt32(Console.ReadLine());

        a = anno % 19;
        b = anno % 4;
        c = anno % 7;
        d = 19 * a;
        d += 24;
        d = d % 30;
        e = 2 * b;
        e += 4 * c;
        e += 6 * d;
        e += 5;
        e = e % 7;
        f = d + e;

        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("");

        if (anno < anno_corrente)
        {
            if ((d == 28) && (e == 6))
                Console.WriteLine("IL GIORNO DI PASQUA NELL' ANNO " + anno + " è stato il 18 APRILE");
            else
            {
                if ((d == 29) && (e == 6))
                    Console.WriteLine("IL GIORNO DI PASQUA NELL' ANNO " + anno + " è stato il 19 APRILE");
                else
                {
                    if (f <= 9)
                    {
                        f += 22;
                        Console.WriteLine("IL GIORNO DI PASQUA NELL' ANNO " + anno + " è stato il " + f + " MARZO");
                    }
                    else
                    {
                        f -= 9;
                        Console.WriteLine("IL GIORNO DI PASQUA NELL' ANNO " + anno + " è stato il " + f + " APRILE");
                    }
                }
            }
        }
        else
        if ((d == 28) && (e == 6))
            Console.WriteLine("IL GIORNO DI PASQUA NELL' ANNO " + anno + " sarà il 18 APRILE");
        else
        {
            if ((d == 29) && (e == 6))
                Console.WriteLine("IL GIORNO DI PASQUA NELL' ANNO " + anno + " sarà il 19 APRILE");
            else
            {
                if (f <= 9)
                {
                    f += 22;
                    Console.WriteLine("IL GIORNO DI PASQUA NELL' ANNO " + anno + " sarà il " + f + " MARZO");
                }
                else
                {
                    f -= 9;
                    Console.WriteLine("IL GIORNO DI PASQUA NELL' ANNO " + anno + " sarà il " + f + " APRILE");
                }
            }
        }
    }
}