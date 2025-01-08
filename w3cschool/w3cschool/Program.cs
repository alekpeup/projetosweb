/*
 * Created by SharpDevelop.
 * User: alekb
 * Date: 01/10/2024
 * Time: 12:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace w3cschool
{
	class Program
	{
		static void Main(string[] args)
		{	
			string msg = $"Hello {nome}, seja bem vindo";
		
			Console.WriteLine("Seja bem ao nosso app.");
			Console.WriteLine("Por favor insira seus dados de login");
			
			Console.Write("Insira a seu nome: ");
			string nome = Console.ReadLine();
			Console.WriteLine("Insira sua senha: ");
			string senha = Console.ReadLine();
			
			Console.WriteLine();
			
			
			
			Console.ReadKey(true);
			
		}
	}
}