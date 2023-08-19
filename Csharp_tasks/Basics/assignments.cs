//Write a program and continuously ask the user to enter a number or "ok" to exit. Calculate the sum of all the previously entered 
//numbers and display it on the console.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_basics
{
	class Program
	{
		static void Main(string[] args)
		{
                Console.WriteLine("enter the number or enter ok to exit");
                var sum = 0;
                while (true)
                {
                    var input = Console.ReadLine();
                    if (input.ToLower() == "ok")
                        break;
                    if(int.TryParse(input,out int res))
                        sum = sum + int.Parse(input);
                }
                Console.WriteLine("The sum of digits is: " + sum);
        }
    }
}
	

