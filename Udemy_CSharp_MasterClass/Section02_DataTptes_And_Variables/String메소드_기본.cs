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
			Console.WriteLine("1. 대문자로");
			string message_Upper = message.ToUpper();
			Console.WriteLine(message_Upper + '\n');

			// 2. 소문자로
			Console.WriteLine("2. 소문자로");
			string message_lower = message_Upper.ToLower();
			Console.WriteLine(message_lower + '\n');

			// 3. 대상의 인덱스번호찾기
			Console.WriteLine("3. 인덱스번호찾기");
			int whereisit = message.IndexOf("name");
			int whereisit2 = message.IndexOf('L');
			Console.WriteLine(whereisit);
			Console.WriteLine(whereisit2 + '\n');

			// 4. 문자열자르기(앞쪽부터 개수만큼까지 잘라서 버리고 뒤의 문자열을 반환)
			Console.WriteLine("4. 문자열자르기");
			string message_substring = message.Substring(3); // 앞에서 부터 3개의 문자를 잘라서 버림 = "My "를 버림
			string message_substring2 = message.Substring(3,6); // 3번요소 부터 6개의 문자를 반환 = "name i" = message[3] ~ message[9] 
		
			Console.WriteLine(message_substring);
			Console.WriteLine(message_substring2 + '\n');

			// * 응용( 3 + 4 )
			Console.WriteLine("5. 응용(3 + 4)");

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

			// 7. string의 앞뒤에 있는 화이트스페이스 삭제(' ')
			string message_trim = "        Trim              ".Trim();
			Console.WriteLine(message_trim + '\n');

			// 8. string이 비었거나 ' '만 있을경우
			string message_null = null;
			string message_whitespace = "       ";
			Console.WriteLine(String.IsNullOrWhiteSpace(message_null));
			Console.WriteLine(String.IsNullOrWhiteSpace(message_whitespace));
			Console.WriteLine();


			// 응용 및 활용 방법의 예시
			Console.WriteLine("\n-------------- 응용 및 활용 방법의 예시 -------------------\n");
			string firstName = "Denis ";
			string lastName = "Panjuta";
			string fullName = string.Concat("    ", firstName, lastName, "     "); // 반환 = " DenisPanjuta "
			Console.WriteLine(firstName.Substring(2)); // 반환 = "nis "
			Console.WriteLine(firstName.ToLower()); // 반환 = "denis "
			Console.WriteLine(firstName.ToUpper()); // 반환 = "DENIS "
			Console.WriteLine(fullName.Trim()); // 반환 = "Denis Panjuta"

			Console.WriteLine("\n-------------- 응용 및 활용 방법의 예시2 -------------------\n");
			string Myname;

			Console.Write("Please enter your name and press enter : ");
			Myname = Console.ReadLine();
			string myNameUpperCase = string.Format("Upper case : {0}", Myname.ToUpper());
			string myNameLowerCase = string.Format("Lower case : {0}", Myname.ToLower());
			string myNameTrimCase = string.Format("Trim case : {0}", Myname.Trim());
			string myNameSubStringCase = string.Format("SubString case : {0}", Myname.Substring(0,5));

			Console.WriteLine(myNameUpperCase);
			Console.WriteLine(myNameLowerCase);
			Console.WriteLine(myNameTrimCase);
			Console.WriteLine(myNameSubStringCase);

			Console.WriteLine("\n-------------- 응용 및 활용 방법의 예시3 -------------------\n");

			Console.Write("Please enter string : ");
			string input = Console.ReadLine();

			Console.Write("Enter a character to serach: ");
			char searchInput = Console.ReadLine()[0];

			int searchIndex = input.IndexOf(searchInput);
			Console.WriteLine("Idex of character {0} in string is  {1}", searchInput, searchIndex);

			Console.WriteLine("Enter first name : ");
			string firstname_1 = Console.ReadLine();

			Console.WriteLine("Enter last name : ");
			string lastname_1 = Console.ReadLine();

			string fullname_1 = string.Concat(firstname_1, " ", lastname_1);
			Console.WriteLine("Your full name is {0}", fullname_1);

			Console.WriteLine("\n-------------- 응용 및 활용 방법의 예시3 -------------------\n");


			Console.ReadKey();
		}
	}
}
