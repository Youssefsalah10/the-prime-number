using System;
using System.Linq;

namespace Lab1
{
	public static class Program
	{
		public static void Main()
		{
         bool flag = true;
         Console.WriteLine("please enter num1");
         int num1 = int.Parse(Console.ReadLine());
         Console.WriteLine("please enter num2");
         int num2 = int.Parse(Console.ReadLine ());
         
         for (int num = num1 ; num <= num2 ; num++)
         { 
         	for (int j = 2 ; j <= num2 ; j++)
         	{ 
         		if (num != j && num % j == 0)
         		{
         			flag = false;
         			break;
         		}
         	}
         	 if (flag)
         	 {
         	 	Console.WriteLine("the prime number between num1 and num2 is " + num);
         	 }
         	 flag = true;
         }
         
		}
	}
}