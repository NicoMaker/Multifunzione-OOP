namespace Multifunzione.crittografia;

internal class Cesare :BaseFunction
{
    public override string GetMenuTitle() => "Crittografia codeice di cesare";

    public override void RunFunction()
    {
        Console.WriteLine("");
        string frase = Inserisci_frase();

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("");
        string encripted = Cripta(frase);
        Console.WriteLine($"il messaggio {frase} è stato criptato con ---> {encripted}");

        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write("VUOI VEDERE LA DECRIPTAZIONE ? scrivi SI ---> ");
        string Visualizza = Console.ReadLine();
        Visualizza = Visualizza.ToLower();
        Console.WriteLine("");

        if (Visualizza == "si")
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            string decripted = Decripta(encripted);
            Console.WriteLine($"il messaggio {encripted} è stato decriptato con ---> {decripted}");
        }
    }

    public static string Inserisci_frase()
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
                    nuova_frase += "d";
                    break;

                case 'b':
                    nuova_frase += "e";
                    break;

                case 'c':
                    nuova_frase += "f";
                    break;

                case 'd':
                    nuova_frase += "g";
                    break;

                case 'e':
                    nuova_frase += "h";
                    break;

                case 'f':
                    nuova_frase += "i";
                    break;

                case 'g':
                    nuova_frase += "j";
                    break;

                case 'h':
                    nuova_frase += "k";
                    break;

                case 'i':
                    nuova_frase += "l";
                    break;

                case 'j':
                    nuova_frase += "m";
                    break;

                case 'k':
                    nuova_frase += "n";
                    break;

                case 'l':
                    nuova_frase += "o";
                    break;

                case 'm':
                    nuova_frase += "p";
                    break;

                case 'n':
                    nuova_frase += "q";
                    break;
                case 'o':
                    nuova_frase += "r";
                    break;
                case 'p':
                    nuova_frase += "s";
                    break;
                case 'q':
                    nuova_frase += "t";
                    break;
                case 'r':
                    nuova_frase += "u";
                    break;
                case 's':
                    nuova_frase += "v";
                    break;
                case 't':
                    nuova_frase += "w";
                    break;
                case 'u':
                    nuova_frase += "x";
                    break;
                case 'v':
                    nuova_frase += "y";
                    break;
                case 'w':
                    nuova_frase += "z";
                    break;
                case 'x':
                    nuova_frase += "a";
                    break;
                case 'y':
                    nuova_frase += "b";
                    break;
                case 'z':
                    nuova_frase += "c";
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
                    nuova_frase += "x";
                    break;

                case 'b':
                    nuova_frase += "y";
                    break;

                case 'c':
                    nuova_frase += "z";
                    break;

                case 'd':
                    nuova_frase += "a";
                    break;

                case 'e':
                    nuova_frase += "b";
                    break;

                case 'f':
                    nuova_frase += "c";
                    break;

                case 'g':
                    nuova_frase += "d";
                    break;

                case 'h':
                    nuova_frase += "e";
                    break;

                case 'i':
                    nuova_frase += "f";
                    break;

                case 'j':
                    nuova_frase += "g";
                    break;

                case 'k':
                    nuova_frase += "h";
                    break;

                case 'l':
                    nuova_frase += "i";
                    break;

                case 'm':
                    nuova_frase += "j";
                    break;

                case 'n':
                    nuova_frase += "k";
                    break;
                case 'o':
                    nuova_frase += "l";
                    break;
                case 'p':
                    nuova_frase += "m";
                    break;
                case 'q':
                    nuova_frase += "n";
                    break;
                case 'r':
                    nuova_frase += "o";
                    break;
                case 's':
                    nuova_frase += "p";
                    break;
                case 't':
                    nuova_frase += "q";
                    break;
                case 'u':
                    nuova_frase += "r";
                    break;
                case 'v':
                    nuova_frase += "s";
                    break;
                case 'w':
                    nuova_frase += "t";
                    break;
                case 'x':
                    nuova_frase += "u";
                    break;
                case 'y':
                    nuova_frase += "v";
                    break;
                case 'z':
                    nuova_frase += "x";
                    break;

                default:
                    nuova_frase += encripted[j];
                    break;
            }
        }

        return nuova_frase;
    }
}