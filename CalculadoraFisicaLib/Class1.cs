using System;

namespace CalculadoraFisicaLib
{
    public class Calculadora
    {
        /// <summary>
        /// Calcula la fuerza dados masa y aceleración.
        /// </summary>
        public double CalcularFuerza(double masa, double aceleracion)
        {
            return masa * aceleracion;
        }

        /// <summary>
        /// Calcula el trabajo dado por fuerza y distancia.
        /// </summary>
        public double CalcularTrabajo(double fuerza, double distancia)
        {
            return fuerza * distancia;
        }

        /// <summary>
        /// Calcula la energía cinética dados masa y velocidad.
        /// </summary>
        public double CalcularEnergiaCinetica(double masa, double velocidad)
        {
            return 0.5 * masa * Math.Pow(velocidad, 2);
        }
    }
}
