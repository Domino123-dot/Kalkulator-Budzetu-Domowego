

static void main()
{

    Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════╗");
    Console.WriteLine("                                             MENU                                         ");
    Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════╝");
    Console.WriteLine("1.Obliczanie Budżetu domowego");
    Console.WriteLine("2.Instrukcja");
    Console.WriteLine("3.Wyjście z programu");
    Console.WriteLine("Wprowadź dane:");
    var answer = Console.ReadLine();

    switch (answer)
    {
        case "1":
            calculateIncomeMenu();
            break;
        case "2":
            Tutorial();

            break;

        case "3":
            exit();

            break;

        default:
            Console.Clear();
            Console.WriteLine("Źle wybrana opcja!");
            main();

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
        main();
    }

    else if (answerTutorial == "2")
    {
        exit();
    }

    else
    {

        Console.Clear();
        Console.WriteLine("Źle wybrana opcja, wybierz pomiędzy 1 a 2!");
        Tutorial();
    }
}

static void calculateIncomeMenu()
{
    Console.Clear();
    Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════╗");
    Console.WriteLine("                                           KALKULATOR BUDŻETU                             ");
    Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════╝");
    Console.WriteLine("Wprowadź następujące dane:");
    Thread.Sleep(1000);
    Console.WriteLine("Wartość A: Przychód miesięczny na jedno gospodarstwo domowe");
    Thread.Sleep(1000);
    Console.WriteLine("Wartość A2: Inne wpływy użytkownika");
    Thread.Sleep(1000);
    Console.WriteLine("Wartość B: Wydatki podstawowe (Czynsz)");
    Thread.Sleep(1000);
    Console.WriteLine("Wartość B2: Media (w tym gaz i prąd)");
    Thread.Sleep(1000);
    Console.WriteLine("Wartość B3: Zakupy, miesięczny wykaz.");
    Thread.Sleep(1000);
    Console.WriteLine("Są to podstawowe dane jakich wymagamy, późniejsze zmiany będą możliwe w odpowiednim menu");

    Thread.Sleep(1000);
    inputCalculateVariables();


}

static void inputCalculateVariables()
{

    Console.WriteLine("Wartość A: ");
    var a = Console.ReadLine();
    int numberA = 0;
    Int32.TryParse(a, out numberA);

    Console.WriteLine("Wartość A2: ");
    var a2 = Console.ReadLine();
    int numberA2 = 0;
    Int32.TryParse(a2, out numberA2);
    Console.WriteLine("Wartość B: ");
    var b = Console.ReadLine();
    int numberB = 0;
    Int32.TryParse(b, out numberB);
    Console.WriteLine("Wartość B2: ");
    var b2 = Console.ReadLine();
    int numberB2 = 0;
    Int32.TryParse(b2, out numberB2);
    Console.WriteLine("Wartość B3: ");
    var b3 = Console.ReadLine();
    int numberB3 = 0;
    Int32.TryParse(b3, out numberB3);
    int balance = (numberA + numberA2) - (numberB + numberB2 + numberB3);


    Console.WriteLine("Wprowadzono dane!");
    if (numberA < 0 || numberA2 < 0 || numberB < 0 || numberB2 < 0 || numberB3 < 0)
    {
        Console.WriteLine("Wprowadzono ujemne liczby! Rozpocznij wprowadzanie danych od nowa");
        Thread.Sleep(1000);
        inputCalculateVariables();
    }
    Thread.Sleep(1000);
    Console.WriteLine("Zostaniesz przeniesiony do menu głównego!");
    Thread.Sleep(1000);
    modifiedMenu(balance , numberA , numberA2 , numberB , numberB2 , numberB3);
}




static void modifiedMenu(int balance , int numberA , int numberA2 , int numberB , int numberB2 , int numberB3)
{
    int income = numberA + numberA2;
    int expenses = numberB + numberB2 + numberB3;
    Console.Clear();
    Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════╗");
    Console.WriteLine("                                             MENU                                         ");
    Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════╝");
    Console.WriteLine("Twoje saldo wynosi: " + balance);
    Console.WriteLine("Twoje przychody wynoszą: " + income);
    Console.WriteLine("Twoje wydatki w sumie wynoszą : " + expenses);
    Console.WriteLine("1.Zmień wartości");
    Console.WriteLine("2.Wyjście z programu");
    Console.WriteLine("                   ");
    Console.WriteLine("Wprowadź dane:");
    var input = Console.ReadLine();


    switch (input)
    {
        case "1":
            calculateIncomeMenu();
            break;

        case "2":
            exit();
            break;

        case "3":
            main();
            break;

        default:
            Console.WriteLine("Błąd! Wprowadaj, opcje tylko pomiędzy 1 a 3!");
            Thread.Sleep(1000);
            Console.Clear();
            modifiedMenu( balance, numberA, numberA2, numberB, numberB2, numberB3);
            break;
    };

}





main();







Console.ReadKey();