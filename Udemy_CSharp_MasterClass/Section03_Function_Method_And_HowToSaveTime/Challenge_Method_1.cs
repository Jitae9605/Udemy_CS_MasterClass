using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section03_Function_Method_And_HowToSaveTime
{
	class Challenge_Method_1
	{
		static void Main(string[] args)
		{
			string friend1 = "Frank";
			string friend2 = "Michael";
			string friend3 = "Wlad";

			GreetFriend(friend1, friend2, friend3);
			Console.Read();


		}
		public static void GreetFriend(string friendName1, string friendName2, string friendName3)
		{
			Console.WriteLine("Hi " + friendName1 + ", my friend!");
			Console.WriteLine("Hi " + friendName2 + ", my friend!");
			Console.WriteLine("Hi " + friendName3 + ", my friend!");

		}
	}
}
