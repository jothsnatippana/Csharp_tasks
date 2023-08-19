using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_medium
{
	class Program
	{
		static void Main(string[] args)
		{
			var cal = new Calculator();
			//taking input
			Console.WriteLine("enter any two integers:");
			var str = Console.ReadLine();
			String[] str1 = str.Split(' ');
			int input1 = int.TryParse(str1[0], out int res) ? int.Parse(str1[0]) : 0;
			int input2 = int.TryParse(str1[1], out int res1) ? int.Parse(str1[1]) : 0;
			cal.Add(input1, input2);
			Console.WriteLine(cal.GetResult());
		
			Console.WriteLine("enter any three integers:");
			str = Console.ReadLine();
			string[] str2 = str.Split(' ');
			input1 = int.TryParse(str2[0], out int res2) ? int.Parse(str2[0]) : 0;
			input2 = int.TryParse(str2[1], out int res3) ? int.Parse(str2[1]) : 0;
			int input3 = int.TryParse(str2[2], out int res4) ? int.Parse(str2[2]) : 0;
			cal.Add(input1, input2, input3);
			Console.WriteLine(cal.GetResult());

			Console.WriteLine("enter any two integers:");
			str = Console.ReadLine();
			string[] str3 = str.Split(' ');
			float input4 = float.TryParse(str3[0], out float res5) ? float.Parse(str3[0]) : 0.0f;
			float input5 = float.TryParse(str3[1], out float res6) ? float.Parse(str3[1]) : 0.0f;
			cal.Add(input4, input5);
			Console.WriteLine(cal.GetResult());

			// calling advanced calculator
			var ac = new Advanced_Caculator();
			Console.WriteLine("enter two intergers line by line");
			int i1 = int.Parse(Console.ReadLine());
			int i2 = int.Parse(Console.ReadLine());
			ac.power(i1, i2);
			Console.WriteLine(ac.GetResult());
		}
	}
}
