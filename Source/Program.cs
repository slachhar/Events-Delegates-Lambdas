using Listener;
using System;

namespace Source
{
    internal class Program
    {
        public delegate void FirstDelegate(string name);

        private static void Main(string[] args)
        {
            Console.WriteLine("Hi, I am source!");

            FirstDelegate del1 = new FirstDelegate(ProgramListener.FunctionForDelegate1);
            FirstDelegate del2 = new FirstDelegate(ProgramListener.FunctionForDelegate2);
            FirstDelegate del3 = new FirstDelegate(ProgramListener.FunctionForDelegate3);

            del1 = del1 + del2 + del3;
            del1("Shefali");
            Console.ReadLine();
        }
        

    }
}
