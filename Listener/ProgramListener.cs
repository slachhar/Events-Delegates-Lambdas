using System;

namespace Listener
{
    public class ProgramListener
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I am Listener");
            Console.ReadLine();
        }

        public static void FunctionForDelegate1(String name)
        {
            Console.WriteLine("This is first delegate :" + name);
        }

        public static void FunctionForDelegate2(String name)
        {
            Console.WriteLine("This is 2nd delegate : " + name);
        }

        public static void FunctionForDelegate3(String name)
        {
            Console.WriteLine("This is 2nd delegate : " + name);
        }
    }
}
