namespace AnimalFarm.classes.animals
{
    abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int MaxAge { get; set; }
        public string Colour { get; set; }
        public string Speed { get; set; }
        public int Size { get; set; }
        public string Species { get; set; }
        public PreferredFood PreferredFood { get; set; }
        public WildOrTame Tamed { get; set; }
        public ReptileOrMammalOrPlant AnimalType { get; set; }


        public Animal()
        {
            Name = "Default Name";
            Age = 0;
            Colour = "Default Colour";
            Speed = "Default Speed";
            Size = 0;
            Species = "Default Species";
            AnimalType = ReptileOrMammalOrPlant.Plant;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("This indistinct sound should never be heard.");
        }

        public virtual void Move()
        {
            Console.WriteLine("This indistinct movement should never happen.");
        }

        public virtual void Eat()
        {
            Console.WriteLine("This unknown way of eating should never be performed.");
        }


    }
}
