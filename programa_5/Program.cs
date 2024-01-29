using System;

namespace programa_5 
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Este programa te permite saber el promedio de 3 valores, ingrese el primer numero: ");
			try
			{

				int numero1 = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Ingrese el segundo numero: ");
				int numero2 = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Ingrese el tercer numero: ");
				int numero3 = Convert.ToInt32(Console.ReadLine());
				float promedio = (numero1 + numero2 + numero3) / 3;

				if (promedio >= 7)
				{
					Console.WriteLine("promocionado");

				}
				else
				{
                    Console.WriteLine("reprobado");
                }

			}
			catch (Exception ex)
			{
				Console.WriteLine($"a ocurrido un error: {ex.Message}");
			}
		}
	}
}