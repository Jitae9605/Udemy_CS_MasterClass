using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section04_Making_Decisions
{
	class if_else_TryParse
	{
		static void Main(string[] args)
		{
			string tempstring = Console.ReadLine();
			int temp, num;

			if(int.TryParse(tempstring, out num))
			{
				temp = num;
			}
			else
			{
				temp = 0;
			}

			if(temp < 10)
			{
				Console.WriteLine("take the coat");
			}
			else if(temp == 10)
			{
				Console.WriteLine("10 degrees");
			}
			else
			{
				Console.WriteLine("warm");
			}

			
			Console.Read();
		}
	}
}
