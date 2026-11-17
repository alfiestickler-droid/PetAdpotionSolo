namespace PetAdpotionSolo
{
    internal class Dog : Pet
    {
        public string Breed { get; set; }


        public Dog(string name, string species, int hunger, int happiness, string breed) : base(name, species, hunger, happiness)
        {
            Breed = breed;
        }

    }


}