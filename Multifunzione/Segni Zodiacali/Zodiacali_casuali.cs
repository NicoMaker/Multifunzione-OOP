namespace Multifunzione.Segni_Zodiacali;

internal class Zodiacali_casuali : BaseFunction
{
    public override string GetMenuTitle() => "Calcolo Segni Zodiacali Casuali";

    public override void RunFunction()
    {
        Inserisci();
    }

    private static void Inserisci()
    {
        string[] mesi = new string[]
        {
            "gennaio","febbraio","marzo", "aprile", "maggio","giugno","luglio","agosto","settembre","ottobre","novembre","dicembre"
        };

        string[] mesi31 = new string[]
        {
           "gennaio","marzo","maggio","luglio","agosto","ottobre","dicembre"
        };

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Write("Inserisci per quanti uenti vuoi calcolare il segno zodiacale ---> ");
        int numero = Convert.ToInt32(Console.ReadLine());

        string[] nomi = new string[numero];
        string[] mese = new string[numero];
        int[] giorno = new int[numero];
        string[] segno_zodiacale = new string[numero];

        Console.ForegroundColor = ConsoleColor.White;

        for (int i = 0; i < numero; i++)
        {
            Console.WriteLine("");
            Console.Write($"Inserisci nome {i + 1} Utente ---> ");
            nomi[i] = Console.ReadLine();

            mese[i] = InserimentoMese(nomi[i], mesi);
            giorno[i] = InserimentoGiorno(mese[i], nomi[i], mesi31);
            segno_zodiacale[i] = Oroscopo(giorno[i], mese[i]);
        }


        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine();

        for (int i = 0; i < numero; i++)
            Console.WriteLine($"il segno zodiacale di {nomi[i]} nato il {giorno[i]} {mese[i]} è ----> {segno_zodiacale[i]}");
    }

    private static string InserimentoMese(string nome, string[] mesi)
    {
        string mese = "";
        bool controllo = false;
        Random genera = new Random();
        int numero = 0;

        do
        {
            numero = genera.Next(0, 13);
            mese = mesi[numero];

            Console.Write($"mese casuale di {nome} ---> ");
            Console.WriteLine(mese);

            for (int i = 0; i < mesi.Length; i++)
            {
                if (mese == mesi[i])
                {
                    controllo = true;
                    break;
                }
            }
        } while (!controllo);

        return mese;
    }

    private static int InserimentoGiorno(string mese, string nome, string[] mesi31)
    {
        int giorno = 0;
        bool controllo = false;
        Random genera = new Random();

        for (int i = 0; i < mesi31.Length; i++)
        {
            if (mese == mesi31[i])
            {
                giorno = genera.Next(1, 32);
                Console.Write($"giorno casuale di {nome} ---> ");
                Console.WriteLine(giorno);
                controllo = true;

                break;
            }
        }

        if (!controllo)
        {
            if (mese == "febbraio")
            {
                giorno = genera.Next(1, 30);
                Console.Write($"giorno casuale di {nome} ---> ");
                Console.WriteLine(giorno);
            }
            else
            {
                giorno = genera.Next(1, 31);
                Console.Write($"giorno casuale di {nome} ---> ");
                Console.WriteLine(giorno);
            }
        }

        return giorno;
    }

    private static string Oroscopo(int giorno, string mese)
    {
        string segno_zodiacale = "";

        if ((mese == "marzo" && giorno >= 21) || (mese == "aprile" && giorno <= 19))
            segno_zodiacale += "ARIETE";
        else
        {
            if ((mese == "aprile" && giorno >= 20) || (mese == "maggio" && giorno <= 20))
                segno_zodiacale += "TORO";
            else
            {
                if ((mese == "giugno" && giorno <= 21) || (mese == "maggio" && giorno >= 21))
                    segno_zodiacale += "GEMELLI";
                else
                {
                    if ((mese == "giugno" && giorno >= 22) || (mese == "luglio" && giorno <= 22))
                        segno_zodiacale += "CANCRO";
                    else
                    {
                        if ((mese == "agosto" && giorno <= 23) || (mese == "luglio" && giorno >= 23))
                            segno_zodiacale += "LEONE";
                        else
                        {
                            if ((mese == "agosto" && giorno >= 24) || (mese == "settembre" && giorno <= 22))
                                segno_zodiacale += "VERGINE";
                            else
                            {
                                if ((mese == "ottobre" && giorno <= 22) || (mese == "settembre" && giorno >= 23))
                                    segno_zodiacale += "BILANCIA";
                                else
                                {
                                    if ((mese == "ottobre" && giorno >= 23) || (mese == "novembre" && giorno <= 23))
                                        segno_zodiacale += "SCORPIONE";
                                    else
                                    {
                                        if ((mese == "dicembre" && giorno <= 21) || (mese == "novembre" && giorno >= 23))
                                            segno_zodiacale += "SAGITARIO";
                                        else
                                        {
                                            if ((mese == "dicembre" && giorno >= 22) || (mese == "gennaio" && giorno <= 20))
                                                segno_zodiacale += "CAPRICORNO";
                                            else
                                            {
                                                if ((mese == "febbraio" && giorno <= 19) || (mese == "gennaio" && giorno >= 21))
                                                    segno_zodiacale += "ACQUARIO";
                                                else
                                                    segno_zodiacale += "PESCI";
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        segno_zodiacale = segno_zodiacale.ToLower();
        return segno_zodiacale;
    }
}