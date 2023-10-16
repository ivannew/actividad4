using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividad4.metodo
{
    internal class metodos
    {
        public void Filas()
        {
            int[,] t = new int[2, 3];

      
            int filas = t.GetLength(0);
            int columnas = t.GetLength(1);
            int elementos = filas * columnas;

          
            int elemento1 = t[1, 0];
            int elemento2 = t[1, 1];
            int elemento3 = t[1, 2];

        
            int elemento4 = t[0, 2];
            int elemento5 = t[1, 2];

        
            t[0, 1] = 0;

           
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    t[i, j] = 0;
                }
            }

            
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write("Ingrese el valor para t[" + i + "," + j + "]: ");
                    t[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int minimo = t[0, 0];
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (t[i, j] < minimo)
                    {
                        minimo = t[i, j];
                    }
                }
            }

     
            Console.Write("Fila 1 de t: ");
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(t[0, j] + " ");
            }
            Console.WriteLine();

            int totalColumna3 = 0;
            for (int i = 0; i < filas; i++)
            {
                totalColumna3 += t[i, 2];
            }

          
            Console.WriteLine("Contenido de t en formato tabular:");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(t[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("El valor mínimo en t es: " + minimo);
            Console.WriteLine("La suma de la tercera columna es: " + totalColumna3);
        }
    }
}
