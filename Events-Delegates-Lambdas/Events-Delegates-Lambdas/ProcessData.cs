using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Delegates_Lambdas
{
	
	public class ProcessData
	{
		public void process(int x, int y, BizData del)
		{
			var result = del(x, y);
			Console.WriteLine("Result: " + result);
		}

        public void process(int x, int y, Action<int, int> del)
        {
            del(x, y);
        }

        public void processFunc(int x, int y, Func<int, int, int> del)
        {
            var result = del(x, y);
            Console.WriteLine("The func result: " + result);
        }
    }
}
