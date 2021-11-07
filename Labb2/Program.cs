using System;
using System.Threading;

namespace Labb2
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleSettings(7, 70);

            Animals.TextLooper("Välkommen till Zoo Gunnarsson!", 52, 100);
            Console.WriteLine();
            Animals.TextLooper("Du kommer nu få en genomgång alla sorters djur som bor här", 75, 25);

            WaitForInputAndClear();

            ConsoleSettings(15, 70);

            Human myHuman = new Human("människa", "Viktor", 28, "man", 190, 81);
            myHuman.makeSound();
            myHuman.PrintInfromation();
            myHuman.CSharpSkills();
            myHuman.eatFood();
            myHuman.sleeping();

            WaitForInputAndClear();

            Dog myDog = new Dog("hund", "Dogge", 7, "hane", 40, 35);
            myDog.makeSound();
            myDog.PrintInfromation();
            myDog.Owner("Viktor");
            myDog.eatFood();
            myDog.sleeping();

            WaitForInputAndClear();

            Shark myShark = new Shark("hajj", "Shaggy", 150, "hona", 500, 2000);
            myShark.makeSound();
            myShark.PrintInfromation();
            myShark.KillCount(56);
            ((Animals)myShark).eatFood();
            myShark.sleeping();

            WaitForInputAndClear();

            Bird myBird = new Bird("fågel", "Charizard", 28, "hane", 56, 200);
            myBird.makeSound();
            myBird.PrintInfromation();
            myBird.Flightspeed(40);
            myBird.eatFood();
            myBird.sleeping();

            WaitForInputAndClear();

            Cat myCat = new Cat("katt", "Smulan", 2, "hona", 15, 2);
            myCat.makeSound();
            myCat.PrintInfromation();
            myCat.Climbing();
            myCat.eatFood();
            myCat.sleeping();

            WaitForInputAndClear();

            GreatWhiteShark myGreatWhiteShark = new GreatWhiteShark("vithaj", "whitney", 250, "hona", 600, 3025);
            myGreatWhiteShark.makeSound();
            myGreatWhiteShark.PrintInfromation();
            myGreatWhiteShark.HumansAndChildrenEaten(105, 10);
            myGreatWhiteShark.eatFood();
            myGreatWhiteShark.sleeping();

            WaitForInputAndClear();

            HammerHeadShark myHammerHeadShark = new HammerHeadShark("hammarhajar", "Harry", 11, "hane", 200, 600);
            myHammerHeadShark.makeSound();
            myHammerHeadShark.PrintInfromation();
            myHammerHeadShark.BitingPowerLvlUp();
            myHammerHeadShark.eatFood();
            myHammerHeadShark.sleeping();

            WaitForInputAndClear();

            ConsoleSettings(14, 70);

            Animals.TextLooper("Nu ska du få skapa ett eget djur som ska bo på Zoo Gunnarsson", 67, 50);
            Console.WriteLine();
            Animals.TextLooper("Vad för sorts djur vill du skapa: ", 0, 50, false);
            string addAnimalType = Console.ReadLine();
            Animals.TextLooper("Vad vill du att ditt djur ska heta: ", 0, 50, false);
            string addAnimalName = Console.ReadLine();
            Animals.TextLooper("Hur gammal ska djuret vara: (år)", 0, 50, false);
            int addAnimalAge = Convert.ToInt32(Console.ReadLine());
            Animals.TextLooper("Vilket kön ska djuret ha: (hane/hona)", 0, 50, false);
            string addAnimalGender = Console.ReadLine();
            Animals.TextLooper("Hur långt är djuret: (cm)", 0, 50, false);
            double addAnimalHight = Convert.ToDouble(Console.ReadLine());
            Animals.TextLooper("Hur mycket väger djuret: (kg)", 0, 50, false);
            double addAnimalWeight = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            ConsoleSettings(10, 70);

            Animals newAnimal = new Animals(addAnimalType, addAnimalName, addAnimalAge, addAnimalGender, addAnimalHight, addAnimalWeight);
            newAnimal.welcomeNewAnimal();
            newAnimal.PrintInfromation();

            WaitForInputAndClear("avsluta...");

        }
        static void ConsoleSettings(int tempHeight, int tempWidth)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WindowHeight = tempHeight;
            Console.WindowWidth = tempWidth;
        } 
        static void WaitForInputAndClear(string tempPressToContinue = "fortsätta...")
        {
            string pressToContinue = tempPressToContinue;

            Console.WriteLine();
            Console.WriteLine();
            Console.Write(String.Format("{0," + (Console.WindowWidth - 22) + "}", "Tryck Enter för att " + pressToContinue));
            Console.ReadLine();
            Console.Clear();
        } 
    }
}






