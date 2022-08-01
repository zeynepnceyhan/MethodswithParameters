namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            Add2(20, 30);
            Console.ReadLine();
        }
        static void Add()
        {
            Console.WriteLine("Added!!");
        }
        static int Add2(int number1, int number2)
        {
            var result = number1 + number2;
            Console.WriteLine("This numbers has been added!");
            return result;
        }


    }
}
