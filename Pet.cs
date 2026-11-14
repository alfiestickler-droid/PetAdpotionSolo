using System;
using System.Collections.Generic;
using System.Text;

namespace PetAdpotionSolo
{
    class Pet
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public int Hunger { get; private set; } //private set turns it into what is basically read only outside the class.
        public int Happiness { get; private set; }

        //constructors

        public Pet (string name, string species, int hunger = 50, int happiness = 50)
        {
            Name = name;
            Species = species;
            Hunger = hunger;
            Happiness = happiness;
        }

        //methods

        public void Feed()
        {
            Hunger -= 20;

            if (Hunger < 0)
            {
                Hunger = 0;
            }
        }

        public void Play()
        {
            Happiness += 20;

            if (Happiness > 100)
            {
                Happiness = 100;
            }

            Hunger += 10;

            if (Hunger > 100)
            {
                Hunger = 100;
            }
        }

        public string GetStatus()
        {
            return $"The {Species} : {Name}'s hunger is : {Hunger} and happiness is : {Happiness}";
        }
    }
}
