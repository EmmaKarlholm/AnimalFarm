namespace AnimalFarm.classes.animals.reptiles.snakes
{
    internal class Python : Snake
    {
        public string HugQuality { get; set; }

        public Python()
        {
            PreferredFood = PreferredFood.Carnivore;
            HugQuality = "good";
            Speed = "slow";
            MaxAge = 30;
            Species = "Python";
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} the python is hissing when they're scared.");
        }

        public static void MakeSound(string input)
        {
            Console.WriteLine($"A {input} was hissing as if they were scared.");
        }

        public override void Move()
        {
            // This was a lovely little experiment. Glad I got it working!
            Console.WriteLine((char.ToUpper(Speed[0]) + Speed.Substring(1).ToLower()) + " are the slithers of " + Name + ".");
        }

        public override void Eat()
        {
            Console.WriteLine($"{Name} is a {PreferredFood.ToString().ToLower()}.");
        }

        public void Hug()
        {
            Console.WriteLine($"{Name} is always up for a {HugQuality} hug!");
        }
    }

}
