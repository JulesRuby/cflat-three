﻿namespace IinterfacesAndAbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string animalName;
            string animalColour;
            int animalAge;


            Console.WriteLine("Let's play god! Let's create animals, YAAAAAAY!\nFirst we'll need to create a doggo!");

            animalName = InputController.AcceptInput<string>("Choose a name for your dog");
            animalColour = InputController.AcceptInput<string> ("What colour is your dog");
            animalAge = InputController.AcceptInput<int>("How old is it dog");

            Dog userDog = new Dog(animalName, animalColour, animalAge);

            Console.WriteLine($"User Dog:" +
                $"Name: {userDog.Name}" +
                $"Colour {userDog.Colour}" +
                $"Age: {userDog.Age}\n\n");

            userDog.Eat();


            Console.WriteLine("Let's make a CAT!");

            animalName = InputController.AcceptInput<string>("Choose a name for your cat");
            animalColour = InputController.AcceptInput<string>("What colour is your cat");
            animalAge = InputController.AcceptInput<int>("How old is it cat");


            Cat userCat = new Cat(animalName, animalColour, animalAge);

            Console.WriteLine($"User Cat:" +
               $"Name: {userCat.Name}" +
               $"Colour {userCat.Colour}" +
               $"Age: {userCat.Age}\n\n");


            userCat.Eat();

        }
    }
}
