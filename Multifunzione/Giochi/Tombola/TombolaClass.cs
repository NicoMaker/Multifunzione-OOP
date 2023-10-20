using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multifunzione.Giochi.Tombola;

internal class TombolaClass : BaseFunction
{
    public override string GetMenuTitle() => "Tombola";

    public override void RunFunction()
    {
        Console.Clear();
        Console.WriteLine("");

        string inseriscit;

        Console.ForegroundColor = ConsoleColor.DarkYellow;

        do
        {
            Console.Write("inserisci se vuoi tombola tabellone ordinato o casuale (tab o cas) ? ---> ");
            inseriscit = Console.ReadLine();
            inseriscit = inseriscit.ToLower();

        } while (inseriscit != "tab" && inseriscit != "cas");

        Console.WriteLine("");

        if (inseriscit == "tab")
            GiocoTombolaOrdinata.Inserisci();
        else
            GiocoTombola.Inserisci();

        Console.Clear();
        Console.WriteLine();
    }
}