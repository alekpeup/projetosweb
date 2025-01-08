/*
 * Created by SharpDevelop.
 * User: alekb
 * Date: 21/09/2024
 * Time: 13:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace comeon
{
	public class User
	{
		//propriedades
		public string UserName{get; set;}
		public string UserAge{get; set;}
		public string UserAddress{get; set;}
		
		public int greeting()
		{	
			string username = Console.ReadLine();
			Console.WriteLine();
			return 0;
		}
	}
	
	class Program
	{
		public static void Main(string[] args)
		{
			User person1 = new User
			{
				 
			};
		
		}	
	}
}