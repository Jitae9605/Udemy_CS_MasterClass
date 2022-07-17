using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section02_DataTptes_And_Variables
{
	class 자료형캐스팅
	{
		static void Main(string[] args)
		{
			// 1. double to int
			// 뒷자리(소수점) 다버림 ( ex 19.99 == 19 )
			double double_num = 13.37;
			int int_num;

			int_num = (int)double_num;
			Console.WriteLine(int_num);
			Console.WriteLine();

			// 2. somethings(int,char.....) to sting
			bool ture_bool = true; 
			string mystring1 = double_num.ToString();
			string mystring2 = ture_bool.ToString();
			Console.WriteLine(mystring1);
			Console.WriteLine(mystring2);
			Console.WriteLine();


			// 3. string to int,doulbe..
			string mystring3 = "153222";
			string mystring4 = "100000";
			int string_to_int1 = Int32.Parse(mystring3);
			int string_to_int2 = Int32.Parse(mystring4);
			int result_1 = string_to_int1 + string_to_int2;
			Console.WriteLine(result_1);
			Console.WriteLine();

			string stringForFloat = "0.85"; // datatype should be float
			string stringForInt = "12345"; // datatype should be int
			float a = float.Parse(stringForFloat);
			int b = Int32.Parse(stringForInt);

		}
	}
}
