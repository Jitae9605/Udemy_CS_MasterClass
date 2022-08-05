using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section04_Making_Decisions
{
	class if_관리자구분
	{
		static void Main(string[] args)
		{
			bool IsAdmin = false;
			bool isRegistered = true;
			string userName = "";
			Console.WriteLine("Please enter your username");

			userName = Console.ReadLine();
			if(isRegistered && userName != "" && userName.Equals("admin"))
			{
				Console.WriteLine("Hi there, registered user");
				
				Console.WriteLine("Hi there, " + userName);
					
				Console.WriteLine("Hi there, Admin");
			}

			if(IsAdmin || isRegistered)
			{
				Console.WriteLine("You are logeed in");
			}
		}
	}
}
