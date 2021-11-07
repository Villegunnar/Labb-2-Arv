using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Labb2
{
    public class Shark : Animals
    {
        public int killCount;

        public Shark(string sharkType = "saknas", string sharkName = "saknas", int sharkAge = 0, string sharkGender = "saknas", double sharkHeight = 0, double sharkWeight = 0) : base(sharkType, sharkName, sharkAge, sharkGender, sharkHeight, sharkWeight)
        {
        }
        public void KillCount(int tempKillCount = 0)
        {
            killCount = tempKillCount;
            TextLooper("Under min livstid har jag ätit " + killCount+" människor",0,50);
        }

        public override void makeSound()
        {
            
            Thread.Sleep(1000);
            Console.Write("Blub... ");
            Thread.Sleep(1000);
            Console.WriteLine("Blub...");
            Thread.Sleep(1000);
        }
        public override void eatFood()
        {
            TextLooper(name + " käkar...",0,50);
        }
    }
}
