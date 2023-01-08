namespace LogicalProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Logical Programs");
            Console.WriteLine("Select the Program\n1.Fibonacci Series\n2.PerfectNumber\n3.PrimeNumber");
            Console.WriteLine("Choose option");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    LogicalSolutions.Fibonacci();
                    break;
                case 2:
                    LogicalSolutions.FindPerfectNumber();
                    break;
                case 3:
                    LogicalSolutions.PrimeNumber();
                    break;
            }
        }
    }
}