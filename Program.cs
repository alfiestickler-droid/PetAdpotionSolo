using PetAdpotionSolo;

bool exit = false;

Shelter firstShelter = new Shelter();

Pet Lottie = new Pet("Lottie", "King Charles Caveler");
Pet Blue = new Pet("Blue", "Huskey");
Pet Lulu = new Pet("Lulu", "unknown");
Pet Pushkins = new Pet("Pushkins", "indoor cat");
Pet Bibble = new Pet("Bibble", "indoor cat");

firstShelter.AddPet(Lottie);
firstShelter.AddPet(Lottie);
firstShelter.AddPet(Lottie);
firstShelter.AddPet(Lottie);
firstShelter.AddPet(Lottie);

//Main
while (!exit)
{
    int menuOption = StartMenu();

    switch (menuOption)
    {
        case 1:
            firstShelter.ShowAllPets();
            MenuOrExit();
            break;
        case 2:
            //firstShelter.AddPet();
            MenuOrExit();
            break;
        case 3:
            break;
        case 4:
            break;
        case 5:
            break;
        case 6:
            break;
    }
}



//functions

int StartMenu()
{
    Console.Clear();
    Console.WriteLine("---------- Welcome to the my animal shelter ----------");
    Console.WriteLine();

    Console.WriteLine("----- Menu -----");
    Console.WriteLine("1. View all pets");
    Console.WriteLine("2. Intake an new pet");
    Console.WriteLine("3. Feed a pet");
    Console.WriteLine("4. Play with a pet");
    Console.WriteLine("5. Adopt a pet");
    Console.WriteLine("6. Exit");
    Console.WriteLine();

    Console.WriteLine("Please pick an option using a number : ");

    string option = Console.ReadLine();
    while (option != "1" && option != "2" && option != "3" && option != "4" && option != "5" && option != "6")
    {
        Console.WriteLine($"{option} is not valid, please enter 1, 2, 3, 4, 5 or 6");
        option = Console.ReadLine();
    }

    int optionInt = int.Parse(option);

    return optionInt;
}

void MenuOrExit()
{
    Console.WriteLine("\nTo return to menu please type 'menu' or to exit please type 'exit'");
    string userOption = Console.ReadLine();
    userOption.ToLower().Trim();

    if (userOption == "menu")
    {
        StartMenu();
    }
    else if (userOption == "exit")
    {
        exit = true;
    }
    else
    {
        while (userOption != "menu" && userOption != "exit")
        {
            Console.WriteLine("Sorry not a valid input, please enter menu to return to menu or exit to exit");
            userOption = Console.ReadLine();
        }

        if (userOption == "menu")
        {
            StartMenu();
        }
        else
        {
            exit = true;
        }
    }
}