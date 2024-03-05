using System;
using System.Text.RegularExpressions;

class Program
{
	static void Main()
	{
		Console.WriteLine("Enter a username: ");
		string userInput = Console.ReadLine();

		string pattern = "^[a-zA-Z0-9]*$";

		Regex regex = new Regex(pattern);

		if (regex.IsMatch(userInput))
		{
			Console.WriteLine("Username is valid!");
		}
		else
		{
			Console.WriteLine("Username contains invalid characters. Please try again.");
		}
	}
}