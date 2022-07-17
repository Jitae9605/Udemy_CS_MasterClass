using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section03_Function_Method_And_HowToSaveTime
{
	class 메소드_반환값_매개변수
	{
		// 매개변수를 받고 반환값이 있는 메소드
		static void Main(string[] args)
		{
			// 메소드의 사용 및 반환값 받기와 활용방법
			Console.WriteLine("--------------------------------------");

			// 변수에 메소드 반환값 저장
			int result = Add(15, 31);
			Console.WriteLine(result);

			// 반환값 바로 출력
			Console.WriteLine(Add(30,81));

			// 반환값을 메소드의 매개변수로 활용
			Console.WriteLine(Add(Add(1, 2), Add(10, 20)));
			Console.WriteLine(Multiply(Add(1, 2), Add(10, 20)));

			// int / int = int 이므로 반환값이 double 이라도 3.33333의 뒤를 모두 버리고 반환될때 3.0만 반환되어
			// 반환형이 double임에도 출력은 심플하게 3이된다.
			Console.WriteLine(Devide1(10, 3));

			// 이를 막으려면 매개변수를 double로 바꿔야한다.
			// 그러면 int형이 매개변수로 와도 메소드에서 자동으로 10.0과 3.0으로 인지해서
			//  double / double = double 이 된다.
			Console.WriteLine(Devide2(10, 3));


			Console.WriteLine("--------------------------------------");

			Console.Read();
		}

		public static int Add(int num1, int num2)
		{

			return num1 + num2;
		}

		public static int Multiply(int num1, int num2)
		{
			return num1 * num2;
		}

		public static double Devide1(int num1, int num2)
		{
			return num1 / num2;
		}

		public static double Devide2(double num1, double num2)
		{
			return num1 / num2;
		}

	}
}
