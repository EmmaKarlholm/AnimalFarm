namespace AnimalFarm.classes.animals.reptiles
{
    internal abstract class Reptile : Animal
    {
        public Reptile()
        {
            AnimalType = ReptileOrMammalOrPlant.Reptile;
            Tamed = WildOrTame.Wild;
        }

        public abstract override void MakeSound();
        public abstract override void Move();
        public abstract override void Eat();
    }

}
