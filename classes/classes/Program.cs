/*
 * Created by SharpDevelop.
 * User: alekb
 * Date: 21/09/2024
 * Time: 12:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace classes
{
	
	public class Truck
	{
		// propriedades da Classe 
		public string Color {get; set;}
		public int Wheels {get; set;}
		
		
		// método da classe 
		public void Mover()
		{
			Console.WriteLine($"The truck {Color} has {Wheels} wheels");
		}
	}
	

	class Program
	{
		public static void Main(string[] args)
		{
			string userInput = Console.ReadLine();
			
			
			Truck blueTruck = new Truck
			{
				Color = "Blue",
				Wheels = 4
			};
			
			Truck redTruck = new Truck 
			{
				Color = userInput,
				Wheels = 8
			};
			
			blueTruck.Mover();
			redTruck.Mover();
			
			Console.ReadLine();
		}
	}
}