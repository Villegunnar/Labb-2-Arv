using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Labb2
{
    public class HammerHeadShark : Shark
    {
        public int BitePower = 50;

        public HammerHeadShark(string sharkType = "saknas", string sharkName = "saknas", int sharkAge = 0, string sharkGender = "saknas", double sharkHeight = 0, double sharkWeight = 0) : base(sharkType, sharkName, sharkAge, sharkGender, sharkHeight, sharkWeight)
        {
        }
        public void BitingPowerLvlUp()
        {
            BitePower++;

            TextLooper("Bitstyrka nivå gick up, du har nu " + BitePower + " i bitstyrka",0,50);
        }
        public override void makeSound()
        {
            Thread.Sleep(1000);
            Console.Write("wwraah... ");
            Thread.Sleep(1000);
            Console.WriteLine("wwraah...");
            Thread.Sleep(1000);
        }
    }
}
