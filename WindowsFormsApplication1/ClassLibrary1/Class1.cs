using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{

    class operaciones
    {
        public bool pasaje (string num)
        {
            try
            {
                double n = Convert.ToDouble(num);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public double sumar(double a, double b)
        {
            return a + b;
        }

        public double resta(double a, double b)
        {
            return a - b;
        }

        public double producto(double a, double b)
        {
            return a * b;
        }

        public double division(double a, double b)
        {
            return a / b;
        }
    }
}
