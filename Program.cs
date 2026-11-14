using PetAdpotionSolo;
using System.Xml.Linq;
using System.Linq;

bool exit = false;

Shelter firstShelter = new Shelter();

Pet Lottie = new Pet("Lottie", "King Charles Caveler");
Pet Blue = new Pet("Blue", "Huskey");
Pet Lulu = new Pet("Lulu", "unknown");
Pet Pushkins = new Pet("Pushkins", "indoor cat");
Pet Bibble = new Pet("Bibble", "indoor cat");

firstShelter.AddPet(Lottie);
firstShelter.AddPet(Blue);
firstShelter.AddPet(Lulu);
firstShelter.AddPet(Pushkins);
firstShelter.AddPet(Bibble);

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
            CreateNewPet();
            MenuOrExit();
            break;
        case 3:
            MenuOrExit();
            break;
        case 4:
            MenuOrExit();
            break;
        case 5:
            MenuOrExit();
            break;
        case 6:
            Exit();
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

void CreateNewPet()
{
    Console.WriteLine("Please enter pet's name :");
    string newPetName = Console.ReadLine();
    while (string.IsNullOrWhiteSpace(newPetName))
    {
        Console.WriteLine("Nothing entered, please enter name for the new pet : ");
        newPetName = Console.ReadLine();
    }

    Console.WriteLine("Please enter pet's species");
    string newPetSpecies = Console.ReadLine();
    while (string.IsNullOrWhiteSpace(newPetSpecies))
    {
        Console.WriteLine("Nothing entered, please enter name for the new pet : ");
        newPetSpecies = Console.ReadLine();
    }

    Pet newPet = new Pet(newPetName, newPetSpecies);

    firstShelter.AddPet(newPet);
}

void FeedAPet()
{
    Console.WriteLine("Please enter the name of the pet you want to feed :");
    string petBeingFed = Console.ReadLine();

    foreach(Pet pet in firstShelter.pets)
    {
        if (petBeingFed?.Trim().ToLower() == pet.Name.Trim().ToLower())
        {
            Console.WriteLine($"{petBeingFed} is now being fed");
            

            Console.WriteLine($"{petBeingFed}'s hunger")
        }
    }

}

//PlayWithPet

//AdoptAPet

void Exit()
{
    exit = true;
}
