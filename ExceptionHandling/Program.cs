using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's test exception handling and how nesting works with it!");
            ExceptionMethod1();
        }

        public static void ExceptionMethod1()
        {
            try
            {
                ExceptionMethod2();
                // throw new Exception("ExceptionMethod1 Message");
            }
            catch(Exception ex)
            {
                Console.WriteLine("ExceptionMethod1: " + ex.Message);
            }
        }
        
        public static void ExceptionMethod2()
        {
            try
            {
                ExceptionMethod3();
                throw new Exception("ExceptionMethod2 Message");
            }
            catch(Exception ex)
            {
                Console.WriteLine("ExceptionMethod2: " + ex.Message);
            }
        }

        public static void ExceptionMethod3()
        {
            try
            {
                throw new Exception("ExceptionMethod3 Message");
            }
            catch(Exception ex)
            {
                Console.WriteLine("ExceptionMethod3: " + ex.Message);
                throw new Exception("ExceptionMethod3: Exception within catch");
            }
        }
    }
}
