using System;
using CalculadoraFisicaLib;

namespace CalculadoraFisicaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();

            while (true)
            {
                Console.WriteLine("Seleccione el cálculo que desea realizar:");
                Console.WriteLine("1. Calcular Fuerza (F = m * a)");
                Console.WriteLine("2. Calcular Trabajo (W = F * d)");
                Console.WriteLine("3. Calcular Energía Cinética (E = 0.5 * m * v^2)");
                Console.WriteLine("4. Salir");

                int opcion = int.Parse(Console.ReadLine());

                if (opcion == 4)
                {
                    break;
                }

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese la masa (kg): ");
                        double masaF = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese la aceleración (m/s^2): ");
                        double aceleracion = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Fuerza: {calculadora.CalcularFuerza(masaF, aceleracion)} N");
                        break;

                    case 2:
                        Console.Write("Ingrese la fuerza (N): ");
                        double fuerza = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese la distancia (m): ");
                        double distancia = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Trabajo: {calculadora.CalcularTrabajo(fuerza, distancia)} J");
                        break;

                    case 3:
                        Console.Write("Ingrese la masa (kg): ");
                        double masaE = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese la velocidad (m/s): ");
                        double velocidad = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Energía Cinética: {calculadora.CalcularEnergiaCinetica(masaE, velocidad)} J");
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            }
        }
    }
}
