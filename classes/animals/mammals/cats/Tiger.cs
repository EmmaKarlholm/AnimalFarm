namespace AnimalFarm.classes.animals.mammals.cats
{
    internal class Tiger : Cat
    {
        public string Jump { get; set; }

        public Tiger()
        {
            PreferredFood = PreferredFood.Carnivore;
            Jump = "jump";
            Tamed = WildOrTame.Wild;
            MaxAge = 20;
            Speed = "fast";
            Species = "Tiger";
        }

        public override void MakeSound()
        {
            Console.WriteLine($"Big cats don't meow, and tigers like {Name} roar so loudly they can be heard\nfrom kilometres away, with the sound waves being so strong they paralyses creatures around them.");
        }

        public static new void MakeSound(string input)
        {
            Console.WriteLine($"A {input} roared so loudly they could be heard from kilometres away,\nplaying back sound waves so strong they could have paralysed creatures around them.");
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} runs with {Speed} speed.");
        }
        public override void Eat()
        {
            Console.WriteLine($"{Name} is a {PreferredFood.ToString().ToLower()}.");
        }

        public void Leap()
        {
            Console.WriteLine($"{Name} can perform an {Jump} jump, going incredibly distances in an instant.");
        }
    }

}
