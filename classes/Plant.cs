namespace AnimalFarm.classes.animals
{
    internal class Plant : Animal
    {

        public Plant()
        {
            PreferredFood = PreferredFood.Heliovore;
            AnimalType = ReptileOrMammalOrPlant.Plant;
            Tamed = WildOrTame.Wild;
            MaxAge = 100;
            Species = "Plant";
            Speed = "cannot move";
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} is completely silent.");
        }
        public static void MakeSound(string input)
        {
            Console.WriteLine($"No {input} can be heard.");
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} {Speed}.");
        }

        public override void Eat()
        {
            Console.WriteLine($"{Name} is a {PreferredFood.ToString().ToLower()}, which is a non-scientific term meaning it takes in sunlight.");
        }

        public void PollenRelease()
        {
            Console.WriteLine($"{Name} is blowing in the wind, releasing pollen.");
        }
    }

}
