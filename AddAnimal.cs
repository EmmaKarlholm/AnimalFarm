using AnimalFarm.classes.animals;
using AnimalFarm.classes.animals.mammals;
using AnimalFarm.classes.animals.mammals.cats;
using AnimalFarm.classes.animals.reptiles;
using AnimalFarm.classes.animals.reptiles.snakes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace AnimalFarm
{
    internal class AddAnimal
    {
        public static void Menu(List<Animal> AnimalList)
        {
            bool isInMenu = true;
            while (isInMenu)
            {
                Console.CursorVisible = false;
                // Set up menu.
                string[] menuHeader = [
                    "\tI'm so happy to see you wanting to give us an animal!",
                    "\tSelect what type of animal you're giving us and tell us a little about them.\n",
                 ];

                string[] menuOptions = [
                    "Return to the gate",
                    "Add a cheetah",
                    "Add a common egg eater",
                    "Add a common house cat",
                    "Add a dog",
                    "Add a plant",
                    "Add a python",
                    "Add a tegu",
                    "Add a tiger"
                ];

                int menuSelection = AnimalFarm.Menu.Render(menuHeader, menuOptions);
                switch (menuSelection)
                {
                    case 0: // Return to main menu
                        {
                            Console.Clear();
                            Console.Write("\n\t\t\t");
                            Thread.Sleep(200);
                            Console.Write(". ");
                            Thread.Sleep(200);
                            Console.Write(". ");
                            Thread.Sleep(200);
                            Console.Write(". ");
                            Thread.Sleep(400);
                            return;
                        }

                    case 1: // Cheetah
                        {
                            bool isSnake = false;
                            (string name, int age, string colour, int size) = AskQuestions("cheetah", isSnake);
                            Cheetah newCheetah = new Cheetah { Name = name, Age = age, Colour = colour, Size = size };
                            AnimalList.Add(newCheetah);
                            Thread.Sleep(300);
                            break;
                        }

                    case 2: // Common egg eater
                        {
                            bool isSnake = true;
                            (string name, int age, string colour, int size) = AskQuestions("common egg eater", isSnake);
                            CommonEggEater newCommonEggEater = new CommonEggEater { Name = name, Age = age, Colour = colour, Size = size };
                            AnimalList.Add(newCommonEggEater);
                            Thread.Sleep(300);
                            break;
                        }

                    case 3: // Cat
                        {
                            bool isSnake = false;
                            (string name, int age, string colour, int size) = AskQuestions("house cat", isSnake);
                            Cat newCat = new Cat { Name = name, Age = age, Colour = colour, Size = size };
                            AnimalList.Add(newCat);
                            Thread.Sleep(300);
                            break;
                        }

                    case 4: // Dog
                        {
                            bool isSnake = false;
                            (string name, int age, string colour, int size) = AskQuestions("dog", isSnake);
                            Dog newDog = new Dog { Name = name, Age = age, Colour = colour, Size = size };
                            AnimalList.Add(newDog);
                            Thread.Sleep(300);
                            break;
                        }

                    case 5: // Plant
                        {
                            bool isSnake = false;
                            (string name, int age, string colour, int size) = AskQuestions("plant", isSnake);
                            Plant newPlant = new Plant { Name = name, Age = age, Colour = colour, Size = size };
                            AnimalList.Add(newPlant);
                            Thread.Sleep(300);
                            break;
                        }

                    case 6: // Python
                        {
                            bool isSnake = true;
                            (string name, int age, string colour, int size) = AskQuestions("python", isSnake);
                            Python newPython = new Python { Name = name, Age = age, Colour = colour, Size = size };
                            AnimalList.Add(newPython);
                            Thread.Sleep(300);
                            break;
                        }

                    case 7: // Tegu
                        {
                            bool isSnake = false;
                            (string name, int age, string colour, int size) = AskQuestions("tegu", isSnake);
                            Tegu newTegu = new Tegu { Name = name, Age = age, Colour = colour, Size = size };
                            AnimalList.Add(newTegu);
                            Thread.Sleep(300);
                            break;
                        }

                    case 8: // Tiger
                        {
                            bool isSnake = false;
                            (string name, int age, string colour, int size) = AskQuestions("tiger", isSnake);
                            Tiger newTiger = new Tiger { Name = name, Age = age, Colour = colour, Size = size };
                            AnimalList.Add(newTiger);
                            Thread.Sleep(300);
                            break;
                        }
                }

            }
        }

        public static (string, int, string, int) AskQuestions(string animal, bool isSnake)
        {
            Console.CursorVisible = true;
            Console.Clear();
            Console.Write($"What is the {animal}'s name? ");
            string name = UserInput.TrimmedString();
            Console.Write("\n");
            Console.Write($"What is the {animal}'s age (in years)? ");
            int age = UserInput.Integer();
            Console.Write("\n");
            Console.Write($"What is the {animal}'s colour? ");
            string colour = UserInput.TrimmedString();
            Console.Write("\n");
            if (isSnake)
            {
                Console.Write($"What is the {animal}'s height (in cm)? ");
            }
            else
            {
                Console.Write($"What is the {animal}'s length (in cm)? ");
            }
            int size = UserInput.Integer();
            return (name, age, colour, size);
        }

        public static void AnimalAdded(string name)
        {
            Thread.Sleep(500);
            Console.WriteLine($"\n{name} has been accepted into the farm!");
            Program.Pause();
        }
    }
}
