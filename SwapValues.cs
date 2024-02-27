using System;

namespace SwapValues
{
	internal class SwapValues
	{
		static void Main(string[] args)
		{
			string secondName = "Петя";
			string firstName = "Иванов";
			string temp;

			Console.WriteLine($"До перестановки: фамилия - {secondName}, имя - {firstName}");

			temp = secondName;
			secondName = firstName;
			firstName = temp;
			Console.WriteLine($"После перестановки: фамилия - {secondName}, имя - {firstName}");
		}
	}
}
