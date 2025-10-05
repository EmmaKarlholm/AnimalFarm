namespace AnimalFarm.classes.animals.mammals
{
    internal abstract class Mammal : Animal
    {
        public Mammal()
        {
            AnimalType = ReptileOrMammalOrPlant.Mammal;

        }

        public abstract override void MakeSound();
        public abstract override void Move();
        public abstract override void Eat();
    }

}
