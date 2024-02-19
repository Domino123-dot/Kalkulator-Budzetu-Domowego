

static void switchCase()
{

    Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════╗");
    Console.WriteLine("                                             MENU                                         ");
    Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════╝");
    Console.WriteLine("1.Obliczanie Budżetu domowego");
    Console.WriteLine("2.Instrukcja");
    Console.WriteLine("Wprowadź dane:");
    var answer = Console.ReadLine();

    switch (answer)
    {
        case "1":
            Console.WriteLine("test");
            break;
        case "2":
            Tutorial();

            break;

        default:
            Console.WriteLine("Źle wybrana opcja!");
            switchCase();

            break;
    }

};

static void exit()
{
    Console.Clear();
    Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
    Console.WriteLine("                                                       Do widzenia!                                               ");
    Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
    Environment.Exit(0);
}
static void Tutorial()
{

    Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
    Console.WriteLine("                                            NAJWAŻNIEJSZE ZAGADNIENIA                                             ");
    Console.WriteLine(" 1.Aplikacja ma za zadanie pomóc w obliczaniu budżetu domowego za pomocą wprowadzonych przez uzytkownika danych");
    Console.WriteLine(" 2.Wprowadzane dane powinny mieć postać tylko i wyłącznie liczb (bez liter, znaków specjalnych");
    Console.WriteLine(" 3.Przychód - suma kwoty zarabianej przez wszystkich członków gospodarstwa domowego NETTO");
    Console.WriteLine(" 4.Wydatki - wszelakiego rodzaju wydatki na gospodarstwo domowe (rachunki, zakupy, abonamenty, media)");
    Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
    Console.WriteLine("1. Powrót do menu głównego");
    Console.WriteLine("2.Wyjście");
    Console.WriteLine("Wprowadź opcje: ");
    var answerTutorial = Console.ReadLine();

    if (answerTutorial == "1")
    {
        switchCase();
    }

    else if (answerTutorial == "2")
    {
        exit();
    }

    else
    {
        Console.WriteLine("Błąd!");
        Tutorial();
    }
}







switchCase();







Console.ReadKey();