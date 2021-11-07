using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Labb2
{
    public class Bird : Animals
    {
        public int flightspeed;

        public Bird(string birdType = "saknas", string birdName = "saknas", int birdAge = 0, string birdGender = "saknas", double birdHeight = 0, double birdWeight = 0) : base(birdType, birdName , birdAge, birdGender , birdHeight , birdWeight)
        {
        }
        public void Flightspeed(int tempFlightspeed)
        {
            flightspeed = tempFlightspeed;
            TextLooper("Flyghastighet: " + flightspeed+"km/h",0,50);
        }
        public override void makeSound()
        {
            Thread.Sleep(1000);
            Console.Write("Hawk! ");
            Thread.Sleep(1000);
            Console.WriteLine("Hawk!");
            Thread.Sleep(1000);
        }
        public override void eatFood()
        {
            TextLooper(name +" äter...",0,50);
        }
    }
}
