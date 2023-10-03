using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1._1_AndreaCastro
{
    public class Operaciones
    {
        public double Sumar(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Restar(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Dividir(double num1, double num2)
        {
            if (num2 != 0)
                return num1 / num2;
            else
                throw new DivideByZeroException("No se puede realizar la división entre cero.");
        }

        public double Multiplicar(double num1, double num2)
        {
            return num1 * num2;
        }
    }
}
