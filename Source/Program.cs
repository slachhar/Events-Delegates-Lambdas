using Listener;
using System;

namespace Source
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hi, I am source!");

            WorkPerformedHandler del1 = new WorkPerformedHandler(FunctionForDelegate1);
            WorkPerformedHandler del2 = new WorkPerformedHandler(FunctionForDelegate2);
            WorkPerformedHandler del3 = new WorkPerformedHandler(FunctionForDelegate3);

            del1 = del1 + del2 + del3;
            del1(1, WorkType.Engineer);
            Console.ReadLine();
        }

        public static void FunctionForDelegate1(int hours, WorkType workType)
        {
            Console.WriteLine("1. Work Performed by {0} in hours {1}", hours, workType);
        }

        public static void FunctionForDelegate2(int hours, WorkType workType)
        {
            Console.WriteLine("2. Work Performed by {0} in hours {1}", hours, workType);
        }

        public static void FunctionForDelegate3(int hours, WorkType workType)
        {
            Console.WriteLine("3. Work Performed by {0} in hours {1}", hours, workType);
        }
    }

    public enum WorkType
    {
        Engineer,
        Manager,
        QA
    }
}
