using System.IO.IsolatedStorage;
using System.Net.Http.Headers;

namespace KyhListLabbar;

public class App
{

    /*
     * Spara alla talen i en array. Loopa igenom arrayen och ta fram det tal som är störst. Skriv tillbaka resultatet på skärmen för användaren
     */
    public void Lab1a()
    {
        var allaTal = new int[4];
        for (int i = 0; i < allaTal.Length; i++)
        {
            Console.WriteLine($"Ange tal {i + 1} av {allaTal.Length}");
            allaTal[i] = Convert.ToInt32(Console.ReadLine());
        }

        var biggestSoFar = allaTal[0];
        foreach(var tal in allaTal)
            if (tal > biggestSoFar)
                biggestSoFar = tal;
        Console.WriteLine($"Biggest was {biggestSoFar}");
    }

    private void Lab1b()
    {
        var allaTal = new List<int>();
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine($"Ange tal {i + 1} av 4");
            allaTal.Add(Convert.ToInt32(Console.ReadLine()));
        }

        var biggestSoFar = allaTal[0];
        foreach (var tal in allaTal)
            if (tal > biggestSoFar)
                biggestSoFar = tal;
        Console.WriteLine($"Biggest was {biggestSoFar}");
    }

    /*
     * Skapa ett program där användaren får upp 

    - fråga om hur många tal som ska matas in
    - du allokerar en så stor en array 
    - mata in alla värden och spara i arrayen

    Loopa igenom arrayen och ta fram det SUMMAN av alla talen. 

    Skriv tillbaka resultatet på skärmen för användaren

     */
    public void LabArray2()
    {
        Console.WriteLine("Hur många tal ska matas in:");
        int antal = Convert.ToInt32(Console.ReadLine());
        var allaTal = new int[antal];

        for (int i = 0; i <= antal; i++)
        {
            Console.WriteLine($"Ange tal {i + 1} av {antal}");
            allaTal[i] = Convert.ToInt32(Console.ReadLine());
        }

        int sum = 0;
        foreach (var tal in allaTal)
            sum += tal;

        Console.WriteLine($"Summan av alla tal blev {sum}");

    }

    /*
     *kriv ett program som räknar antalet strängar som har minst 2 chars SAMT att den första och sista bokstaven är samma

    Ex "Kalle, "aa, "ada, "Nisse"

    Ger 1 i svar
     */
    public void List3()
    {
        var list = new List<string>{"Kalle", "aa", "ada", "Nisse"};

        int antal = 0;
        foreach (var s in list)
        {
            if (s.Length >= 2 && s[0] == s[s.Length - 1])
                antal++;
        }

        Console.WriteLine($"Antal {antal}");
    }

    public void List4()
    {
        var list = new List<int>();
        while (true)
        {
            Console.WriteLine("Mata in tal - skriv N för att avsluta");
            string s = Console.ReadLine();
            if (s.ToUpper() == "N")
                break;
            list.Add(Convert.ToInt32(s));
        }

        int sum = 0;
        int min = list[0];
        int max = list[0];
        foreach (var tal in list)
        {
            sum += tal;
            if (tal < min)
                min = tal;
            if (tal > max)
                max = tal;
        }
        Console.WriteLine($"Du matade in {list.Count} tal");
        Console.WriteLine($"Summan är {sum}");
        Console.WriteLine($"Medelvärdet är {sum/ Convert.ToDouble(list.Count)}");
        Console.WriteLine($"Min {min}  Max{max}");
    }

    /*
     * Skapa en lista av 5 heltal och fyll den med värden.

    Byt ut alla udda tal i listan mot talet 0.

    Skriv sedan efteråt ut innehållet i hela listan till skärmen.
     */
    public void List5()
    {
        var list = new List<int> { 1, 3, 4, 5, 6, 7, 8, 231, 12, 34, 3 };
        bool odd = true;
        for (int i = 0; i < list.Count; i++)
        {
            if (odd)
                list[i] = 0;
            odd = !odd;
        }

        foreach(var tal in list)
            Console.WriteLine(tal);

    }


    /*
     * Skapa en array med sju strängar. Det ska vara "Måndag", "Tisdag" , "Onsdag", "Torsdag", "Fredag", "Lördag", "Söndag"

    Skriv ett program som låter användaren mata in ett TAL motsvarande en veckodag (dvs mellan 1 och 7). Skriv ut dagens namn genom att indexera in i arrayen

    ex Mata in nummer: 1 Dag 1 på veckan är Måndag Mata in nummer: 3 Dag 3 på veckan är Onsdag
     */
    public void LabArray()
    {
        var dagar = new string[] { "Måndag", "Tisdag", "Onsdag", "Torsdag", "Fredag", "Lördag", "Söndag" };
        while (true)
        {
            Console.WriteLine("Mata in nummer:");
            var tal = Convert.ToInt32(Console.ReadLine());
            if (tal < 1 || tal > 7)
            {
                Console.WriteLine("Mellan 1 och 7 tack");
            }
            else
                Console.WriteLine($"Dag {tal} i veckan är {dagar[tal-1]}");

        }
        
    }

    /*
     *Skapa en array som skall innehålla temperaturmätningar. 

    Användaren får först upp en fråga om hur många mätningar som skall registreras. 

    Sedan får denne ange värde för varje mätning. Detta skall vara decimaltal. 

    Skriv sedan ut alla mätningar och avsluta med att ange en max och en medeltemperatur.
     *
     */
    public void Array6()
    {
        Console.WriteLine("Ange antal mätningar:");
        int antal = Convert.ToInt32(Console.ReadLine());

        var matningar = new decimal[antal];

        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine($"Ange mätning {i + 1}:");
            matningar[i] = Convert.ToInt32(Console.ReadLine());
        }

        decimal sum = 0;
        decimal max = matningar[0];
        foreach (var tal in matningar)
        {
            Console.WriteLine($"Mätvärde:{tal}");
            sum += tal;
            if (tal > max)
                max = tal;
        }

        Console.WriteLine($"Medelvärdet är {sum / Convert.ToDecimal(matningar.Length)}");
        Console.WriteLine($"Max{max}");


    }

    public void List7()
    {
        Console.WriteLine("Ange antal mätningar:");
        int antal = Convert.ToInt32(Console.ReadLine());

        var matningar = new List<decimal>();
        var platser = new List<string>();

        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine($"Ange mätning temperatur {i + 1}:");
            matningar.Add(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine($"Plats för mätningen?");
            platser.Add(Console.ReadLine());
        }

        decimal sum = 0;
        decimal max = matningar[0];
        for(int i =0; i < antal; i++)
        {
            decimal tal = matningar[i];
            Console.WriteLine($"Mätvärde:{tal} på {platser[i]}");
            sum += tal;
            if (tal > max)
                max = tal;
        }

        Console.WriteLine($"Medelvärdet är {sum / Convert.ToDecimal(matningar.Count)}");
        Console.WriteLine($"Max{max}");



    }

    public void Run()
    {
        List7();
        Array6();
        List5();
        List4();
        List3();
        Lab1a();
        Lab1b();
        LabArray();
        LabArray2();
    }

}
