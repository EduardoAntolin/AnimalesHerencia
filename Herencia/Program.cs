using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalAcuatico delfin = new AnimalAcuatico();
            AnimalTerrestre elefante = new AnimalTerrestre();
            Kanguro kanguro = new Kanguro();
            Animal tiburon = new AnimalAcuatico();

            List<Animal> animales = new List<Animal>();

            delfin.nombre = "Delfin";
            elefante.nombre = "Elefante";
            tiburon.nombre = "Tiburon";

            delfin.Comer();
            delfin.Nadar();


            elefante.Caminar();

            kanguro.Caminar();
            kanguro.SaltarBienAltoxd();
            kanguro.Comer();

            ((AnimalAcuatico)tiburon).Nadar();

            animales.Add(delfin);
            animales.Add(tiburon);
            animales.Add(elefante);
            animales.Add(kanguro);

            foreach(var animal in animales)
            {
                Console.WriteLine(animal.nombre);
                if(animal.GetType() == typeof(AnimalAcuatico))
                {
                    ((AnimalAcuatico)animal).Nadar();
                }
            }

            Console.ReadLine();
        }
    }
}
