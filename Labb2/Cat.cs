using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Labb2
{
    public class Cat : Animals
    {
        public int climbingLevel = 50;

        public Cat(string catType = "saknas",string catName = "saknas", int catAge = 0, string catGender = "saknas", double catHeight = 0, double catWeight= 0) : base(catType,catName,catAge,catGender,catHeight,catWeight)
        {
        }
        public void Climbing()
        {
            climbingLevel++;
            TextLooper(name + "s klättringshastighet gick up till nivå " + climbingLevel,0,50);
        }
        public override void makeSound()
        {
            Thread.Sleep(1000);
            Console.Write("Mjaaauuu! ");
            Thread.Sleep(1000);
            Console.WriteLine("Mjaaauuu!");
            Thread.Sleep(1000);
        }
        public override void eatFood()
        {
            TextLooper(name + " äter",0,50);
        }
    }
}
