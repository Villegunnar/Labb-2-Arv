using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Labb2
{
    class Human : Animals
    {
        public int cSharpLevel = 9000;

        public Human(string humanType = "saknas", string humanName = "saknas", int humanAge = 0, string humanGender = "saknas", double humanHeight = 0, double humanWeight = 0) : base(humanType, humanName, humanAge, humanGender, humanHeight, humanWeight)
        {
        }
        public override void makeSound()
        {
            Thread.Sleep(1000);
            Console.Write("Tjääna! ");
            Thread.Sleep(1000);
            Console.WriteLine("Tjääna!");
            Thread.Sleep(1000);
        }
        public void CSharpSkills()
        {
            TextLooper("Grattis Viktor, du har nått level " + cSharpLevel + " i C#", 0, 50);   
        }
    }
}
