using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("請輸入區間的下限");
			string input1 = Console.ReadLine();
			Console.Write("請輸入區間的上限");
			string input2 = Console.ReadLine();
			int start =Convert.ToInt32(input1);
			int end =Convert.ToInt32(input2);
			Console.WriteLine($"{start}到{end}之間的質數為:");
			for(int i=start;i<=end;i++)
			{
				for(int k=2;k<=end;k++)
				{
					if (i % k == 0 && i != k)
					{
						break;
					}
					if (i % k == 0 && i == k)
					{
						Console.WriteLine(i);
					}
				}
			}
		}
	}
}
