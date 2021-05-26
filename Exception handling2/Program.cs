using System;

namespace Exception_handling_1
{
    class Program
    {

        public static void Main()
        {
            try
            {
                throw new DivideByZeroException("Invalid Division");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Exception");
            }
            Console.WriteLine("LAST STATEMENT");
            Console.ReadKey();
        }
    }
}
        


