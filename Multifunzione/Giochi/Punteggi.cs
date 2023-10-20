public class Punteggi
{
    public string Nome()
    {
        Console.Write("inserisci il nome del giocatore ---> ");
        string nome_giocatore = Console.ReadLine();
        Console.WriteLine("");

        return nome_giocatore;
    }
    public void PunteggiPar(int[] par)
    {
        par[0] = 4;
        par[1] = 5;
        par[2] = 4;
        par[3] = 3;
        par[4] = 4;
        par[5] = 5;
        par[6] = 4;
        par[7] = 3;
        par[8] = 4;
        par[9] = 5;
        par[10] = 5;
        par[11] = 4;
        par[12] = 4;
        par[13] = 3;
        par[14] = 4;
        par[15] = 3;
        par[16] = 4;
        par[17] = 4;
    }
    public int Inserisci_Numerobuche(int[] punteggi, string nome_giocatore)
    {
        for (int i = 0; i < punteggi.Length; i++)
        {
            do
            {
                Console.Write($"Inserire quanti lanci ha fatto il giocatore {nome_giocatore} alla {i + 1} buca ---> ");
                punteggi[i] = Convert.ToInt32(Console.ReadLine());
            } while (punteggi[i] == 0 || punteggi[i] <= 0);
        }

        return punteggi.Length;
    }

    public int Calcola_nome_azione_Azionee_Punteggio_Totale(int[] punteggi, int[] par, string[] nome_azione, int[] punteggiobuca, int somma)
    {
        for (int i = 0; i < punteggi.Length; i++)
        {
            if (punteggi[i] - par[i] >= 2)
            {
                somma += 0;
                punteggiobuca[i] = 0;
                nome_azione[i] = "Double bogey";
            }
            else
            {
                if (punteggi[i] - par[i] == 1)
                {
                    somma += 1;
                    punteggiobuca[i] = 1;
                    nome_azione[i] = "Bogey";
                }
                else
                {
                    if (punteggi[i] - par[i] == 0)
                    {
                        somma += 2;
                        punteggiobuca[i] = 2;
                        nome_azione[i] = "Par";
                    }
                    else
                    {
                        if (par[i] - punteggi[i] == 1)
                        {
                            somma += 3;
                            punteggiobuca[i] = 3;
                            nome_azione[i] = "Birdie";
                        }
                        else
                        {
                            if (par[i] - punteggi[i] == 2)
                            {
                                somma += 4;
                                punteggiobuca[i] = 4;
                                nome_azione[i] = "Eagle";
                            }
                            else
                            {
                                if (par[i] - punteggi[i] == 3)
                                {
                                    somma += 5;
                                    punteggiobuca[i] = 5;
                                    nome_azione[i] = "Albatross";
                                }
                                else
                                {
                                    somma += 6;
                                    punteggiobuca[i] = 6;
                                    nome_azione[i] = "Condor";
                                }
                            }
                        }
                    }
                }
            }

        }
        return somma;
    }
}