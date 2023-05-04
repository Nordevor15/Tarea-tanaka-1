using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    class Circulo
    {
        private float r;
        private float pi = 3.14f;

        public Circulo(float r)
        {

            this.r = r;
        }

        public float Area()
        {
            return pi * (r * r);
        }

        public float Perimetro()
        {
            return 2 * pi * r;
        }

       
        
    }
}
