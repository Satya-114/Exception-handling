using System;

namespace User_defined_Exception
{
    class Program
    {
        class MyException : ApplicationException 
        {
            public MyException()
            {
                Console.WriteLine("User defined exception");
            }
        }
        class MyClient
        {
            public static void Main()
            {
                try
                {
                    throw new MyException();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception caught here" + e.ToString());
                }
                Console.WriteLine("LAST STATEMENT");
            }
        }
    }
}


  
    

