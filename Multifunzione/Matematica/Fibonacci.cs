namespace Multifunzione.Matematica;
public class Fibonacci : BaseFunction
{
    public override string GetMenuTitle() => "Fibonacci";

    public override void RunFunction()
    {
        FibonacciFunction();
    }

    private static void FibonacciFunction()
    {
        int somma = 0;

        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("");

        Console.Write("INSERISCI NUMERO FINO A CHE NUMERO IL QUALE VUOI CALCOLARE FIBONACCI --> ");
        int numero = Convert.ToInt32(Console.ReadLine());

        List<int> fib = new List<int>()
        {
            1, 1
        };

        for (int i = fib.Count; i < numero; i++)
            fib.Add(fib[i - 1] + fib[i - 2]);

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(" ");
        Console.WriteLine("---------- SUCCESSIONE DI FIBONACCI DEL NUMERO " + numero + " ----------");
        Console.WriteLine(" ");

        foreach (int i in fib)
        {
            Console.Write(i + " ");
            somma += i;
        }

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine($"il numero di Fibonacci del numero {numero} è ----> {somma}");
    }
}