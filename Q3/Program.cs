using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
	internal class Program
	{
		static void Main(string[] args)
		{

			double number;
			for(int i = 1; i <=9; i++)
			{
				for(int k=0;k<=9;k++)
				{
					number = 1000 * i + 100 * i + 10 * k + k;
					for (int m = 1; m < 100; m++)
					{
						int n = m * m;
						if (number / n == 1)
						{
							Console.WriteLine(number);							
						}

					}
				}

			}
			
		}
	}
}
