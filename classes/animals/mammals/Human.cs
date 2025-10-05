/*  
 *  While this class is complete, instances of the class cannot be added
 *  to the animal farm. It just seems so completely wrong. This means
 *  nothing in this class is really being used aside from the overloaded
 *  generic MakeSound method, but you can read a definition of a human
 *  mammal even so in code.
 */

namespace AnimalFarm.classes.animals.mammals
{
    internal class Human : Mammal
    {        
        public string EducationLevel { get; set; }

        public Human()
        {
            PreferredFood = PreferredFood.Omnivore;
            EducationLevel = "high-school";
            Tamed = WildOrTame.Tame;
            MaxAge = 122;
            Speed = "moderate";
            Species = "Human";

        }

        public override void MakeSound()
        {
            Console.WriteLine($"Humans like {Name} is capable of speech.");
        }

        public static void MakeSound(string input)
        {
            Console.WriteLine($"You hear {input}s speaking, unable to make out words.");
        }

        public override void Move()
        {
            Console.WriteLine($"They move at a {Speed} pace.");
        }
        public override void Eat()
        {
            Console.WriteLine($"{Name} is an {PreferredFood.ToString().ToLower()}.");
        }

        public void Study()
        {
            Console.WriteLine($"Humans are the only species with formalised education, of which {Name}'s education level is {EducationLevel}.");
        }
    }

}
