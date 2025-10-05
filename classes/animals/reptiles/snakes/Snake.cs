namespace AnimalFarm.classes.animals.reptiles.snakes
{
    internal abstract class Snake : Reptile
    {
        public Snake()
        {

        }

        public abstract override void MakeSound();
        public abstract override void Move();
        public abstract override void Eat();
    }

}
