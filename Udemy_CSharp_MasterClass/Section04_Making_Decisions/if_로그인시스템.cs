using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section04_Making_Decisions
{
	class if_로그인시스템
	{
		static string username;
		static string password;

		static void Main(string[] args)
		{
			Register();	// 등록
			Login();	// 등록된아이디를 통한 로그인
			Console.Read();
		}

		public static void Register()
		{
			Console.WriteLine("Please enter your username");
			username = Console.ReadLine();	
			Console.WriteLine("Please enter your password");
			password = Console.ReadLine();	
			Console.WriteLine("Registration Complete!");

		}

		public static void Login()
		{
			Console.WriteLine("Please enter your username");

			if (username == Console.ReadLine())
			{
				Console.WriteLine("Please enter your password");
				if (password == Console.ReadLine())
				{
					Console.WriteLine("Login successful");
				}
				else
				{
					Console.WriteLine("Login failed, wrong password. Restart Program");
				}
			}
			else
			{
				Console.WriteLine("Login failed, wrong username. Restart Program");
			}
		}

	}
}
