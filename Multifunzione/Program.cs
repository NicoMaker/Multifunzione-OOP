using Multifunzione;
using Multifunzione.Matematica;
using Multifunzione.Casuali;
using Multifunzione.crittografia;
using Multifunzione.Segni_Zodiacali;
using Multifunzione.Giochi;
using Multifunzione.Password;
using  Multifunzione.Giochi.Tombola;
using static System.Runtime.InteropServices.JavaScript.JSType;

BaseFunction[] functions = new BaseFunction[]
{
    new Monete(), new PasswordClass(), new Ahmes(), new Lettere_Casuali(),new Dadi(), new Pasqua(),new Collatz(),new Fact(), new Euclide(),
    new NumeriComplessi(),new Numeri_Primi(), new Radici(),new Esponenziali(),new Logaritmi(),new ValoriAssoluti(),new Seno(), new Coseno(),new Tangente(),
    new Arcoseno(),new ArcoCoseno(),new ArcoTangente(), new Polinomi(), new NumeriPari(), new numeri_dispari(),new PrintTabellinan(),
    new Numeri_Primi_precedenti(), new Fibonacci(),new CoonversioneBinario_Deciamle(),new ConversioneDecimale_binario(),new TrangolodiTartaglia(), new Pitagora(),
    new Sasso_carta_forbice(),new Tabelline(),new Radici_metodo_Babilonese(), new Cesare(),new CriptazioneOpposta(),new TiroConArcoClass(),new CriptoChiave(), 
    new Zodiacali(),new Zodiacali_casuali(), new PartitaCalcio(),new NumeriSenzaRipetizione(), new TombolaClass(), new NumeriSenzaRipetzioneNVolte(), 
    new NumeriCasuali(),new Golf(), new NomiSenzaRipetizione(),
};

bool running = true;

while(running)
{
    Console.WriteLine("");
    for (int i = 0; i <functions.Length; i++)
    {
        Console.WriteLine($"{i}.{functions[i].GetMenuTitle()}");
    }

    Console.WriteLine("premi un tasto per uscire");

    int sceltanumero = Convert.ToInt16(Console.ReadLine());

    if (sceltanumero < 0 || sceltanumero >= functions.Length)
    {
        running = false;
        continue;
    }

    functions[sceltanumero].RunFunction();
}

Console.WriteLine("fine programma");