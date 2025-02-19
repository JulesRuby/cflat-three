namespace IinterfacesAndAbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int testInt = InputController.AcceptInput<int>("What is the age of the animal");
            string testString= InputController.AcceptInput<string>("What is the age of the animal");
            double testDouble= InputController.AcceptInput<double>("What is the age of the animal");
        }
    }
}
