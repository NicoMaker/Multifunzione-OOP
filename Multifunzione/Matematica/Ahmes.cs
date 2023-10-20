namespace Multifunzione.Matematica; 

internal class Ahmes :BaseFunction
{
    public override string GetMenuTitle() => "Ahmes";

    public override void RunFunction()
    {
        int numero1 = Inserisci1();
        int numero2 = Inserisci2();
        int risultato = Visualizza(numero1, numero2);

        Console.WriteLine("il risultato è " + risultato);
    }

    private static int Inserisci1()
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("");
        Console.Write("INSERISCI IL PRIMO NUMERO -->  ");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        return numero1;

    }

    private static int Inserisci2()
    {
        Console.Write("INSERISCI IL SECONDO NUMERO -->  ");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        return numero2;
    }

    private static int Visualizza(int numero1, int numero2)
    {
        int resto = 0, passaggio = 0;
        Console.WriteLine("");

        Console.ForegroundColor = ConsoleColor.DarkRed;

        Console.WriteLine("il primo numero è --> " + numero1);
        Console.WriteLine("il secondo numero è --> " + numero2);

        Console.WriteLine("");

        Console.ForegroundColor = ConsoleColor.DarkYellow;

        while (numero1 > 0)
        {
            passaggio++;

            if (numero1 % 2 == 0)
            {
                Console.WriteLine($"{passaggio} passaggio visto che {numero1} è pari allora  --> ({numero1} / 2) * (2 * {numero2}) ");
                numero1 = numero1 / 2;
                numero2 = numero2 * 2;
            }
            else
            {

                Console.WriteLine(resto == 0 ? $"{passaggio} passaggio visto che {numero1} è dispari allora --> ({numero1} - 1) * ({numero2} + {numero2})" : $"{passaggio} passaggio visto che {numero1} è dispari allora --> ({numero1} - 1) * ({numero2} + {resto})");

                numero1--;
                resto += numero2;
            }
        }

        int risultato = resto;

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("");
        Console.WriteLine($"il calcolo è stato fatto in --> {passaggio} passaggi");

        return risultato;
    }
}