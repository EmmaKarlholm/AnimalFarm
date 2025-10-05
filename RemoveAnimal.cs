using AnimalFarm.classes.animals;
using AnimalFarm.classes.animals.mammals;
using AnimalFarm.classes.animals.mammals.cats;
using AnimalFarm.classes.animals.reptiles;
using AnimalFarm.classes.animals.reptiles.snakes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AnimalFarm
{
    internal class RemoveAnimal
    {

        public static void Menu(List<Animal> AnimalList)
        { 
            bool isInMenu = true;
            while (isInMenu)
            {
                Console.CursorVisible = false;

                Console.Clear();
                Console.WriteLine("\tPlease do take an animal with you.");
                Console.WriteLine("\tWhich one are you taking out of the farm?\n");

                for (int i = 0; i <= AnimalList.Count; i++)
                {
                    if (i < AnimalList.Count) // This is an element within the AnimalList
                    {
                        Console.WriteLine($"{i+1}) {AnimalList[i].Name}"); // Start the list at 1, not 0
                    }
                    else // Loop has reached AnimalList.Count, which is the last element +1
                    {
                        Console.WriteLine($"{i+1}) Return to the gate");
                    }
                }
                Console.Write("\n\n  Your choice: ");
                // Save the user's selection. Remember that the number they inputted is 1 higher than
                // what the indexes in the AnimalList show.
                int selection = UserInput.Integer();

                if (selection-1 == AnimalList.Count)
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

                if ( selection-1 < AnimalList.Count)
                {
                    Console.Clear();
                    Console.WriteLine($"You take {AnimalList[selection-1].Name} the {AnimalList[selection-1].Species} " +
                        "with you out of the farm.");
                    AnimalList.RemoveAt(selection-1);
                    Program.Pause();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"\tPlease input a number aligning with an animal, or " +
                        $"{AnimalList.Count} to keep all the animals in the farm.\n");
                    Program.Pause();
                }

            }
        }    
    }
}
