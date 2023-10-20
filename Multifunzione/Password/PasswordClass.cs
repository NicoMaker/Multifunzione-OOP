namespace Multifunzione.Password;

internal class PasswordClass : BaseFunction
{
    public override string GetMenuTitle() => "Password";

    public override void RunFunction()
    {
        int s = 0, numerop = 0, numeri = 0, posizione = 0;

        const int Vettore = 30000000;
        string[] utenti = new string[Vettore];
        string[] password = new string[Vettore];

        do
        {

            s = InformazioniPassword(s);

            switch(s)
            {
                case 1:
                    Console.Clear();
                    numerop = PasswordDati.InserisciNumeroPassword(utenti);
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("password da generare --> " + numerop);
                    Console.WriteLine("");
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("");
                    PasswordDati.Crea(numerop, utenti, password);
                    Console.WriteLine("");
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("");
                    PasswordDati.Visualizza(numerop, utenti, password);
                    Console.WriteLine("");
                    break;

                case 4:
                    Console.Clear();
                    Console.WriteLine("");
                    numerop = PasswordDati.InserisciALtriUtenti(numerop, utenti, password);
                    Console.WriteLine("");
                    break;

                case 5:
                    Console.Clear();
                    Console.WriteLine("");
                    PasswordDati.ControllaPassword(numerop, utenti, password);
                    Console.WriteLine("");
                    break;

                case 6:
                    Console.Clear();
                    Console.WriteLine("");
                    PasswordDati.ControllaNomeUtente(numerop, utenti, password);
                    Console.WriteLine("");
                    break;
            }

            Console.WriteLine(" ");
            Console.Write("PREMI UN TASTO PER CONTINUARE ---> ");
            Console.ReadKey();
            Console.WriteLine(" ");
            Console.Clear();


        } while (s != 0 && s <= 6);
    }

    private static int InformazioniPassword(int s)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("1. INSERISCI QUANTE PASSWORD GENERARE");
        Console.WriteLine("2. GENERA PASSWORD");
        Console.WriteLine("3. VISULIZZA ELENCO PASSWORD UTENTI");
        Console.WriteLine("4. INSERISCI ALTRI UTENTI");
        Console.WriteLine("5. VISULIZZA INSERENDO LA PASSWORD DI CHE UTENTE E' SE NO NON E' DI NESSUNO");
        Console.WriteLine("6. VISUALIZZA LA PASSWORD DELL'UTENTE SE NON ESISTE DI NON ESISTE");

        Console.Write("INSERISCI SCELTA  ---> ");
        s = Convert.ToInt32(Console.ReadLine());

        return s;
    }

}