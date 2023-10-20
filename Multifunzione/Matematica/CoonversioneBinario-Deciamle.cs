namespace Multifunzione.Matematica;

internal class CoonversioneBinario_Deciamle : BaseFunction
{
    public override string GetMenuTitle() => "Conversione Binario Decimale";

    public override void RunFunction()
    {
        Binario_Decimale();
    }

    private static void Binario_Decimale()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        string numero = "";
        double numero_decimale = 0;
        int conta = 0;

        Console.WriteLine("");

        do
        {
            conta = 0;
            Console.Write("inserisci un numero in binario da convertire in decimale ---> ");
            numero = Console.ReadLine();

            for (int i = 0; i <= numero.Length - 1; i++)
            {
                if (numero[i] == '0' || numero[i] == '1')
                    conta += 0;
                else
                    conta++;
            }

            if (conta > 0)
                Console.WriteLine("numero non valido");

        } while (conta > 0);

        for (int i = numero.Length - 1, j = 0; i >= 0; i--, j++)
        {
            if (numero[i] == '1')
                numero_decimale += Math.Pow(2, j);
            else
                numero_decimale += 0;
        }


        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine($"numero binario ---> {numero}, numero decimale ---> {numero_decimale}");
        Console.WriteLine("");
    }
}