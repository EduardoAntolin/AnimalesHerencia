using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Kanguro: AnimalTerrestre
    {
        public Kanguro()
        {
            nombre = "kanguro";
        }

        public void SaltarBienAltoxd()
        {
            Console.WriteLine("Hola, soy un " + nombre + " y esto es disney chanel también salto bien alto");
        }
    }
}
