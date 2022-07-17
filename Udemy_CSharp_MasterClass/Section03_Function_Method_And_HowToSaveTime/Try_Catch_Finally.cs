using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section03_Function_Method_And_HowToSaveTime
{
	class Try_Catch_Finally
	{
		// Try 블록내에서 에러가 발생하면 catch블록의 내용이 실행
		// catch 블록은 여러개일수 있따.
		// 에러가 발생하든 안하든 finally 블록은 항상 실행된다.
		static void Main(string[] args)
		{
			Console.WriteLine("Please enter a number!");
			string userInput = Console.ReadLine();

			try
			{
				int userInputAsInt = int.Parse(userInput);
			}
			catch (FormatException)
			{
				Console.WriteLine("Format exception, please enter the correct type next time");
			}
			catch (OverflowException)
			{
				Console.WriteLine("Overflow exception, please enter correct size for int32 next time");
			}
			catch (ArgumentNullException)
			{
				Console.WriteLine("ArgumentNullException exception, the value is empty(null)");
			}
			catch (Exception e)
			{
				Console.WriteLine($"General Exception = {e}");
			}
			finally
			{
				Console.WriteLine("This is called anyways!");
			}

			int num1 = 5;
			int num2 = 0;
			int result;

			try
			{
				result = num1 / num2;
			}
			catch (DivideByZeroException)
			{

				Console.WriteLine("Can't devide by zero!");
			}
			


			Console.Read();
		}
	}
}
