namespace PetAdpotionSolo
{
    class Shelter
    {
        private List<Pet> pets = new List<Pet>();

        public void AddPet(Pet newPet)
        {
            Console.WriteLine("Please enter pet name :");
            string name = Console.ReadLine();
            while (name == null)
            {
                Console.WriteLine("No name entered, please enter pet name :");
                name = Console.ReadLine();
            }

            Console.WriteLine("Please enter pet species :");
            string species = Console.ReadLine();
            while (species == null)
            {
                Console.WriteLine("No species entered, please enter pet species :");
                species = Console.ReadLine();
            }

            newPet.Name = name;
            newPet.Species = species;

            pets.Add(newPet);
        }


        public Pet FindPetByName(string name)
        {
            return pets.FirstOrDefault(p => p.Name.Trim().Equals(name?.Trim(), StringComparison.OrdinalIgnoreCase));
        }

        public void AdoptPet(string name)
        {
            Pet adoptedPet = FindPetByName(name);

            if (adoptedPet != null)
            {
                Console.WriteLine($"Congratulations {adoptedPet} has been adpoted!");

                pets.Remove(adoptedPet);
            }
            else
            {
                Console.WriteLine($"Sorry, no pet named {name} was found.");
            }

        }

        public void ShowAllPets()
        {
            foreach (Pet pet in pets)
            {
                Console.WriteLine(pet.GetStatus());
            }
        }
    }
}