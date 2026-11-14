namespace PetAdpotionSolo
{
    class Shelter
    {
        public List<Pet> pets = new List<Pet>();

        public void AddPet(Pet newPet)
        {
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