namespace Multifunzione.Casuali;

internal class NumeriSenzaRipetzioneNVolte : BaseFunction
{
    public override string GetMenuTitle() => "Numeri Senza Ripetizione Per N numeri ";

    public override void RunFunction()
    {
        Console.WriteLine("");

        string sceltanumeri;

        Console.ForegroundColor = ConsoleColor.DarkYellow;

        do
        {
            Console.Write("inserisci se vuoi numeri senza ripetizione ordinati o casuali (ord o cas) ? ---> ");
            sceltanumeri = Console.ReadLine();
            sceltanumeri = sceltanumeri.ToLower();

        } while (sceltanumeri != "ord" && sceltanumeri != "cas");

        Console.WriteLine("");

        if (sceltanumeri == "ord")
            GicoNumeriSenzaRipetizioneordinato.Inserisci();
        else
            GiocoNumeriSenzaRipetizione.Inserisci();

        Console.Clear();
        Console.WriteLine();
    }
}