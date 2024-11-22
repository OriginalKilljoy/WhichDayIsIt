//Ha en variabel med datatypen int og gi den en value med et tall mellom1 og 7. 
// Bruk en switch for å finne ut hvilken dag i uken det tallet er, og print ut dagen med Console.WriteLine();
// Eksempel: 
// 1 er mandag, 2 er tirsdag, osv. 



Console.WriteLine("Hello! Choose a number between 1-7 to choose a day:)");
Run();

void Run()
{
    var userInput = Console.ReadLine();
    int valueOfDay = Convert.ToInt32(userInput);
    switch (valueOfDay)
    {
        case 1:
            Console.WriteLine("The day is Monday!");
            Thread.Sleep(600);
            Console.WriteLine("Would you like to choose another day? Enter a new number!");
            Run();
            break;
        case 2:
            Console.WriteLine("The day is Tuesday!");
            Thread.Sleep(600);
            Console.WriteLine("Would you like to choose another day? Enter a new number!");
            Run();
            break;
        case 3:
            Console.WriteLine("The day is Wednesday!");
            Thread.Sleep(600);
            Console.WriteLine("Would you like to choose another day? Enter a new number!");
            Run();
            break;
        case 4:
            Console.WriteLine("The day is Thursday!");
            Thread.Sleep(600);
            Console.WriteLine("Would you like to choose another day? Enter a new number!");
            Run();
            break;
        case 5:
            Console.WriteLine("The day is Friday!");
            Thread.Sleep(600);
            Console.WriteLine("Would you like to choose another day? Enter a new number!");
            Run();
            break;
        case 6:
            Console.WriteLine("The day is Saturday!");
            Thread.Sleep(600);
            Console.WriteLine("Would you like to choose another day? Enter a new number!");
            Run();
            break;
        case 7:
            Console.WriteLine("The day is Sunday!");
            Thread.Sleep(600);
            Console.WriteLine("Would you like to choose another day? Enter a new number!");
            Run();
            break;
        default:
            Console.WriteLine("You didn't choose a day, try again please. A number between 1-7:)");
            Thread.Sleep(600);
            Run();
            break;
    }
}


    

