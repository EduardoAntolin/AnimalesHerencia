using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class AnimalTerrestre : Animal
    {
        public void Caminar()
        {
            Console.WriteLine("Hola soy un " + nombre + " y estoy caminando");
        }
    }
}
