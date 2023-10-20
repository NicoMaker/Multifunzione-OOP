namespace Multifunzione.Matematica;

internal class Numeri_Primi_precedenti : BaseFunction
{
    public override string GetMenuTitle() => "Stampa numeri primi precedenti";

    public override void RunFunction()
    {
        const int Vettore = 30000000;
        int[] numeri_primidivisibili = new int[Vettore];

        CalcolaNumeriPrimiDivisibiliperNumero(numeri_primidivisibili);
    }

    private static void CalcolaNumeriPrimiDivisibiliperNumero(int[] numeri_primidivisibili)
    {
        int numero = InserisciNumeroPrimo();
        int conta = 0, contanumeriprimiprecedenti = 0;


        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("");

        for (int i = 1; i < numero; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                if (i % j == 0)
                    conta++;
            }

            if (conta == 2)
                numeri_primidivisibili[i] = i;
            else
                numeri_primidivisibili[i] = 0;

            conta = 0;
        }

        Console.WriteLine($"----------- I NUMERI PRIMI PRECEDENTI A {numero} SONO I SEGUENTI -----------");
        Console.WriteLine("");

        for (int i = 1; i < numero; i++)
        {
            if (numeri_primidivisibili[i] != 0)
            {
                Console.Write(" " + numeri_primidivisibili[i]);
                contanumeriprimiprecedenti++;
            }
        }

        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("");
        Console.WriteLine("");

        if (contanumeriprimiprecedenti == 0)
            Console.WriteLine("NON CI SONO NUMERI PRIMI PRECEDENTI A " + numero);
        else
            Console.WriteLine($"CI SONO ---> {contanumeriprimiprecedenti} NUMERI PRIMI PRECEDENTI A {numero}");
    }

    private static int InserisciNumeroPrimo()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("");

        Console.Write("INSERISCI NUMERO FINO A CHE NUMERO VUOI VEDERE TUTTI I NUMERI PRIMI PRECEDENTI --> ");
        int numero = Convert.ToInt32(Console.ReadLine());

        return numero;
    }
}
