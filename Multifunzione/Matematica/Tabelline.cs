namespace Multifunzione.Matematica;

internal class Tabelline : BaseFunction
{
    public override string GetMenuTitle() => "tabelline";

    public override void RunFunction()
    {
        Crea();
    }

    private static void Crea()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.Write("INSERISCI IL NUMERO IL QUALE VUOI FARE LA TABELLINA ---> ");
        int numero = Convert.ToInt32(Console.ReadLine());

        Console.Write($"DA CHE NUMERO VUOI PARTIRE PER FARE LA TABELLINA DEL {numero} ---> ");
        int start = Convert.ToInt32(Console.ReadLine());

        Console.Write($"FINO A CHE NUMERO VUOI ARRIVARE PER FARE LA TABELLINA DEL {numero} ---> ");
        int end = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("");

        Console.ForegroundColor = ConsoleColor.DarkYellow;

        Console.WriteLine($"------------ LA TABELLINA DEL {numero} E' ------------");
        Console.WriteLine("");


        if (end > start)
        {
            for (int i = start; i <= end; i++)
                Console.WriteLine($"{numero} * {i} = {numero * i}");

        }
        else
        {
            for (int i = end; i <= start; i++)
                Console.WriteLine($"{numero} * {i} = {numero * i}");
        }
    }
}