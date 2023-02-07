using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Ciclos_y_Condiciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String nombre = "Juan";
            int? num1 = null;
            var persona = new { nombre = "Felipe", edad = 20 };
            float valor1, valor2;
            float salario;

            var variable = true;

            dynamic dinamico = 25;
            dinamico = "cadena de caracteres";
            dinamico = false;
            Console.WriteLine(num1);

            valor1 = 15f;
            valor2 = 20f;
            salario = 325.56f;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"La suma de {valor1} + {valor2} = {valor1 + valor2}");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"La multiplicación de {valor1} * {valor2} = ({valor1 * valor2}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"La resta de {valor1} - {valor2} = {valor1 - valor2}");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"La divisón de {valor1} / {valor2} = {valor1 / valor2}");
            Console.ForegroundColor = ConsoleColor.White;

            float total = salario * salario * 0.13f;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"El salario de {persona.nombre} es de {salario} el IVA: {(salario * 0.13)} total = {total}");


            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Nombre: " + persona.nombre + " Edad: " + persona.edad);
            Console.WriteLine($"Nombre:  {persona.nombre}   Edad:  {persona.edad}");
            Console.WriteLine("Nombre: {0} Edad: {1}", persona.nombre, persona.edad);

            //Arreglos y matrices

            string[] musicos = new string[] { "Ringo", "George", "Paul", "John" }; // tamaño de 4
                                                                                   //  0          1        2       3
            float[] salarios = new float[4];
            salarios[0] = 500;
            salarios[1] = 300;
            salarios[2] = 100;
            salarios[3] = 250;

            Console.WriteLine(musicos.Length);

            /* == comparar
             * && and 
             * || or
             * != not
             * > mayor que 
             * < menor que
             * >= mayor o igual
             * <= Menor o igual
             * % = resto de division
             * => expresiones lamba
             */
            float promedio = 0;

            for (int i = 0; i < musicos.Length; i++)
            {
                promedio += salarios[i]; //Acumulador 
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Musico: {musicos[i]} Salario: {salarios[i]}");
            }
            Console.WriteLine("El promedio de salarios es de: {0}", (promedio /= musicos.Length));

            Console.Read();
        }
    }
}
