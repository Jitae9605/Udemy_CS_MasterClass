using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section02_DataTptes_And_Variables
{
	class String조작방법
	{
		static void Main(string[] args)
		{
			int age = 30;
			string name = "LEE";
			string job = "개발자";

			// 1. string 연결
			Console.WriteLine("my Name is " + name);

			// 2. string 포매팅
			Console.WriteLine("my Name is {0}, I am {1} years old. I'm a {2}", name, age, job );

			// 3. string 보간
			Console.WriteLine($"my Name is {name}, I am {age} years old. I'm a {job}");

			// 4. Verbatim string = 축자 문자열
			// " " 사이의 \n과 같은 이스케이프 문자의 기능을 무시하고 그 자체로 사용한다 (실제 출력할때는 모두 작동함)
			// 즉, 경로적을때, 한눈에 알아보기 편하게 긴 문자열등을 정렬할때 사용
			Console.WriteLine(@"my Name is {name}, 
								I am {age} years old.
								I'm a {job}");
			Console.WriteLine(@"my Name is {name}, \n I am {age} years old. \n I'm a {job}");
			Console.WriteLine("my Name is {name}, \n I am {age} years old. \n I'm a {job}");
			Console.WriteLine(@"D:\Sources\Udemy_CS_MasterClass\Lecture\Section02_DataTptes_And_Variables\String조작방법.cs");




		}
	}
}
