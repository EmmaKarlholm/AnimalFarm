namespace AnimalFarm.classes.animals.mammals.cats
{
    internal class Cat : Mammal
    {
        public int CatLives { get; set; }

        public Cat()
        {
            PreferredFood = PreferredFood.Carnivore;
            CatLives = 9;
            Tamed = WildOrTame.Tame;
            MaxAge = 17;
            Species = "House cat";
            Speed = "moderate";
            
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} meows for attention.");
        }
        public static void MakeSound(string input)
        {
            Console.WriteLine($"A {input} meowed for attention.");
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} runs with {Speed} speed.");
        }
        public override void Eat()
        {
            Console.WriteLine($"{Name} is a {PreferredFood.ToString().ToLower()}.");
        }

        public void MiraculousSurvival()
        {
            Console.WriteLine($"Cats are blessed with incredible perception and dexterity, leading to the idea\n" +
                $"that they have multiple lives. {Name} has {CatLives} such years left.");
        }
    }

}
