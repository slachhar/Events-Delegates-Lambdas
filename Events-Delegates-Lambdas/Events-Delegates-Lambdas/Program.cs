//using Listener;
using System;

namespace Events_Delegates_Lambdas
{
	public delegate int BizData(int x, int y);
	public class Program
	{
		private static void Main(string[] args)
		{
			// Console.WriteLine("Hi, I am source!");

			// WorkPerformedHandler del1 = new WorkPerformedHandler(FunctionForDelegate1);
			// WorkPerformedHandler del2 = new WorkPerformedHandler(FunctionForDelegate2);
			// WorkPerformedHandler del3 = new WorkPerformedHandler(FunctionForDelegate3);

			// del1 = del1 + del2 + del3;
			// del1(1, WorkType.Engineer);
			//Proces

			BizData del = (x, y) => x + y;
			ProcessData pro = new ProcessData();
			pro.process(2, 4, del);

			Worker worker = new Worker();
			worker.WorkPerformed += (s, e) => Console.WriteLine("Work performed for " + e.Hours + " hours by " + e.WorkType);
			worker.WorkCompleted += (s, e) => Console.WriteLine("Work Completed");
			worker.DoWork(8, WorkType.Engineer);
			Console.ReadLine();
		}

		//public static void worker_WorkPerformed(object sender, WorkPerformedEventArgs e)
		//{
		//	Console.WriteLine("Work performed for " + e.Hours + " hours by " + e.WorkType);
		//}

		//public static void worker_Completed(object sender, EventArgs e)
		//{
		//	Console.WriteLine("Work Completed");
		//}
		// public static void FunctionForDelegate1(int hours, WorkType workType)
		// {
		//     Console.WriteLine("1. Work Performed by {0} in hours {1}", hours, workType);
		// }

		// public static void FunctionForDelegate2(int hours, WorkType workType)
		// {
		//     Console.WriteLine("2. Work Performed by {0} in hours {1}", hours, workType);
		// }

		// public static void FunctionForDelegate3(int hours, WorkType workType)
		// {
		//     Console.WriteLine("3. Work Performed by {0} in hours {1}", hours, workType);
		// }
	}

	public enum WorkType
	{
		Engineer,
		Manager,
		QA
	}
}
