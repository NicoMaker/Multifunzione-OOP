using Multifunzione.Password;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Multifunzione.Matematica;

internal class NumeriComplessi : BaseFunction
{
    public override string GetMenuTitle() => "Numeri Conplessi";

    public override void RunFunction()
    {
        int s = 0, numeri = 0;

        const int Vettore = 30000000;
        float[] Parte_reale = new float[Vettore];
        float[] Parte_immaginaria = new float[Vettore];

        do
        {

            s = InformazioniNumeri_complessi(s);

            switch (s)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("");
                    numeri = Numeri_ComplessiDati.InserisciNumeri(Parte_reale, Parte_immaginaria);
                    Console.WriteLine("");
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("");
                    Numeri_ComplessiDati.Visualizza(numeri, Parte_reale, Parte_immaginaria);
                    Console.WriteLine("");
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("");
                    Numeri_ComplessiDati.Somma(numeri, Parte_reale, Parte_immaginaria);
                    Console.WriteLine("");
                    break;

                case 4:
                    Console.Clear();
                    Console.WriteLine("");
                    Numeri_ComplessiDati.Sottrazione(numeri, Parte_reale, Parte_immaginaria);
                    Console.WriteLine("");
                    break;
            }

            Console.WriteLine(" ");
            Console.Write("PREMI UN TASTO PER CONTINUARE ---> ");
            Console.ReadKey();
            Console.WriteLine(" ");
            Console.Clear();


        } while (s != 0 && s <= 4);
    }

    private static int InformazioniNumeri_complessi(int s)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("1. INSERISCI NUMERI COMPLESSI");
        Console.WriteLine("2. VISUALIZZA NUMERI");
        Console.WriteLine("3. SOMMA NUMERI COMPLESSI");
        Console.WriteLine("4. SOTTRAZIONE NUMERI COMPLESSI");

        Console.Write("INSERISCI SCELTA  ---> ");
        s = Convert.ToInt32(Console.ReadLine());

        return s;
    }
}
