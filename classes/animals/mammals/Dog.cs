namespace AnimalFarm.classes.animals.mammals
{
    internal class Dog : Mammal
    {
        public string FavouriteTrick { get; set; }

        public Dog()
        {
            PreferredFood = PreferredFood.Omnivore;
            FavouriteTrick = "fetch";
            Tamed = WildOrTame.Tame;
            MaxAge = 13;
            Speed = "moderate";
            Species = "Dog";
        }

        public override void MakeSound()
        {
            Console.WriteLine($"Loud is the bark of {Name}.");
        }
        public static void MakeSound(string input)
        {
            Console.WriteLine($"Loud was the bark of a {input}.");
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} moves with {Speed} speed.");
        }
        public override void Eat()
        {
            Console.WriteLine($"Contrary to what many may believe, dogs like {Name} are {PreferredFood.ToString().ToLower()}s.");
        }

        public void Trick()
        {
            Console.WriteLine($"Humans enjoy teaching their dogs tricks. {Name}'s favourite trick is {FavouriteTrick}.");
        }
    }

}
