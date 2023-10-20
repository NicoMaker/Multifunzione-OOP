namespace Multifunzione.Matematica;

internal class Radici_metodo_Babilonese : BaseFunction
{
    public override string GetMenuTitle() => "Radici Metodo Babilonese ";
    public override void RunFunction()
    {
        Console.WriteLine("");
        double numeroB = Inserisci_numero();
        double epsion = Inserisci_errore();
        Visualizza(numeroB, epsion);
        Console.WriteLine("");
    }

    private static double Inserisci_numero()
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Write("INSERISCI NUMERO PER CALCOLARE LA RADICE ---> ");
        double numero = Convert.ToInt32(Console.ReadLine());

        return numero;
    }

    private static double Inserisci_errore()
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Write("INSERISCI LA PRECISIONE DELL' ERRORE OVVVERO QUANTE CIFRE DOPO LA VIRGOLA ---> ");
        double epsilon = Convert.ToDouble(Console.ReadLine());

        return epsilon;
    }

    private static void Visualizza(double numero, double epsilon)
    {
        int passaggio = 0;
        double X0 = 1, errore = 0;

        X0 = Math.Pow(10, epsilon);
        errore = Math.Abs((X0 * X0) - numero);

        while (errore >= epsilon)
        {
            errore = Math.Abs((X0 * X0) - numero);
            X0 = 1 / 2 * (X0 + (numero / X0));
            passaggio++;
        }

        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.DarkGreen;

        Console.WriteLine($"LA RADICE APPROSSIMATA DI {numero} E' ----> {X0}");
        Console.WriteLine($"ALGORITMO FATTO IN ---> {passaggio} PASSAGGI");
    }
}