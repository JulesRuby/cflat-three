namespace IinterfacesAndAbstractClasses
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

            Console.WriteLine($"User Dog:\n" +
                $"Name: {userDog.Name}\n" +
                $"Colour {userDog.Colour}\n" +
                $"Age: {userDog.Age}\n\n");

            userDog.Eat();


            Console.WriteLine("Let's make a CAT!");

            animalName = InputController.AcceptInput<string>("Choose a name for your cat");
            animalColour = InputController.AcceptInput<string>("What colour is your cat");
            animalAge = InputController.AcceptInput<int>("How old is it cat");


            Cat userCat = new Cat(animalName, animalColour, animalAge);

            Console.WriteLine($"User Cat:\n" +
               $"Name: {userCat.Name}\n" +
               $"Colour {userCat.Colour}\n" +
               $"Age: {userCat.Age}\n\n");

            userCat.Eat();

            string otherName;
            string otherColour;
            string otherHeight;
            int otherAge;

            Console.WriteLine("Lets create an OtherDog!");

            otherName = InputController.AcceptInput<string>("Choose a name for your dog");
            otherHeight = InputController.AcceptInput<string>("Choose a height for your dog");
            otherColour = InputController.AcceptInput<string>("What colour is your dog");
            otherAge = InputController.AcceptInput<int>("How old is it dog");

            OtherDog otherDog = new OtherDog(otherName,  otherColour, otherHeight,  otherAge);

            Console.WriteLine($"User Dog:\n" +
                $"Name: {otherDog.Name}\n" +
                $"Colour {otherDog.Colour}\n" +
                $"Colour {otherDog.Height}\n" +
                $"Age: {otherDog.Age}\n\n");

            otherDog.Eat();
            otherDog.Cry();




            otherName = InputController.AcceptInput<string>("Choose a name for your cat");
            otherHeight = InputController.AcceptInput<string>("Choose a height for your cat");
            otherColour = InputController.AcceptInput<string>("What colour is your cat");
            otherAge = InputController.AcceptInput<int>("How old is it cat");

            OtherCat otherCat = new OtherCat(otherName, otherColour, otherHeight, otherAge);

            Console.WriteLine($"User Dog:\n" +
                   $"Name: {otherCat.Name}\n" +
                   $"Colour {otherCat.Colour}\n" +
                   $"Colour {otherCat.Height}\n" +
                   $"Age: {otherCat.Age}\n\n");
            otherCat.Eat();
            otherCat.Cry();

            List<IAnimal> animals = new List<IAnimal>
            {
                 new OtherDog("Buddy", "Golden", "55\"", 4),
                    new OtherDog("Rex", "Black", "60\"", 5),
                    new OtherCat("Whiskers", "White", "30\"", 3),
                    new OtherCat("Mittens", "Gray", "12\"", 2)
            };

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Name);
            }




        }
    }
}
