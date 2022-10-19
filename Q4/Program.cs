using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("百元百雞的答案為:");
			for(int cock=0;cock<=100; cock++)
			{
				for(int hen=0;hen<=100;hen++)
				{
					for(double chicken=0;chicken<=100;chicken++)
					{
						if(cock+hen+chicken==100&&5*cock+3*hen+chicken/3==100)
						{
							Console.WriteLine($"公雞有{cock}隻,母雞有{hen}隻,小雞有{chicken}隻");
						}
					}
				}
			}
		}
	}
}
