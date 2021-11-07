using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Labb2
{
    class Dog : Animals
    {
        public string owner = "empty";

        public Dog(string dogType = "saknas", string dogName = "saknas", int dogAge = 0, string dogGender = "saknas", double dogHeight = 0, double dogWeight = 0) : base(dogType, dogName, dogAge, dogGender, dogHeight, dogWeight)
        {
            
        }
        public void Owner(string tempOwner)
        {
            owner = tempOwner;
            TextLooper("Min ägare heter " + owner,0,50);
        }
        public override void makeSound()
        {
            Thread.Sleep(1000);
            Console.Write("Woof! ");
            Thread.Sleep(1000);
            Console.WriteLine("Woof!");
            Thread.Sleep(1000);
        }
        public override void eatFood()
        {
            TextLooper(name +" äter...",0,50);
        }
    }
}
