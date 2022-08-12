using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section03_Function_Method_And_HowToSaveTime
{
	class 연산자
	{
		static void Main(string[] args)
		{
			int num1 = 5;
			int num2 = 3;
			int num3;
			int result;

			// 마이너스 연산자
			num3 = -num1;
			Console.WriteLine("num3 is {0}", num3);

			// not연산자 = true는 false로 false는 true로 참/거짓을 바꿔주는 연산자
			bool isSunny = true;
			Console.WriteLine("is it sunny? {0}", !isSunny);

			// 증가연산자
			int num = 0;
			num++;
			Console.WriteLine("num is {0}", num); // 1

			// 증가연산자가 뒤에오면 먼저 그 줄의 명령을 실행하고 값을 증가시킨다.
			Console.WriteLine("num is {0}", num++); // 1
			Console.WriteLine("num is {0}", num);	// 2

			// 증가연산자가 앞에오면 먼저 증가시키고 그 증가된 값을 이용해 줄의 명령을 수행한다
			Console.WriteLine("num is {0}", ++num); // 3

			// 감소연산자
			// 증가연산자와 같지만 더하는게 아니라 뺀다(--num, num--)

			// 산술연산자
			result = num1 + num2;
			Console.WriteLine("result of num1 + num2 is {0}", result);
			result = num1 - num2;
			Console.WriteLine("result of num1 - num2 is {0}", result);
			result = num1 * num2;
			Console.WriteLine("result of num1 * num2 is {0}", result);
			result = num1 / num2;
			Console.WriteLine("result of num1 / num2 is {0}", result);
			result = num1 % num2;
			Console.WriteLine("result of num1 % num2 is {0}", result);


			// 관계연산자 / 타입연산자
			bool isLower;
			isLower = num1 < num2;
			Console.WriteLine("result of num1 < num2 is {0}", isLower);

			// 동일연산자
			bool isEqual;
			isEqual = num1 == num2;
			Console.WriteLine("result of num1 == num2 is {0}", isEqual);

			isEqual = num1 != num2;
			Console.WriteLine("result of num1 != num2 is {0}", isEqual);

			// 논리연산자(And = && / Or = ||)
			// AND
			bool isLowerAndSunny;
			isLowerAndSunny = isLower && isSunny;
			Console.WriteLine("result of isLower && isSunny is {0}", isLowerAndSunny);

			// OR
			bool isLowerOrSunny;
			isLowerOrSunny = isLower || isSunny;
			Console.WriteLine("result of isLower || isSunny is {0}", isLowerOrSunny);




			Console.Read();

		}

	}
}
