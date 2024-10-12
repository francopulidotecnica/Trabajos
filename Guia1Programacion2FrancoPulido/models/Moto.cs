using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia1Programacion2FrancoPulido.models
{
    public class Moto
    {
        public string Marca { get; private set; }
        public int Modelo { get; private set; }
        public double ValorFabricacion {  get; private set; }

        double Valor;

        public Moto(string marca, int modelo, double valorFabricacion) 
        {
            Marca = marca;
            Modelo = modelo;
            ValorFabricacion = valorFabricacion;
        }

        public double CalcularDepreciacionAnual(int añoACalcular, double tasaDepreciacion)
        {
            return ValorFabricacion * (Math.Pow(1 - 0.1, añoACalcular - Modelo));
        }

        public double CalcularDepreciacionLineal(int añoACalcular, int vidaUtil)
        {
            return ValorFabricacion - (ValorFabricacion * (añoACalcular - Modelo) / vidaUtil);
        }


        public string VerDescripcion()
        {
            return $"Marca:{Marca}, Modelo:{Modelo}, Valor Fabriación:${ValorFabricacion}";
            
        }
    }
}
