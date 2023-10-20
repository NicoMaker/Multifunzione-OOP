namespace Multifunzione.Matematica;

internal class Pitagora : BaseFunction
{
    public override string GetMenuTitle() => "Pitagora";

    public override void RunFunction()
    {
        Scelta();
    }
    private static void Scelta()
    {
        string scelta = " ";
        do
        {
            Console.Clear();
            Console.Write("inserisci che cosa vuoi calcolare i (ipotenusa) c (cateto) : ");
            scelta = Convert.ToString(Console.ReadLine());

            scelta = scelta.ToLower();

        } while (scelta != "c" && scelta != "i");


        switch (scelta)
        {
            case "i":
                Console.Clear();
                Ipotenusa();
                break;
            case "c":
                Console.Clear();
                Cateto();
                break;
        }

        Rifare();
    }

    private static void Rifare()
    {
        string scelta = " ";
        do
        {
            Console.WriteLine(" ");
            Console.Write("inserisci se vuoi rifare s o n : ");
            scelta = Convert.ToString(Console.ReadLine());
            Console.Clear();

            scelta = scelta.ToLower();

        } while (scelta != "s" && scelta != "n");


        switch (scelta)
        {
            case "s":
                Scelta();
                break;
        }
    }

    private static void Ipotenusa()
    {
        Console.Write("inserisci dato primo cateto : ");
        double cateto1 = Convert.ToDouble(Console.ReadLine());


        Console.Write("inserisci dato secondo cateto : ");
        double cateto2 = Convert.ToDouble(Console.ReadLine());

        double ipotenuusa = Math.Sqrt((Math.Pow(cateto1, 2)) + (Math.Pow(cateto2, 2)));

        Console.WriteLine(" ");
        Console.WriteLine($"L'ipotenusa è {ipotenuusa}");
    }

    private static void Cateto()
    {
        Console.Write("inserisci dato ipotenusa : ");
        double ipotenusa = Convert.ToDouble(Console.ReadLine());


        Console.Write("inserisci dato cateto : ");
        double cateto1 = Convert.ToDouble(Console.ReadLine());

        while (cateto1 > ipotenusa)
        {
            Console.Clear();
            Console.Write("riinserisci cateto perchè è più grande dell' ipotenusa : ");
            cateto1 = Convert.ToDouble(Console.ReadLine());
        }

        double cateto2 = Math.Sqrt((Math.Pow(ipotenusa, 2)) - (Math.Pow(cateto1, 2)));

        Console.WriteLine(" ");
        Console.WriteLine($"il cateto da trovare vale {cateto2}");
    }
}