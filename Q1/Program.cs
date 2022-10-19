using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("請輸入一個數字");
			string input = Console.ReadLine();
			int number =Convert.ToInt32(input);
			double d1 = Math.Sqrt(number);
			int sqrt = (int)d1;
			
			bool num = true;
			for(int i = 2; i <=sqrt; i++)
			{
				if (number % i == 0)
				{
					num = false;
					break;
				}
			}
			if (num == false||number<=1)
			{
				Console.WriteLine("此數不是質數");
			}
			else
			{
				Console.WriteLine("此數是質數");
			}
		}
	}
}
