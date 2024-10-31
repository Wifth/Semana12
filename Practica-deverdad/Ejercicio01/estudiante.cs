using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    internal class estudiante
    {
        byte[] edades = new byte[0];
        int posicion = 0;

        public void insertar()
        {
            byte ed;
            string seguir;
            do
            {
                Console.Write("\nIngrese edad: ");

                while (!byte.TryParse(Console.ReadLine(), out ed) || ed < 14 || ed > 120)
                {
                    Console.Write("Eror: Ingrese edad: ");
                }
                Array.Resize(ref edades, edades.Length + 1);
                edades[posicion] = ed;
                posicion++;
                Console.WriteLine("Edad ingresada con éxito!\n");
                Console.Write("Desea seguir registrando? [si]: ");
                seguir = Console.ReadLine().ToLower();
            } while (seguir == "si");
        }
        public void mostrar()
        {
            Console.SetCursorPosition(10, 12);
            Console.Write("POSICIÓN");
            Console.SetCursorPosition(30, 12);
            Console.Write("EDADES");
        }
    }
}
