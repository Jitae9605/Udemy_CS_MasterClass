using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section04_Making_Decisions
{
	internal class Switch_기본
	{
		static void Main(string[] args)
		{
			int age = 25;
			switch(age)
            {
				case 15:
                    Console.WriteLine("Too young");
					break;
				case 30:
					Console.WriteLine("good");
					break;
				default:
					Console.WriteLine("How old you then?");
					break;
            }


			Console.Read();
		}
	}
}
