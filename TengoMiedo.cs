using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoExamenArreglos
{
    public class TengoMiedo
    {
        public void Ejercicio3()
        {
            int[] numeros=new int[100];

            Random aleatorio = new Random();
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = aleatorio.Next(0,100);
            }

            //IMPRIMIR ARREGLO DESORNEDADO
            
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
               
            }
            Console.WriteLine("-----------------------------");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("-----------------------------");

            
            //METODO DE SELECCION PARA ORDENAR

            int numeroMenor = 0;

            for (int i = 0; i < numeros.Length-1; i++)
            {
                numeroMenor = i;

                for (int j = i+1; j < numeros.Length; j++)
                {
                    if (numeros[numeroMenor] < numeros[j])
                    {
                        numeroMenor = j;
                    }

                    int temporal = numeros[numeroMenor];
                    numeros[j] = numeros[numeroMenor];
                    numeros[j] = temporal;



                }
            }

            //IMPRIMIR ORDENADO
            
            for (int i = 0; i < numeros[i]; i++)
            {
                Console.WriteLine(numeros[i]);
            }
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("---------------------------------------------------------");




            //BUSCAR EL NUMERO 75 EN EL ARREGLO

            int inicio = 0;
            int final = numeros.Length - 1;
            int posicion = -1;
            int BuscarNumero = 75;

            while (inicio<=final)
            {
                int mitad = (inicio + final) / 2;

                if (numeros[mitad] == BuscarNumero)
                {
                    posicion= mitad;
                    break;
                }

                else if (numeros[mitad] < BuscarNumero)
                {
                    inicio = mitad + 1;
                }

                else
                {
                    final = mitad - 1;
                }


            }

            if (posicion != -1)
            {
                Console.WriteLine($"El numero {BuscarNumero} esta en la posicion {posicion}");
            }

            else
            {
                Console.WriteLine("No ai");
            }






        }



        public void Ejercicio1()
        {
            int[,] vendedorGanancia = new int[5, 4];

           
            
            Console.WriteLine("Ingresa la venta del producto 1");
            vendedorGanancia[0, 0] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa la venta del producto 2");
            vendedorGanancia[1, 0] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa la venta del producto 3");
            vendedorGanancia[2, 0] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa la venta del producto 4");
            vendedorGanancia[3,0] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa la venta del producto 5");
            vendedorGanancia[4, 0] = Convert.ToInt32(Console.ReadLine());


            //COLUMNA 2
            Console.WriteLine("Ingresa la venta del producto 1");
            vendedorGanancia[0, 1] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa la venta del producto 2");
            vendedorGanancia[1, 1] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa la venta del producto 3");
            vendedorGanancia[2, 1] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa la venta del producto 4");
            vendedorGanancia[3, 1] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa la venta del producto 5");
            vendedorGanancia[4, 1] = Convert.ToInt32(Console.ReadLine());


            //COLUMNA 3
            Console.WriteLine("Ingresa la venta del producto 1");
            vendedorGanancia[0, 2] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa la venta del producto 2");
            vendedorGanancia[1, 2] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa la venta del producto 3");
            vendedorGanancia[2, 2] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa la venta del producto 4");
            vendedorGanancia[3, 2] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa la venta del producto 5");
            vendedorGanancia[4, 2] = Convert.ToInt32(Console.ReadLine());

            //COLUMNA 4

            Console.WriteLine("Ingresa la venta del producto 1");
            vendedorGanancia[0, 3] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa la venta del producto 2");
            vendedorGanancia[1, 3] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa la venta del producto 3");
            vendedorGanancia[2, 3] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa la venta del producto 4");
            vendedorGanancia[3, 3] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa la venta del producto 5");
            vendedorGanancia[4, 3] = Convert.ToInt32(Console.ReadLine());

            //PRIMERA COLUMNA
            int sumarPrimeraColumna = vendedorGanancia[0, 0] + vendedorGanancia[1, 0] + vendedorGanancia[2, 0] + vendedorGanancia[3, 0];

            Console.WriteLine("Primer Vendedor" + sumarPrimeraColumna);

            //SEGUNDA
            int sumarSegundaColumna = vendedorGanancia[0, 1] + vendedorGanancia[1, 1] + vendedorGanancia[2, 1] + vendedorGanancia[3, 1];

            Console.WriteLine("Segundo Vendedor " + sumarSegundaColumna);
            //TERCERA
            int sumarTerceraColumna = vendedorGanancia[0, 2] + vendedorGanancia[1, 2] + vendedorGanancia[2, 2] + vendedorGanancia[3, 2];

            Console.WriteLine("Tercer Vendedor " + sumarTerceraColumna);
            //CUATRA
            int sumarCuatraColumna = vendedorGanancia[0, 3] + vendedorGanancia[1, 3] + vendedorGanancia[2, 3] + vendedorGanancia[3, 3];

            Console.WriteLine("Cuatro Vendedor" + sumarCuatraColumna);


            //QUINTA
            int sumarQuintaColumna = vendedorGanancia[4, 0] + vendedorGanancia[4, 1] + vendedorGanancia[4, 2] + vendedorGanancia[4, 3];

            Console.WriteLine("Cuatro Vendedor" + sumarQuintaColumna);







            //PRIMERA COLUMNA
            int sumarPrimeraFila = vendedorGanancia[0, 0] + vendedorGanancia[0, 1] + vendedorGanancia[0, 2] + vendedorGanancia[0, 3];

            Console.WriteLine("Primer producto" + sumarPrimeraFila);

            //SEGUNDA
            int sumarSegundaFila = vendedorGanancia[1, 0] + vendedorGanancia[1, 1] + vendedorGanancia[1, 2] + vendedorGanancia[1, 3];

            Console.WriteLine("Segundo producto " + sumarSegundaFila);
            //TERCERA
            int sumarTerceraFila = vendedorGanancia[2, 0] + vendedorGanancia[2, 1] + vendedorGanancia[2, 2] + vendedorGanancia[2, 3];

            Console.WriteLine("Tercer producto " + sumarTerceraFila);
            //CUATRA
            int sumarCuatraFila = vendedorGanancia[3, 0] + vendedorGanancia[3, 1] + vendedorGanancia[3, 2] + vendedorGanancia[3, 3];

            Console.WriteLine("Cuatro producto" + sumarCuatraFila);

            //QUINTA
            int sumarQuintaFila = vendedorGanancia[4, 0] + vendedorGanancia[4, 1] + vendedorGanancia[4, 2] + vendedorGanancia[4, 3];

            Console.WriteLine("Cuatro producto" + sumarQuintaFila);






        }





    }
}
