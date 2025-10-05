using AnimalFarm.classes.animals;
using AnimalFarm.classes.animals.mammals;
using AnimalFarm.classes.animals.mammals.cats;
using AnimalFarm.classes.animals.reptiles;
using AnimalFarm.classes.animals.reptiles.snakes;

namespace AnimalFarm
{
    internal class Program
    {
        public static List<Animal> AnimalList { get; set; } = new List<Animal>();

        static void Main(string[] args)
        {

            // Pre-populate the AnimalList with some preset animals.
            AnimalList.Add(new Python { Name = "Rahmia", Age = 7, Colour = "orange-brown", Size = 121 });
            AnimalList.Add(new Cat { Name = "Fia-Lotta", Age = 4, Colour = "black", Size = 27 });

            bool isRunning = true;

            while (isRunning)
            {
                Console.CursorVisible = false;

                // Set up menu.
                string[] menuHeader = [
                    "\t\tWelcome to the Animal Farm!",
                    "\tToday you will be meeting with the animals,",
                    "\tand perhaps even letting some new animals join the farm.\n",
                ];

                string[] menuOptions = [
                    "Visit all the animals currently at the farm",
                    "Listen to recordings of animals",
                    "Bring in a new animal",
                    "Take an animal out of the farm",
                    "Leave the farm"
                ];

                int menuSelection = Menu.Render(menuHeader, menuOptions);
                switch (menuSelection)
                {
                    case 0: // List the animals in AnimalList
                        Console.Clear();
                        VisitAnimals();
                        break;

                    case 1: // Play all MakeSound methods
                        Console.Clear();
                        Cheetah.MakeSound("cheetah");
                        CommonEggEater.MakeSound("common egg eater");
                        Dog.MakeSound("dog");
                        Cat.MakeSound("house cat");
                        Human.MakeSound("human");
                        Plant.MakeSound("plant");
                        Python.MakeSound("python");
                        Tegu.MakeSound("tegu");
                        Tiger.MakeSound("tiger");
                        Pause();
                        break;

                    case 2: // Add a new animal to AnimalList
                        Console.Clear();
                        AddAnimal.Menu(AnimalList);
                        break;

                    case 3: // Remove an animal from AnimalList
                        Console.Clear();
                        RemoveAnimal.Menu(AnimalList);
                        break;

                    case 4: // Quit
                        Console.Clear();
                        Console.WriteLine("\n\n\tPlease come again!\n\n");
                        Thread.Sleep(800);
                        isRunning = false;
                        break;
                }
            }
        }

        public static void Pause()
        {
            Thread.Sleep(1000);
            Console.WriteLine("\n\tPlease press any key . . .");
            Console.ReadKey();
        }

        // Display the contentes of the AnimalList
        public static void VisitAnimals()
        {
            Console.Clear();
            Console.WriteLine("These are the animals currently on the farm.\n");
            int countToTwo = 0;
            for (int i = 0; i < AnimalList.Count; i++) 
            {
                countToTwo++;

                if (AnimalList[i].Name.Length >= 9) // Varying amounts of \t for better looks
                {
                    Console.Write($" Name: {AnimalList[i].Name}\t");
                }
                else
                {
                    Console.Write($" Name: {AnimalList[i].Name}\t\t");
                }
                Console.WriteLine($"Species: { AnimalList[i].Species}, " +
                    $"a {AnimalList[i].AnimalType.ToString().ToLower()}");
    
                if (AnimalList[i].Age < 9) // Varying amounts of \t for better looks
                {
                    Console.Write($" Age: {AnimalList[i].Age}\t\t\t");
                }
                else
                {
                    Console.Write($" Age: {AnimalList[i].Age}\t\tSize: {AnimalList[i].Size}cm");
                }
                Console.WriteLine($"Size: {AnimalList[i].Size}cm");

                Console.WriteLine($" Life Expectancy: {AnimalList[i].MaxAge}\tColour: {AnimalList[i].Colour}");
                Console.WriteLine($" Domesticity: {AnimalList[i].Tamed}");
                Console.Write("\n");


                // Time to use each animal's methods, including their special move!
                
                if (AnimalList[i] is Cat cat)
                {
                    Console.Write(" ");
                    cat.Move(); Console.Write(" ");
                    cat.Eat(); Console.Write(" ");
                    cat.MakeSound(); Console.Write(" ");
                    cat.MiraculousSurvival();
                }

                else if (AnimalList[i] is CommonEggEater commonEggEater)
                {
                    Console.Write(" ");
                    commonEggEater.Move(); Console.Write(" ");
                    commonEggEater.Eat(); Console.Write(" ");
                    commonEggEater.MakeSound(); Console.Write(" ");
                    commonEggEater.Spit();
                }

                else if (AnimalList[i] is Cheetah cheetah)
                {
                    Console.Write(" ");
                    cheetah.Move(); Console.Write(" ");
                    cheetah.Eat(); Console.Write(" ");
                    cheetah.MakeSound(); Console.Write(" ");
                    cheetah.SpringSpine();
                }

                else if (AnimalList[i] is Dog dog)
                {
                    Console.Write(" ");
                    dog.Move(); Console.Write(" ");
                    dog.Eat(); Console.Write(" ");
                    dog.MakeSound(); Console.Write(" ");
                    dog.Trick();
                }

                else if (AnimalList[i] is Human human)
                {
                    Console.Write(" ");
                    human.Move(); Console.Write(" ");
                    human.Eat(); Console.Write(" ");
                    human.MakeSound(); Console.Write(" ");
                    human.Study();
                }

                else if (AnimalList[i] is Plant plant)
                {
                    Console.Write(" ");
                    plant.Move(); Console.Write(" ");
                    plant.Eat(); Console.Write(" ");
                    plant.MakeSound(); Console.Write(" ");
                    plant.PollenRelease();
                }

                else if (AnimalList[i] is Python python)
                {
                    Console.Write(" ");
                    python.Move(); Console.Write(" ");
                    python.Eat(); Console.Write(" ");
                    python.MakeSound(); Console.Write(" ");
                    python.Hug();
                }

                else if (AnimalList[i] is Tiger tiger)
                {
                    Console.Write(" ");
                    tiger.Move(); Console.Write(" ");
                    tiger.Eat(); Console.Write(" ");
                    tiger.MakeSound(); Console.Write(" ");
                    tiger.Leap();
                }

                else if (AnimalList[i] is Tegu tegu)
                {
                    Console.Write(" ");
                    tegu.Move(); Console.Write(" ");
                    tegu.Eat(); Console.Write(" ");
                    tegu.MakeSound(); Console.Write(" ");
                    tegu.Dig();
                }


                // Pause if dividing by 2 gives a result of 0. Ie stop animal scroll by two animals.
                // But don't pause if the last animal was already displayed.
                if (countToTwo % 2 == 0 && i < AnimalList.Count-1)
                {
                    Pause();
                    Console.Clear();
                }
                else
                {
                    // Don't draw separator if the current animal is the last in the AnimalList.
                    if (i != AnimalList.Count-1)
                    {
                        Console.Write($"\n - - -\n\n");
                    }
                }

            }
            Pause();
        }

    }
}
