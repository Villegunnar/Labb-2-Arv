using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Labb2
{
    public class GreatWhiteShark : Shark
    {
        public int childrenEaten = 6;

        public GreatWhiteShark(string sharkType = "saknas", string sharkName = "saknas", int sharkAge = 0, string sharkGender = "saknas", double sharkHeight = 0, double sharkWeight = 0) : base(sharkType, sharkName, sharkAge, sharkGender, sharkHeight, sharkWeight)
        {
        }
        public void HumansAndChildrenEaten(int tempKillCount = 0, int tempChildrenEaten = 0)
        {
            killCount = tempKillCount;
            childrenEaten = tempChildrenEaten;
            TextLooper("Under min livstid har jag ätit " + killCount + " människor\nvarav " +childrenEaten+" av dessa har varit barn.",0,50);
        }
        public override void makeSound()
        {
            Thread.Sleep(1000);
            Console.Write("Raaawwr!.. ");
            Thread.Sleep(1000);
            Console.WriteLine("Raaawwr!..");
            Thread.Sleep(1000);
        }
    }
}
