using PetAdpotionSolo;

bool exit = false;

Shelter firstShelter = new Shelter("SunnyDale Shelter");
Shelter secondShelter = new Shelter("Crazy animalz Shelter");

Shelter shelterSelection = firstShelter;


#region firstShelter pets
Dog Lottie = new Dog("Lottie", "dog", 50, 50, "King Charles Caveler");
Dog Blue = new Dog("Blue", "dog", 50, 50, "Huskey");
Dog Lulu = new Dog("Lulu", "dog", 50, 50, "unknown");
Pet Pushkins = new Pet("Pushkins", "indoor cat");
Pet Bibble = new Pet("Bibble", "indoor cat");

firstShelter.AddPet(Lottie);
firstShelter.AddPet(Blue);
firstShelter.AddPet(Lulu);
firstShelter.AddPet(Pushkins);
firstShelter.AddPet(Bibble);
#endregion

#region secondShelter pets
Dog Mitsy = new Dog("Mitsy", "dog", 50, 50, "Greyhound");
Dog Murphy = new Dog("Murphy", "dog", 50, 50, "Labrador");
Dog Jiggy = new Dog("Jiggy", "dog", 50, 50, "Pug");
Pet Runty = new Pet("Runty", "outdoor cat");
Pet Enzo = new Pet("Enzo", "tiger");

secondShelter.AddPet(Mitsy);
secondShelter.AddPet(Murphy);
secondShelter.AddPet(Jiggy);
secondShelter.AddPet(Runty);
secondShelter.AddPet(Enzo);
#endregion

#region Main
while (!exit)
{
    ShelterMenu();
    bool menu = true;

    while (menu && !exit)
    {
        int menuOption = StartMenu();

        switch (menuOption)
        {
            case 1:
                Console.Clear();
                Console.WriteLine("----- All Pets -----\n");
                shelterSelection.ShowAllPets();
                MenuOrExit();
                break;
            case 2:
                CreateNewPet();
                MenuOrExit();
                break;
            case 3:
                FeedAPet();
                MenuOrExit();
                break;
            case 4:
                PlayWithPet();
                MenuOrExit();
                break;
            case 5:
                AdoptAPet();
                MenuOrExit();
                break;
            case 6:
                menu = false;
                break;
            case 7:
                menu = false;
                Exit();
                break;

        }
    }
}
#endregion

#region functions

void ShelterMenu()
{

    Console.Clear();
    Console.WriteLine("---------- Welcome to my animal shelters ----------");
    Console.WriteLine();

    Console.WriteLine("----- Shelter Selection Menu -----");
    Console.WriteLine($"1. {firstShelter.Name}");
    Console.WriteLine($"2. {secondShelter.Name}");
    Console.WriteLine("3. Exit");

    Console.WriteLine("Select which shelter you would like to visit using the numbers");

    string option = Console.ReadLine();
    while (option != "1" && option != "2" && option != "3")
    {
        Console.WriteLine($"{option} is not valid, please enter 1 or 2");
        option = Console.ReadLine();
    }

    int optionInt = int.Parse(option);

    switch (optionInt)
    {
        case 1:
            shelterSelection = firstShelter;
            break;

        case 2:
            shelterSelection = secondShelter;
            break;
        case 3:
            exit = true;
            break;
    }
}

int StartMenu()
{
    Console.Clear();
    Console.WriteLine($"---------- Welcome to {shelterSelection.Name} ----------");
    Console.WriteLine();

    Console.WriteLine($"----- Menu -----");
    Console.WriteLine("1. View all pets");
    Console.WriteLine("2. Intake an new pet");
    Console.WriteLine("3. Feed a pet");
    Console.WriteLine("4. Play with a pet");
    Console.WriteLine("5. Adopt a pet");
    Console.WriteLine("6. Shelter selection");
    Console.WriteLine("7. Exit");
    Console.WriteLine();

    Console.WriteLine("Please pick an option using a number : ");

    string option = Console.ReadLine();
    while (option != "1" && option != "2" && option != "3" && option != "4" && option != "5" && option != "6" && option != "7")
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

    if (userOption == "exit")
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

        if (userOption == "exit")
        {
            exit = true;
        }
    }
}

void CreateNewPet()
{
    bool newDog = false;
    string userInputNDog = "";
    string newDogBreed = "";
    string newPetSpecies = "";

    Console.Clear();
    Console.WriteLine("----- Intake a Pet -----\n");

    Console.WriteLine("Is the new pet a dog? y/n : ");
    

    while (userInputNDog.Trim().ToLower() != "n" && userInputNDog.Trim().ToLower() != "y")
    {
        userInputNDog = Console.ReadLine();

        while (string.IsNullOrEmpty(userInputNDog))
        {
            Console.WriteLine("Nothing entered, please enter y if you're adding a dog or n for anyhing else");
            userInputNDog = Console.ReadLine();
        }
        if (userInputNDog.Trim().ToLower() == "y")
        {
            newDog = true;
        }
        if (userInputNDog.Trim().ToLower() == "n")
        {
            newDog = false;
        }
        if (userInputNDog.Trim().ToLower() != "n" && userInputNDog.Trim().ToLower() != "y")
        {
            Console.WriteLine("invalid input please enter y if you are adding a dog or n for anything else.");
        }
    }

    if (newDog == true)
    { 
        Console.WriteLine("Please enter dog breed");
        newDogBreed = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(newDogBreed))
        {
            Console.WriteLine("Nothing entered, please enter breed for the new dog : ");
            newDogBreed = Console.ReadLine();
        }
    }

        Console.WriteLine("Please enter pet's name : ");
    string newPetName = Console.ReadLine();
    while (string.IsNullOrWhiteSpace(newPetName))
    {
        Console.WriteLine("Nothing entered, please enter name for the new pet : ");
        newPetName = Console.ReadLine();
    }

    if (!newDog)
    {
        Console.WriteLine("Please enter pet's species");
        newPetSpecies = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(newPetSpecies))
        {
            Console.WriteLine("Nothing entered, please enter name for the new pet : ");
            newPetSpecies = Console.ReadLine();
        }
    }

    if(newDog == true)
    {
        Dog newDogFin = new Dog(newPetName, "dog", 50, 50, newDogBreed);

        shelterSelection.AddPet(newDogFin);

        Console.WriteLine($"{newPetName} has been added to the {shelterSelection.Name}");
    }
    else
    {
        Pet newPet = new Pet(newPetName, newPetSpecies);

        shelterSelection.AddPet(newPet);

        Console.WriteLine($"{newPetName} has been added to the {shelterSelection.Name}");
    } 
}

void FeedAPet()
{
    Console.Clear();
    Console.WriteLine("----- Feed a Pet -----\n");
    Console.WriteLine("Please enter the name of the pet you want to feed :");
    string petBeingFed = Console.ReadLine();

    foreach (Pet pet in shelterSelection.pets)
    {
        if (petBeingFed?.Trim().ToLower() == pet.Name.Trim().ToLower())
        {
            Console.WriteLine($"{petBeingFed} is now being fed");
            pet.Feed();

            Console.WriteLine($"{petBeingFed}'s hunger is now {pet.Hunger}");
        }
    }

}

void PlayWithPet()
{
    Console.Clear();
    Console.WriteLine("----- Play With Pet -----\n");
    Console.WriteLine("Please enter the name of the pet you want to play with :");
    string petHavingFun = Console.ReadLine();

    foreach (Pet pet in shelterSelection.pets)
    {
        if (petHavingFun?.Trim().ToLower() == pet.Name.Trim().ToLower())
        {
            Console.WriteLine($"You have played with {petHavingFun}");
            pet.Play();

            Console.WriteLine($"{petHavingFun}'s hunger is now {pet.Hunger} and happiness is {pet.Happiness}");
        }
    }
}

void AdoptAPet()
{
    Console.Clear();
    Console.WriteLine("----- Adpot a Pet -----\n");
    Console.WriteLine("Please enter the name of the pet you want to adopt : ");
    string petAdopting = Console.ReadLine();
    bool adoptomplete = false;

    foreach (Pet pet in shelterSelection.pets)
    {
        if (petAdopting?.Trim().ToLower() == pet.Name.Trim().ToLower())
        {
            Console.WriteLine($"Congratualtions! You have adpoted {petAdopting}!");

            shelterSelection.pets.Remove(pet);

            break;
        }
    }
    Console.WriteLine("Sorry we don't have a pet with that name.");
}

void Exit()
{
    exit = true;
}
#endregion