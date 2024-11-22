//Ha en variabel med datatypen int og gi den en value med et tall mellom1 og 7. 
// Bruk en switch for å finne ut hvilken dag i uken det tallet er, og print ut dagen med Console.WriteLine();
// Eksempel: 
// 1 er mandag, 2 er tirsdag, osv. 




Run();

void Run()
{
    Console.WriteLine("Hello! Choose a number between 1-7 to choose a day:)");
    var userInput = Console.ReadLine();
    int valueOfDay = Convert.ToInt32(userInput);
    switch (valueOfDay)
    {
        case 1:
            Console.WriteLine("The day is Monday \n Would you like to choose another day? Enter a new number!");
            Run();
            break;
        case 2:
            Console.WriteLine("The day is Tuesday\n Would you like to choose another day? Enter a new number!");
            Run();
            break;
        case 3:
            Console.WriteLine("The day is Wednesday\n Would you like to choose another day? Enter a new number!");
            Run();
            break;
        case 4:
            Console.WriteLine("The day is Thursday\n Would you like to choose another day? Enter a new number!");
            Run();
            break;
        case 5:
            Console.WriteLine("The day is Friday\n Would you like to choose another day? Enter a new number!");
            Run();
            break;
        case 6:
            Console.WriteLine("The day is Saturday\n Would you like to choose another day? Enter a new number!");
            Run();
            break;
        case 7:
            Console.WriteLine("The day is Sunday\n Would you like to choose another day? Enter a new number!");
            Run();
            break;
        default:
            Console.WriteLine("You didn't choose a day");
            break;
    }
}


    

