public class Numeri_ComplessiDati
{
    public static int InserisciNumeri(float[] Parte_reale, float[] Parte_immaginaria)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write("INSERISCI QUANTI NUMERI COMPLESSI VUOI AGGIUNGERE --> ");
        int numeri = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.DarkGreen;

        for (int i = 1; i <= numeri; i++)
        {
            Console.Write($"Inserisci {i} numero reale --> ");
            Parte_reale[i] = float.Parse(Console.ReadLine());
            Console.Write($"Inserisci {i} numero immaginario --> ");
            Parte_immaginaria[i] = float.Parse(Console.ReadLine());
        }

        return numeri;
    }

    public static void Visualizza(int numeri, float[] Parte_reale, float[] Parte_immaginaria)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;

        Console.WriteLine("----------- I NUMERI COMPLESSI INSERITI SONO -----------");
        Console.WriteLine("");

        for (int i = 1; i <= numeri; i++)
            Console.WriteLine($"{i} NUMERO COMPLESSO Z INSERITO E' ----> {Parte_reale[i]} + ({Parte_immaginaria[i]} i) ");
    }

    public static void Somma(int numeri, float[] Parte_reale, float[] Parte_immaginaria)
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;

        float sommar = 0, sommai = 0;

        for (int i = 1; i <= numeri; i++)
        {
            sommar += Parte_reale[i];
            sommai += Parte_immaginaria[i];
        }

        Console.WriteLine($"IL RISULTATO FINALE DELLA SOMMA DI {numeri} NUMERI COMPLESSI E' ---> {sommar} + ({sommai} i)");
    }

    public static void Sottrazione(int numeri, float[] Parte_reale, float[] Parte_immaginaria)
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;

        float sottrazioner = 0, sottrazionei = 0;

        for (int i = 1; i <= numeri; i++)
        {
            if (i == 1)
            {
                sottrazioner += Parte_reale[i];
                sottrazionei += Parte_immaginaria[i];
            }
            else
            {
                sottrazioner -= Parte_reale[i];
                sottrazionei -= Parte_immaginaria[i];
            }
        }

        Console.WriteLine($"IL RISULTATO FINALE DELLA SOTTRAZIONE DI {numeri} NUMERI COMPLESSI E' ---> {sottrazioner} - ({sottrazionei} i)");
    }
}