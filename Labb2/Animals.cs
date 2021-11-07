using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Labb2
{
    public class Animals
    {
        public string type;
        public string name;
        public int age;
        public string gender;
        public double height;
        public double weight;
        
        public Animals(string animalType = "saknas", string animalName = "saknas", int animalAge = 0, string animalGender = "saknas", double animalHeight = 0, double animalWeight = 0)
        {
            type = animalType;
            name = animalName;
            age = animalAge;
            gender = animalGender;
            height = animalHeight;
            weight = animalWeight;
        }
        public static void TextLooper(string tempText= "", int tempCenterText = 0, int temptextSpeed = 0, bool tempCenter = true) 
        {
            int centerText = tempCenterText;
            string text = tempText;
            int textSpeed = temptextSpeed;
            bool center = tempCenter;
            if (center)
            {
                Console.Write(String.Format("{0," + (Console.WindowWidth - centerText) + "}", ""));
            }
            for (int i = 0; i < text.Length; i++)
            {
                Thread.Sleep(textSpeed);
                Console.Write(text[i]);

            }
                Console.WriteLine();
        }
        public virtual void PrintInfromation() 
        {
            TextLooper("Jag är en "+ type + " som heter "+name+ "!\nJag är en " + age+" år gammal "+gender+" som väger "+ weight+" kg och är "+height+" cm lång",0, 50);
            Console.WriteLine();
        }
        public virtual void makeSound() 
        {
            Console.WriteLine(type + " gör djur ljud...");
        }
        public virtual void eatFood() 
        {
            TextLooper(name +" äter...",0,50);
        }
        public virtual void sleeping()
        {
            TextLooper(name + " sover...ZZZZzzz...",0,50);

        }
        public void welcomeNewAnimal()
        {
            TextLooper("Välkommen till Z00 Gunnarsson "+ name +"! berätta för oss vem du är. ", 67, 0);
        }     
    }
}
