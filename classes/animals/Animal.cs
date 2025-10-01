using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm.classes.animals
{
    abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }
        public int Weight { get; set; }
        public string Colour { get; set; }
        public bool IsTame { get; set; }


        public Animal(string name, int age, double height, int weight, string colour, bool isTame)
        {
            Name = name;
            Age = age;
            Height = height;
            Weight = weight;
            Colour = colour;
            IsTame = isTame;
        }

        public abstract void MakeSound();
        public abstract void Move();
        public abstract void Eat();

    }
}
