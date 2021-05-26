using System;

namespace Exception_handling
{
    public class Program
    {
        int result = 0;
        public void division(int num1, int num2)
        {
            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Result: {0}", result);
            }
        }
        static void Main(string[] args)
        {
           Program  d = new Program();
            d.division(25, 0);
            Console.ReadKey();
        }
    }
}
