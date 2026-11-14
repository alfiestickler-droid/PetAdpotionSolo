using PetAdpotionSolo;
using System.Runtime.InteropServices.Marshalling;

bool exit = false;

Shelter firstShelter = new Shelter();

Pet Lottie = new Pet("Lottie", "King Charles Caveler");
Pet Blue = new Pet("Blue", "Huskey");
Pet Lulu = new Pet("Lulu", "unknown");
Pet Pushkins = new Pet("Pushkins", "indoor cat");
Pet Bibble = new Pet("Bibble", "indoor cat");

//Main
while (exit == false)
{
    StartMenu();

    string option = Console.ReadLine();
    while (option != "1" || option != "2" || option != "3" || option != "4" || option != "5" || option != "6")
    {
        Console.WriteLine($"{option} is not valid, please enter 1, 2, 3, 4, 5 or 6");
        option = Console.ReadLine();
    }

    
}



//functions

void StartMenu()
{
    Console.Clear();
    Console.WriteLine("---------- Welcome to the my animal shelter ----------");
    Console.WriteLine("Please pick an option using a number.");

    Console.WriteLine("1. View all pets");
    Console.WriteLine("2. Intake an new pet");
    Console.WriteLine("3. Feed a pet");
    Console.WriteLine("4. Play with a pet");
    Console.WriteLine("5. Adopt a pet");
    Console.WriteLine("6. Exit");
}

