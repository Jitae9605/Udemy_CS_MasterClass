using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section03_Function_Method_And_HowToSaveTime
{
	class 메소드_선언_매개변수
	{
		static void Main(string[] args)
		{
			// 만약 얘가 스태틱이 아닐경우 
			// 메소드_선언_매개변수 methodBasic = new 메소드기본();
			// methodBasic.WriteSomething();
			// 이렇게 써야함
			WriteSomething();
			WriteSomethingSpecitic("I am an argument and am called from a method");
			Console.Read();

		}

		// 스태틱
		// 스태틱은 메모리 할당전에 배치되고 종료전까지 끝까지 남아있는다.
		// ex1)
		// 스태틱이 아닌경우, A클래스의 객체를 new로 선언해 생성한다음 해당 객체로 호출해야하지만
		// 스태틱인 경우, new 선언없이 'A클래스.메소드명()' 으로 바로 호출이 가능

		public static void WriteSomething()
		{
			
			Console.WriteLine("I am called from a method");
		}

		public static void WriteSomethingSpecitic(string myText)
		{
			Console.WriteLine(myText);

		}
	}
}
