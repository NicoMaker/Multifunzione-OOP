namespace Multifunzione.Giochi;

public class TiroConArco
{
    public static int Ntiri(string[] nomiTiroConArco, double[] punteggiTiroConArco, int posizione)
    {
        double x = 0, y = 0, totale = 0;
        int lanci = 0, sommat = 0;

        Console.ForegroundColor = ConsoleColor.DarkCyan;

        Console.Write("INSERISCI QUANTE GARE VUOI FARE ---> ");
        int numero_gare = Convert.ToInt32(Console.ReadLine());

        for (int i = 1, j = 1; i <= numero_gare; i++, j++)
        {
            Console.WriteLine("");
            Console.Write($"INSERISCI QUANTI LANCI VUOI FARE PER IL {i} TENTATIVO ---> ");
            lanci = Convert.ToInt16(Console.ReadLine());

            if (lanci > sommat)
                sommat = lanci;

            Console.WriteLine("");

            if (i >= 10)
                totale = Precisione(x, y, totale, lanci, j); // richiamo il metodo tira 
            else
                totale = Tira(x, y, totale, lanci, j); // richiamo il metodo tira 

            Console.Write("PREMI UN TASTO PER CONTINUARE ---> ");
            Console.ReadKey();
            Console.Clear();
        }

        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine($"IL PUNTEGGIO MASSIMO E' ---> {totale} SU {sommat} LANCI CON UN MASSIMO POSSIBILE DI {10 * sommat}");
        Console.WriteLine("");


        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.Write($"VUOI INSERIRE IL PUNTEGGIO MIGLORE {totale} IN UN UTENTE SCRIVI SI ---> ");
        string scelta_utente = Console.ReadLine();
        scelta_utente = scelta_utente.ToLower();


        if (scelta_utente == "si")
        {
            for (int i = posizione + 1; i <= posizione + 1; i++)
            {
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("SCEGLI IL NOME DELL'UTENTE ---> ");
                nomiTiroConArco[i] = Console.ReadLine();
                punteggiTiroConArco[i] = totale;
            }
            posizione++;
        }

        return posizione;
    }

    public static int VentiTiri(string[] nomiTiroConArco, double[] punteggiTiroConArco, int posizione)
    {
        double x = 0, y = 0, totale = 0;
        int lanci = 0, sommat = 0;

        Console.ForegroundColor = ConsoleColor.DarkCyan;

        int numero_gare = 20;

        for (int i = 1, j = 1; i <= numero_gare; i++, j++)
        {
            Console.WriteLine("");
            Console.Write($"INSERISCI QUANTI LANCI VUOI FARE PER IL {i} TTENTATIVO ---> ");
            lanci = Convert.ToInt16(Console.ReadLine());

            if (lanci > sommat)
                sommat = lanci;

            Console.WriteLine("");

            if (i >= 10)
                totale = Precisione(x, y, totale, lanci, j); // richiamo il metodo tira 
            else
                totale = Tira(x, y, totale, lanci, j); // richiamo il metodo tira 

            Console.Write("PREMI UN TASTO PER CONTINUARE ---> ");
            Console.ReadKey();
            Console.Clear();
        }

        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine($"IL PUNTEGGIO MASSIMO E' ---> {totale} SU {sommat} LANCI CON UN MASSIMO POSSIBILE DI {10 * sommat}");
        Console.WriteLine("");

        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.Write($"VUOI INSERIRE IL PUNTEGGIO MIGLORE {totale} IN UN UTENTE SCRIVI SI ---> ");
        string scelta_utente = Console.ReadLine();
        scelta_utente = scelta_utente.ToLower();

        if (scelta_utente == "si")
        {
            for (int i = posizione + 1; i <= posizione + 1; i++)
            {
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("SCEGLI IL NOME DELL'UTENTE ---> ");
                nomiTiroConArco[i] = Console.ReadLine();
                punteggiTiroConArco[i] = totale;
            }
            posizione++;
        }

        return posizione;
    }

    public static void Visualizza(string[] nomiTiroConArco, double[] punteggiTiroConArco, int posizione)
    {
        double pmiglore = 0;
        string nmiglore = "";

        Console.ForegroundColor = ConsoleColor.DarkGreen;

        Console.WriteLine("---------------------------------------------- I GIOCATORI SONO I SEGUENTI CON IL SEGUENTE PUNTEGGIO ----------------------------------------------");
        Console.WriteLine("");

        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        for (int i = 1; i <= posizione; i++)
        {
            Console.WriteLine($"IL {i} GIOCATORE SI CHAMA {nomiTiroConArco[i]} E HA TOTALIZZATO ---> {punteggiTiroConArco[i]} PUNTI");

            if (punteggiTiroConArco[i] >= pmiglore)
            {
                pmiglore = punteggiTiroConArco[i];
                nmiglore = nomiTiroConArco[i];
            }
        }

        if (posizione > 0)
        {
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"IL MIGLORE E' {nmiglore} CON ---> {pmiglore} PUNTI");
        }
    }

    private static double Tira(double x, double y, double totale, int lanci, int j) //funzione tira 
    {
        double impatto = 0, punteggio = 0, punteggio_tot = 0;
        Random generatore = new Random(); // vreazione metodo casuale generatore 

        Console.ForegroundColor = ConsoleColor.White;

        for (int i = 1; i <= lanci; i++)      //indica di fare 3 volte i lanci 
        {
            punteggio = 0;

            x = generatore.NextDouble(); //genera casualmente numero tra 0 e 1 assegno ad x 
            x = x * 40;                  // moltiplico numero per 40 assegno ad x

            y = generatore.NextDouble();  //genera casualmente numero tra 0 e 1 assegno ad x 
            y = y * 40;                   // moltiplico numero per 40 assegno ad x

            impatto = (x * x) + (y * y);   //faccio diventare radice quadrata moltiplico x e y 
            impatto = Math.Sqrt(impatto); // faccio la radice quadrata della variabile radice quadrata 


            Console.WriteLine("");
            Console.WriteLine($"{i} TENTATIVO NUMERO ---> {impatto}");


            if (impatto >= 30)  //se distanza maggiore di 30
            {
                punteggio += 0; //sommo punteggio
                punteggio_tot += 0;
                Console.WriteLine("SEI FUORI PUNTEGGIO");
            }
            else
            {
                if (impatto >= 20) // se distanza maggiore di 20
                {
                    punteggio += 1; //sommo punteggio
                    punteggio_tot += 1;
                    Console.WriteLine($"HAI OTTENUTO {punteggio} punti");
                }
                else
                {
                    if (impatto >= 10)   // se distanza maggiore di 10
                    {
                        punteggio += 5;  //sommo punteggio
                        punteggio_tot += 5;
                        Console.WriteLine($"HAI OTTENUTO {punteggio} punti");
                    }
                    else
                    {
                        if (impatto >= 0)
                        {
                            punteggio += 10;   //sommo punteggio
                            punteggio_tot += 10;
                            Console.WriteLine($"HAI OTTENUTO {punteggio} punti");
                        }
                    }
                }

                if (punteggio_tot > totale) //se punteggioe è maggiore di tptale sostituiscilo
                    totale = punteggio_tot;
            }

        }

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("");
        Console.WriteLine($"LA SOMMA DEI PUNTEGGI DEL {j} TENTATIVO E' ---> {punteggio_tot} / {10 * lanci}");
        Console.WriteLine("");

        return totale; // ritorna totale 
    }


    private static double Precisione(double x, double y, double totale, int lanci, int j) //funzione tira 
    {
        double impatto = 0, punteggio = 0, punteggio_tot = 0;
        Random generatore = new Random(); // vreazione metodo casuale generatore 

        Console.ForegroundColor = ConsoleColor.White;

        for (int i = 1; i <= lanci; i++)      //indica di fare 3 volte i lanci 
        {
            punteggio = 0;

            x = generatore.NextDouble(); //genera casualmente numero tra 0 e 1 assegno ad x 
            x = x * 35;                  // moltiplico numero per 40 assegno ad x

            y = generatore.NextDouble();  //genera casualmente numero tra 0 e 1 assegno ad x 
            y = y * 35;                   // moltiplico numero per 40 assegno ad x

            impatto = (x * x) + (y * y);   //faccio diventare radice quadrata moltiplico x e y 
            impatto = Math.Sqrt(impatto); // faccio la radice quadrata della variabile radice quadrata 


            Console.WriteLine("");
            Console.WriteLine($"{i} TENTATIVO NUMERO ---> {impatto}");


            if (impatto >= 30)  //se distanza maggiore di 30
            {
                punteggio += 0; //sommo punteggio
                punteggio_tot += 0;
                Console.WriteLine("SEI FUORI PUNTEGGIO");
            }
            else
            {
                if (impatto >= 20) // se distanza maggiore di 20
                {
                    punteggio += 1; //sommo punteggio
                    punteggio_tot += 1;
                    Console.WriteLine($"HAI OTTENUTO {punteggio} punti");
                }
                else
                {
                    if (impatto >= 10)   // se distanza maggiore di 10
                    {
                        punteggio += 5;  //sommo punteggio
                        punteggio_tot += 5;
                        Console.WriteLine($"HAI OTTENUTO {punteggio} punti");
                    }
                    else
                    {
                        if (impatto >= 0)
                        {
                            punteggio += 10;   //sommo punteggio
                            punteggio_tot += 10;
                            Console.WriteLine($"HAI OTTENUTO {punteggio} punti");
                        }
                    }
                }

                if (punteggio_tot > totale) //se punteggioe è maggiore di tptale sostituiscilo
                    totale = punteggio_tot;
            }

        }

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("");
        Console.WriteLine($"LA SOMMA DEI PUNTEGGI DEL {j} TENTATIVO E' ---> {punteggio_tot} / {10 * lanci}");
        Console.WriteLine("");

        return totale; // ritorna totale 
    }

    public static void ContollaUtente(string[] nomiTiroConArco, double[] punteggiTiroConArco, int posizione)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        int conta = 0;
        double migloreu = 0, miglore = 0;

        Console.Write("INSERISCI IL NOME DELL'UTENTE CHE VUOI VEDERE QUANTI PUNTI HA ---> ");
        string nome_da_controllare = Console.ReadLine();

        Console.WriteLine("");

        Console.ForegroundColor = ConsoleColor.DarkCyan;

        for (int i = 1; i <= posizione; i++)
        {
            if (nome_da_controllare == nomiTiroConArco[i])
            {
                Console.WriteLine($"IL PUNTEGGIO DI {nome_da_controllare} E' ---> {punteggiTiroConArco[i]}");
                conta++;

                migloreu = punteggiTiroConArco[i];
            }

            if (punteggiTiroConArco[i] > miglore)
                miglore = punteggiTiroConArco[i];
        }

        if (conta <= 0)
        {
            Console.WriteLine("NON ESISTE L'UTENTE --> " + nome_da_controllare);
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("");
            Console.WriteLine("---------- GLI UTENTI SONO I SEGUENTI ----------");
            Console.WriteLine("");

            for (int i = 1; i <= posizione; i++)
                Console.WriteLine($"{i} UTENTE NOME {nomiTiroConArco[i]} --> PUNTEGGIO {punteggiTiroConArco[i]}");
        }
        else
        {
            Console.WriteLine("");

            if (migloreu >= miglore)
                Console.WriteLine($"L'UTENTE {nome_da_controllare} HA IL PUNTEGGIO MIGLORE");
            else
                Console.WriteLine($"L'UTENTE {nome_da_controllare} NON HA IL PUNTEGGIO MIGLORE");
        }
    }

    public static int AzzeraVettore(int posizione)
    {
        posizione = 0;
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("VETTORE AZZERATO");

        return posizione;
    }
}