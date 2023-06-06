/*
----------------------------------------------------------------------------------------------------------------------------------
 *
 La empresa financiera Introfin tiene tres líneas de crédito y cuenta con la información acerca de los montos mensuales dados en
préstamos por cada una en los últimos 6 meses. A partir de estos datos la empresa construyó la siguiente tabla de “préstamos
mensuales por línea”:

           Personal            Tarjetas           Hipotecario
Diciembre
Enero
Febrero
Marzo
Abril
Mayo

 

Elabore un programa que defina un arreglo, cadena, structs o archivos (seleccione el que crea más conveniente)
que permita almacenar los montos otorgados por línea de crédito, los valores de las ventas deben ser dados por
su persona como programador.

Luego, por medio de un menú debe permitir seleccionar y obtener la respuesta a las siguientes preguntas:

a) ¿Cuál fue el total de préstamo otorgado en la línea Hipotecario?

b) ¿Cuál fue el promedio de los montos otorgados en el mes de febrero?

c) ¿Qué línea de crédito tuvo mayores montos otorgados en el mes de mayo?

----------------------------------------------------------------------------------------------------------------------------------
 */

using System;

class Program
{
    //Vectores
    static double[] Personal = { 235.67, 416.82, 589.43, 751.29, 873.54, 625.91 };
    static double[] Tarjeta = { 1000, 1500, 1200, 800, 1850, 1700 };
    static double[] Hipotecario = { 20000, 30000, 10000, 15000, 22000, 35000 };

    static void Main(string[] args)
    {
        //Variable para salir del bucle
        bool salir = false;

        Console.WriteLine("          Financiera Introfin");

        //Bucle con entrada asegurada 
        do
        {
            //Menu
            Console.WriteLine("          Menu de Opciones");
            Console.WriteLine("1. Ver total de la línea hipotecaria");
            Console.WriteLine("2. Promedio del Mes de Febrero");
            Console.WriteLine("3. Mayor monto otorgado en Mayo");
            Console.WriteLine("4. Salir");
            //Entrada de datos
            Console.Write("Ingrese su opción: ");
            int opc = Int32.Parse(Console.ReadLine());

            //Estructura selectiva
            switch (opc)
            {
                case 1:
                    Console.Clear();
                    TotalHipo();
                    break;
                case 2:
                    Console.Clear();
                    PromedioFeb();
                    break;
                case 3:
                    Console.Clear();
                    MontoMayo();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("Pase buen dia :D");
                    Console.WriteLine("--------------------------------------------------");
                    salir = true;
                    break;
                default:
                    Console.WriteLine("----------------------------------------------------");
                    Console.WriteLine("Opción inválida. Por favor, ingrese una opcion......");
                    Console.WriteLine("----------------------------------------------------");
                    break;
            }

        } while (!salir);
    }

    static void TotalHipo()
    {
        //Variable de proceso
        double totalHipo = 0;

        //Bucle por contador 
        for (int x = 0; x < Hipotecario.Length; x++)
        {
            //Sumar los valores de todo el vector
            totalHipo += Hipotecario[x];
        }
        //Salida de datos
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine($"El total de la línea hipotecaria es: ${totalHipo}");
        Console.WriteLine("--------------------------------------------------");
    }

    static void PromedioFeb()
    {
        //Variables de proceso
        double sumFeb = Personal[2] + Tarjeta[2] + Hipotecario[2];
        double promedioFeb = sumFeb / 3;

        //Salida de datos
        Console.WriteLine("-------------------------------------------------------------------------");
        Console.WriteLine($"El promedio del mes de Febrero en las tres lineas fue de: ${promedioFeb}");
        Console.WriteLine("-------------------------------------------------------------------------");
    }

    static void MontoMayo()
    {
        //Variables
        double maxMayo = 0;
        string tipoCredito = "";

        //Condicionales
        if (Personal[5] > maxMayo)
        {
            maxMayo = Personal[5];
            tipoCredito = "Personal";
        }
        if (Tarjeta[5] > maxMayo)
        {
            maxMayo = Tarjeta[5];
            tipoCredito = "Tarjeta";
        }
        if (Hipotecario[5] > maxMayo)
        {
            maxMayo = Hipotecario[5];
            tipoCredito = "Hipotecaria";
        }
        //Salida de datos
        Console.WriteLine("-----------------------------------------------------------------------------------------------");
        Console.WriteLine($"El credito que otorgo mayor monto en el mes de Mayo fue la linea {tipoCredito} con: ${maxMayo}");
        Console.WriteLine("-----------------------------------------------------------------------------------------------");

    }
}
