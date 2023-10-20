namespace Multifunzione.Giochi;

internal class Sasso_carta_forbice : BaseFunction
{
    public override string GetMenuTitle() => "Sasso carta Forbice";

    public override void RunFunction()
    {
        Gioco();
    }

    private static void Gioco()
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write("VUOI VEDERE LE REGOLE (SI O NO) ? ----> ");
        string visualizza_regole = Console.ReadLine();
        visualizza_regole = visualizza_regole.ToLower();

        if (visualizza_regole == "si")
            Regole();

        Console.WriteLine("");

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write("INSERISCI NOME GIOCATORE 1 ---> ");
        string nome_giocatore1 = Console.ReadLine();

        Console.Write("INSERISCI NOME GIOCATORE 2 ---> ");
        string nome_giocatore2 = Console.ReadLine();

        int scelta_1 = Genera_1();
        int scelta_2 = Genera_2();

        string risultato_1 = Generacaso_1(scelta_1);
        string risultato_2 = Generacaso_2(scelta_2);

        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.DarkCyan;

        Console.WriteLine($"IL RISULTATO DI {nome_giocatore1} E' ----> {risultato_1}");
        Console.WriteLine($"IL RISULTATO DI {nome_giocatore2} E' ----> {risultato_2}");

        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.DarkYellow;

        while (risultato_1 == risultato_2)
        {
            Console.WriteLine("NON HA VINTO NESSUNO");

            scelta_1 = Genera_1();
            scelta_2 = Genera_2();

            risultato_1 = Generacaso_1(scelta_1);
            risultato_2 = Generacaso_2(scelta_2);

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("");
            Console.WriteLine($"IL RISULTATO DI {nome_giocatore1} E' ----> {risultato_1}");
            Console.WriteLine($"IL RISULTATO DI {nome_giocatore2} E' ----> {risultato_2}");
            Console.WriteLine("");

        }

        Console.ForegroundColor = ConsoleColor.DarkYellow;

        if (risultato_1 == "SASSO" && risultato_2 == "FORBICI")
            Console.WriteLine($"HA VINTO --> {nome_giocatore1}");
        else
            if (risultato_1 == "CARTA" && risultato_2 == "SASSO")
            Console.WriteLine($"HA VINTO --> {nome_giocatore1}");
        else
            if (risultato_1 == "FORBICI" && risultato_2 == "CARTA")
            Console.WriteLine($"HA VINTO --> {nome_giocatore1}");
        else
            if (risultato_2 == "SASSO" && risultato_1 == "FORBICI")
            Console.WriteLine($"HA VINTO --> {nome_giocatore2}");
        else
            if (risultato_2 == "CARTA" && risultato_1 == "SASSO")
            Console.WriteLine($"HA VINTO --> {nome_giocatore2}");
        else
            Console.WriteLine($"HA VINTO --> {nome_giocatore2}");
    }

    private static int Genera_1()
    {
        Random generatore = new Random();
        int scelta_1 = generatore.Next(0, 3);

        return scelta_1;
    }

    private static int Genera_2()
    {
        Random generatore = new Random();
        int scelta_2 = generatore.Next(0, 3);

        return scelta_2;
    }

    private static string Generacaso_1(int scelta_1)
    {
        string risultato_1 = "";
        switch (scelta_1)
        {
            case 0:
                risultato_1 = "SASSO";
                break;
            case 1:
                risultato_1 = "CARTA";
                break;
            case 2:
                risultato_1 = "FORBICI";
                break;
        }

        return risultato_1;
    }

    private static string Generacaso_2(int scelta_2)
    {
        string risultato_2 = "";

        switch (scelta_2)
        {
            case 0:
                risultato_2 = "SASSO";
                break;
            case 1:
                risultato_2 = "CARTA";
                break;
            case 2:
                risultato_2 = "FORBICI";
                break;
        }

        return risultato_2;
    }

    private static void Regole()
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("");

        Console.WriteLine("------------------------ REGOLE -----------------------");
        Console.WriteLine("");
        Console.WriteLine("SASSO VINCE SU FORBICI MA PERDE CON CARTA");
        Console.WriteLine("CARTA VINCE SU SASSO MA PERDE CON FORBICI");
        Console.WriteLine("FORICI VIINCE SU CARTA MA PERDE CON SASSO");
        Console.WriteLine("SE SONO UGUALI RIULTATO NON HA VINTO NESSUNO");
    }
}