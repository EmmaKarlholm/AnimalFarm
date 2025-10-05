namespace AnimalFarm.classes.animals.mammals.cats
{
    internal class Cheetah : Cat
    {
        public string Spine { get; set; }

        public Cheetah()
        {
            Name = "Default Name";
            PreferredFood = PreferredFood.Carnivore;
            Spine = "spring";
            Tamed = WildOrTame.Wild;
            MaxAge = 20;
            Speed = "incredible";
            Species = "Cheetah";
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} may be a big cat, but it meows cutely even so.");
        }

        public static new void MakeSound(string input)
        {
            Console.WriteLine($"A {input} may be a big cat, but it meowed cutely even so.");
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} runs with {Speed} speed.");
        }

        public override void Eat()
        {
            Console.WriteLine($"{Name} is a {PreferredFood.ToString().ToLower()}.");
        }

        public void SpringSpine()
        {
            Console.WriteLine($"The {Speed} speed of a cheetah comes from their spines acting like a {Spine},\n" +
                $"which is why {Name} can run so fast.");
        }
    }

}
