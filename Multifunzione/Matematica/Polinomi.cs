
namespace Multifunzione.Matematica;

internal class Polinomi : BaseFunction
{
    public override string GetMenuTitle() => "Polinomi fino al 4 grado";
    public override void RunFunction()
    {
        Visualizza();
    }

    private static void Visualizza()
    {
        int grado = 0, primo_grado = 0, secondo_grado = 0;

        Console.ForegroundColor = ConsoleColor.DarkYellow;

        Console.Write("INSERISCI IL PRIMO NUMERO  ---> ");
        float primo_numero = float.Parse(Console.ReadLine());
        Console.Write("INSERISCI PRIMA LETTERA  ---> ");
        string primo_lettera = Console.ReadLine();
        do
        {
            Console.Write("INSERISCI 1 GRADO MAGGIORE DI 0 ---> ");
            primo_grado = Convert.ToInt16(Console.ReadLine());
        }
        while (primo_grado <= 0);

        Console.Write("INSERISCI IL SECONDO NUMERO  ---> ");
        float secondo_numero = float.Parse(Console.ReadLine());
        Console.Write("INSERISCI SECONDA LETTERA  ---> ");
        string secondo_lettera = Console.ReadLine();
        do
        {
            Console.Write("INSERISCI 2 GRADO ---> ");
            secondo_grado = Convert.ToInt16(Console.ReadLine());
        } while (secondo_grado <= 0);

        do
        {
            Console.Write("INSERISCI GRADO DA 0 A 4 ---> ");
            grado = Convert.ToInt16(Console.ReadLine());
        }
        while (grado > 4 || grado < 0);

        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.DarkGreen;

        switch (grado)
        {
            case 0:
                Console.WriteLine("IL POLINIO E' UGUALE A ---> 1");
                break;
            case 1:
                Console.WriteLine("");
                Console.Write($"IL POLINOMIO E' UGUALE A ---> ({primo_numero} {primo_lettera}^{primo_grado})");
                Console.Write($" + ({secondo_numero} {secondo_lettera}^{secondo_grado})");
                Console.WriteLine("");
                break;
            case 2:
                Console.WriteLine("");
                Console.Write($"IL POLINOMIO E' UGUALE A ---> ({primo_numero * primo_numero} {primo_lettera} ^ {primo_grado * 2})");
                Console.Write($" + ({2 * primo_numero * secondo_numero} {primo_lettera} ^{primo_grado}{secondo_lettera} ^{secondo_grado})");
                Console.Write($" + ({secondo_numero * secondo_numero} {secondo_lettera}^{secondo_grado * 2} )");
                Console.WriteLine("");
                break;
            case 3:
                Console.WriteLine("");
                Console.Write($"IL POLINOMIO E' UGUALE A ---> ({primo_numero * primo_numero * primo_numero} {primo_lettera}^ {primo_grado + 3})");
                Console.Write($" + ({3 * primo_numero * secondo_numero} {primo_lettera}^{primo_grado + 2} {secondo_lettera}^{secondo_grado + 1})");
                Console.Write($" + ({3 * primo_numero * secondo_numero} {secondo_lettera}^{secondo_grado + 2} {primo_lettera}^{primo_grado + 1})");
                Console.Write($" + ({secondo_numero * secondo_numero * secondo_numero} {secondo_lettera}^{secondo_grado * 3})");
                Console.WriteLine("");
                break;

            case 4:
                Console.WriteLine("");
                Console.Write($"IL POLINOMIO E' UGUALE A ---> ({primo_numero * primo_numero * primo_numero * primo_numero} {primo_lettera}^{primo_grado * 4})");
                Console.Write($" + ({4 * primo_numero * secondo_numero} {primo_lettera}^{primo_grado + 3} {secondo_lettera}^{secondo_grado + 2})");
                Console.Write($" + ({6 * primo_numero * secondo_numero} {primo_lettera}^{primo_grado + 2} {secondo_lettera}^{secondo_grado + 2})");
                Console.Write($" + ({4 * primo_numero * secondo_numero} {primo_lettera}^{primo_grado} {secondo_lettera}^{secondo_grado + 3})");
                Console.Write($" + ({secondo_numero * secondo_numero * secondo_numero * secondo_numero} {secondo_lettera}^{secondo_grado * 4})");
                Console.WriteLine("");
                break;
        }

    }
}