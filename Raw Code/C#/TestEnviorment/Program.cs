namespace TestEnviorment
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Before a variable can be stored it has to
            be declared what type of data it is. */

            int Banana; // Declaration
            Banana = 1000; // Initialazion

            int Black_Banana = 800; // The same but in one line of code.

            int Racism = Banana + Black_Banana;

            int age = 15;

            Console.WriteLine("Your age is "+age);

            Console.WriteLine(Banana);
            Console.WriteLine(Black_Banana);
            Console.WriteLine(Racism);

            Console.ReadKey();
        }
    }
}