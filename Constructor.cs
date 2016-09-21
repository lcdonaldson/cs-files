using System;

namespace Constructor
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var emp = new Employee(5, 102);
			Console.WriteLine($"years of employment: {emp.YearsOfService}");
			Console.WriteLine($"office number: {emp.Office}");
			Console.ReadLine();
		}

		public class Employee 
		{
			public int YearsOfService { get; set; }
			public int Office { get; set; }

			public Employee(int years, int office)
			{
				YearsOfService = years;
				Office = office;
			}
		}
	}
}
