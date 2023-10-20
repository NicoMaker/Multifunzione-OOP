namespace Multifunzione.crittografia;

internal class CriptazioneOpposta : BaseFunction
{
    public override string GetMenuTitle() => "Crittografia alfabeto opposto";

    public override void RunFunction()
    {
        Console.Clear();
        Console.WriteLine("");
        string frasecripto = Inserisci_frase();

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("");
        string encriptedcripto = Cripta(frasecripto);
        Console.WriteLine($"il messaggio {frasecripto} è stato criptato con ---> {encriptedcripto}");

        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write("VUOI VEDERE LA DECRIPTAZIONE ? scrivi SI ---> ");
        string Visualizzacripto = Console.ReadLine();
        Visualizzacripto = Visualizzacripto.ToLower();
        Console.WriteLine("");

        if (Visualizzacripto == "si")
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            string decriptedcripto = Decripta(encriptedcripto);
            Console.WriteLine($"il messaggio {encriptedcripto} è stato decriptato con ---> {decriptedcripto}");
        }
    }

    private static string Inserisci_frase()
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write("INSERISCE FRASE DA CRIPTARE ---> ");
        string frase = Console.ReadLine();

        return frase;
    }

    private static string Cripta(string frase)
    {
        string nuova_frase = "";

        for (int j = 0; j <= frase.Length - 1; j++)
        {
            switch (frase[j])
            {
                case 'a':
                    nuova_frase += "z";
                    break;

                case 'b':
                    nuova_frase += "y";
                    break;

                case 'c':
                    nuova_frase += "x";
                    break;

                case 'd':
                    nuova_frase += "w";
                    break;

                case 'e':
                    nuova_frase += "v";
                    break;

                case 'f':
                    nuova_frase += "u";
                    break;

                case 'g':
                    nuova_frase += "t";
                    break;

                case 'h':
                    nuova_frase += "s";
                    break;

                case 'i':
                    nuova_frase += "r";
                    break;

                case 'j':
                    nuova_frase += "q";
                    break;

                case 'k':
                    nuova_frase += "p";
                    break;

                case 'l':
                    nuova_frase += "o";
                    break;

                case 'm':
                    nuova_frase += "n";
                    break;

                case 'n':
                    nuova_frase += "m";
                    break;
                case 'o':
                    nuova_frase += "l";
                    break;
                case 'p':
                    nuova_frase += "k";
                    break;
                case 'q':
                    nuova_frase += "j";
                    break;
                case 'r':
                    nuova_frase += "i";
                    break;
                case 's':
                    nuova_frase += "h";
                    break;
                case 't':
                    nuova_frase += "g";
                    break;
                case 'u':
                    nuova_frase += "f";
                    break;
                case 'v':
                    nuova_frase += "e";
                    break;
                case 'w':
                    nuova_frase += "d";
                    break;
                case 'x':
                    nuova_frase += "c";
                    break;
                case 'y':
                    nuova_frase += "b";
                    break;
                case 'z':
                    nuova_frase += "a";
                    break;

                default:
                    nuova_frase += frase[j];
                    break;
            }
        }
        return nuova_frase;
    }

    private static string Decripta(string encripted)
    {
        string nuova_frase = "";

        for (int j = 0; j <= encripted.Length - 1; j++)
        {
            switch (encripted[j])
            {
                case 'a':
                    nuova_frase += "z";
                    break;

                case 'b':
                    nuova_frase += "y";
                    break;

                case 'c':
                    nuova_frase += "x";
                    break;

                case 'd':
                    nuova_frase += "w";
                    break;

                case 'e':
                    nuova_frase += "v";
                    break;

                case 'f':
                    nuova_frase += "u";
                    break;

                case 'g':
                    nuova_frase += "t";
                    break;

                case 'h':
                    nuova_frase += "s";
                    break;

                case 'i':
                    nuova_frase += "r";
                    break;

                case 'j':
                    nuova_frase += "q";
                    break;

                case 'k':
                    nuova_frase += "p";
                    break;

                case 'l':
                    nuova_frase += "o";
                    break;

                case 'm':
                    nuova_frase += "n";
                    break;

                case 'n':
                    nuova_frase += "m";
                    break;
                case 'o':
                    nuova_frase += "l";
                    break;
                case 'p':
                    nuova_frase += "k";
                    break;
                case 'q':
                    nuova_frase += "j";
                    break;
                case 'r':
                    nuova_frase += "i";
                    break;
                case 's':
                    nuova_frase += "h";
                    break;
                case 't':
                    nuova_frase += "g";
                    break;
                case 'u':
                    nuova_frase += "f";
                    break;
                case 'v':
                    nuova_frase += "e";
                    break;
                case 'w':
                    nuova_frase += "d";
                    break;
                case 'x':
                    nuova_frase += "c";
                    break;
                case 'y':
                    nuova_frase += "b";
                    break;
                case 'z':
                    nuova_frase += "a";
                    break;

                default:
                    nuova_frase += encripted[j];
                    break;
            }
        }
        return nuova_frase;
    }

}