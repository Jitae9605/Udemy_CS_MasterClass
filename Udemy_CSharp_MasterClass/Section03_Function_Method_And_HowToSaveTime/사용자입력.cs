using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section03_Function_Method_And_HowToSaveTime
{
	class 사용자입력
	{
		static void Main(string[] args)
		{
			// 콘솔로 한줄전체를 입력받아 string으로 입력을 받아서 input에 저장함
			string input = Console.ReadLine();
			Console.WriteLine(input);


			// 사용자입력을 통해 2개의 수를 차례로 입력받아 함산을 구하는 계산메소드 작성
			Console.WriteLine(Calculate());
			Console.Read();
		}

		 public static int Calculate()
		 {
			Console.WriteLine("Please enter the first number");
			string num1Input = Console.ReadLine();
			Console.WriteLine("Please enter the second number");
			string num2Input = Console.ReadLine();

			int num1 = int.Parse(num1Input);
			int num2 = int.Parse(num2Input);

			int result = num1 + num2;
			return result;
		 }

	}
}
