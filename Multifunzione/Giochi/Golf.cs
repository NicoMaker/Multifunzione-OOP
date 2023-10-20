namespace Multifunzione.Giochi;

internal class Golf : BaseFunction
{
    public override string GetMenuTitle() => "Golf";
    public override void RunFunction()
    {
        Inserisci();
    }
    private static void Inserisci()
    {
        Punteggi Giocatore = new Punteggi();

        int[] punteggi = new int[18];
        int[] par = new int[18];
        int[] punteggiobuca = new int[18];
        string[] nome_azione = new string[18];
        int somma = 0;

        Console.ForegroundColor = ConsoleColor.DarkCyan;
        string nome_giocatore = Giocatore.Nome();
        Console.WriteLine("");

        Giocatore.PunteggiPar(par);

        Console.ForegroundColor = ConsoleColor.DarkRed;
        int lunghezza = Giocatore.Inserisci_Numerobuche(punteggi, nome_giocatore);
        somma = Giocatore.Calcola_nome_azione_Azionee_Punteggio_Totale(punteggi, par, nome_azione, punteggiobuca, somma);
        Console.WriteLine("");

        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("");
        for (int i = 0; i < punteggi.Length; i++)
            Console.WriteLine($"il giocatore {nome_giocatore} alla {i + 1} buca gli sono serviti = {punteggi[i]} tentativi");

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("");
        for (int i = 0; i < punteggi.Length; i++)
            Console.WriteLine($"il giocatore {nome_giocatore} alla {i + 1} buca ha totalizzato {punteggiobuca[i]} punti ---> {nome_azione[i]}");

        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("");
        Console.WriteLine($"il punteggio totale del giocatore {nome_giocatore} è ---> {somma}");
    }
}