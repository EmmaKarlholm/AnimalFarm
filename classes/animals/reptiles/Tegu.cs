namespace AnimalFarm.classes.animals.reptiles
{
    internal class Tegu : Reptile
    {

        public Tegu()
        {
            PreferredFood = PreferredFood.Omnivore;
            Species = "Tegu";
            Speed = "slow";
        }

        public override void MakeSound()
        {
            Console.WriteLine($"The tegu {Name} is chuffing happily.");
        }
        public static void MakeSound(string input)
        {
            Console.WriteLine($"A {input} was heard chuffing happily.");
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} rushes {Speed}ly.");
        }

        public override void Eat()
        {
            Console.WriteLine($"When it comes to food, {Name} is an {PreferredFood.ToString().ToLower()}.");
        }

        public void Dig()
        {
            Console.WriteLine($"Oh look, {Name} is digging in their substrate!");
        }
    }

}
