namespace Multifunzione.Giochi;

internal class TiroConArcoClass : BaseFunction
{
    public override string GetMenuTitle() => "Tiro Con Arco";

    public override void RunFunction()
    {
        int s = 0, posizione = 0;
        const int Vettore = 30000000;

        string[] nomiTiroConArco = new string[Vettore];
        double[] punteggiTiroConArco = new double[Vettore];


        do
        {
            s = InformazioniGaraTiroConarco(s);

            switch (s)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("");
                    posizione = TiroConArco.Ntiri(nomiTiroConArco, punteggiTiroConArco, posizione);
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("");
                    posizione = TiroConArco.VentiTiri(nomiTiroConArco, punteggiTiroConArco, posizione);
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("");
                    TiroConArco.Visualizza(nomiTiroConArco, punteggiTiroConArco, posizione);
                    break;

                case 4:
                    Console.Clear();
                    Console.WriteLine("");
                    TiroConArco.ContollaUtente(nomiTiroConArco, punteggiTiroConArco, posizione);
                    break;

                case 5:
                    Console.Clear();
                    Console.WriteLine("");
                    posizione = TiroConArco.AzzeraVettore(posizione);
                    break;
            }

            Console.WriteLine(" ");
            Console.Write("PREMI UN TASTO PER CONTINUARE ---> ");
            Console.ReadKey();
            Console.WriteLine(" ");
            Console.Clear();


        } while (s != 0 && s <= 5);
    }

    private static int InformazioniGaraTiroConarco(int s)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("1. INSERISCI QUANTI LANCI VUOI TIRARE A OGNI TENTATIVO CON N TENTATIVI DECISI DA TASTIERA E VISULAIZZA TENTATIVO MIGLORE E SE INSERIRLO NEL VETTORE UTENTI");
        Console.WriteLine("2. INSERISCI QUANTI LANCI VUOI TIRARE A OGNI TENTATIVO CON 20 TENTATIVI VISULIZZA IL TENTATIVO MIGLORE E VISULIZZA SE INSERIRLO NEL VETTORE UTENTI");
        Console.WriteLine("3. VISUALIZZA VETTORE UTENTI E MIGLORE PUNTEGGIO CON IL SUO NOME");
        Console.WriteLine("4. INSERISCI NOME E DICE QUANTI PUNTI HA SE NO NON ESISTE UTENTE  E STAMPA ALRI UTENTI SE ESISTE UTENTE DIMMI SE E' IL MIGLORE");
        Console.WriteLine("5. AZZERA VETTORE");

        Console.Write("INSERISCI SCELTA  ---> ");
        s = Convert.ToInt32(Console.ReadLine());

        return s;
    }
}