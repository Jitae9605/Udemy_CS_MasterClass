using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section02_DataTptes_And_Variables
{
	public class String메소드
	{
		static void Main(string[] args)
		{
			// string 메소드
			string myname = "Lee";
			string message = "My name is " + myname;

			// 메소드(반환이다 받아야한다)
			// 1. 대문자로
			string message_Upper = message.ToUpper();
			Console.WriteLine(message_Upper + '\n');

			// 2. 소문자로
			string message_lower = message_Upper.ToLower();
			Console.WriteLine(message_lower + '\n');

			// 3. 대상의 인덱스번호찾기
			int whereisit = message.IndexOf("name");
			int whereisit2 = message.IndexOf('L');
			Console.WriteLine(whereisit);
			Console.WriteLine(whereisit2 + '\n');

			// 4. 문자열자르기(앞쪽부터 개상까지 잘라 버림
			string message_substring = message.Substring(3);
			Console.WriteLine(message_substring + '\n');

			// * 응용
			string message_app1 = message.Substring(message.IndexOf("name"));
			string message_app2 = message.Substring(message.IndexOf("is"));
			string message_app3 = message.Substring(message.IndexOf("Lee"));
			Console.WriteLine(message_app1);
			Console.WriteLine(message_app2);
			Console.WriteLine(message_app3 + '\n');

			// 5. 대상 교체
			string message_replace = message.Replace("Lee", "jitae");
			Console.WriteLine(message_replace + '\n');

			// 6. 기준으로 나누기(string[] 반환)
			string[] message_split = message.Split(' ');
			foreach(string part in message_split)
				Console.WriteLine(part);
			Console.WriteLine();







		}
	}
}
