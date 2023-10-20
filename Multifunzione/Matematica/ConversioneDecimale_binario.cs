namespace Multifunzione.Matematica;

internal class ConversioneDecimale_binario : BaseFunction
{
    public override string GetMenuTitle() => "Conversione Decimale Binario";

    public override void RunFunction()
    {
        Decimale_Binario();
    }

    private static void Decimale_Binario()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;

        Console.WriteLine("");

        Console.Write("inserisci un numero in decimale da convertire in binario ---> ");
        int numero = Convert.ToInt32(Console.ReadLine());
        int numero_dec = numero;


        string numero_binario_valori = " ";

        while (numero != 0)
        {
            if (numero % 2 == 1)
            {
                numero_binario_valori += '1';
                numero = (numero - 1) / 2;
            }
            else
            {
                numero_binario_valori += '0'; ;
                numero = numero / 2;
            }
        }

        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write($"numero decimale ---> {numero_dec}, numero binario ---> ");

        for (int i = numero_binario_valori.Length - 1; i >= 0; i--)
            Console.Write(numero_binario_valori[i]);

        Console.WriteLine("");
        Console.WriteLine("");
    }
}