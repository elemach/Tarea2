using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string[] empleados = {"Jose", "Alberto", "Juan"};
            float[] salarios = {130, 150, 200};
            float c = 0;
            foreach (string item1 in empleados)
            {
                for (int i = 0; i < salarios.LongLength; i++)
                {
                    c= salarios[i];
                    Console.WriteLine("El salario de " + item1 + " es de: " + c + " y su aguinaldo es de: ");
                    aguinaldo(c);
                }
            }
            Console.ReadKey();
        }
        public static void aguinaldo(float nuevosalario)
        {
            nuevosalario *= 12;
            Console.WriteLine(nuevosalario);
            
        }
    }
}
