namespace AnimalFarm.classes.animals.reptiles.snakes
{
    internal class CommonEggEater : Snake
    {
        public string FoodRemains { get; set; }

        public CommonEggEater()
        {
            PreferredFood = PreferredFood.Ovivore;
            FoodRemains = "cracked shell";
            MaxAge = 15;
            Speed = "slow";
            Species = "Common egg eater";
        }

        public override void MakeSound()
        {
            Console.WriteLine($"When they get scared, {Name} the common egg eater lets out a hiss.");
        }
        public static void MakeSound(string input)
        {
            Console.WriteLine($"As if they got scared, a {input} let out a hiss.");
        }

        public override void Move()
        {
            Console.WriteLine($"Common egg eaters like {Name} moves quite {Speed}.");
        }
        public override void Eat()
        {
            Console.WriteLine($"{Name} is a rare type of creature, being an {PreferredFood.ToString().ToLower()}, meaning they only eat eggs.");
        }

        public void Spit()
        {
            Console.WriteLine($"When they've finished eating, {Name} spits out the {FoodRemains}.");
        }
    }

}
