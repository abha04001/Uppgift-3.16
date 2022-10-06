using System;

//Uppgift 3.16

public class Program
{
	public static void Main()
	{

		Console.WriteLine("Hur lång är din låt. ? ");
		int time = int.Parse(Console.ReadLine());
		int minimum = int.Parse(Console.ReadLine());
		int total = (time * 60) + minimum;
		int x = 260;
		int y = 165;

		
		if (total >= x)                                                                                                                                       
		{
			Console.WriteLine(" din låt får vara med Radion! ");
		}

		else if (total >= y)
		{
			Console.WriteLine("Din låt får vara med Radion!");
		}


		else { Console.WriteLine("tyvär så kan vi inte lägga din låt i Radion!"); }







	}
}