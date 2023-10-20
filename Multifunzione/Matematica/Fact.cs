namespace Multifunzione.Matematica;

internal class Fact : BaseFunction
{
    public override string GetMenuTitle() => "Fattoriale";

    public override void RunFunction()
    {
        int numero = Inserisci();
        Crea(numero);
    }

    public static int Inserisci()
    {
        int numero = 0;

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write("INSERISCI NUMERO PER FARE IL FATTORILAE ! ----> ");
        numero = Convert.ToInt32(Console.ReadLine());

        return numero;
    }

    public static void Crea(int numero)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        int fact = 1;
        int i = numero;

        if (i == 0)
            fact = 1;

        while (i > 0)
        {
            fact = fact * i;
            i--;
        }

        Console.WriteLine();
        Console.WriteLine($"{numero}! ----> {fact}");
    }
}