using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            Console.WriteLine("\n*****Calculadora de promedio Universitario*****");

            //Pedir al usuario las notas del primer computo 
            Console.WriteLine("\nIngrese las notas del primer computo");
            Console.WriteLine("Ingrese las notas del laboratorio 1: ");
            Double lab1 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Ingrese la nota del parcial 1: ");
            Double parc1 = Convert.ToDouble(Console.ReadLine());


            //Pedir al usuario las notas del segundo computo
            Console.WriteLine("\nIngrese las notas del segundo computo");
            Console.WriteLine("Ingrese las notas del laboratorio 2: ");
            Double lab2 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Ingrese la nota del parcial 2: ");
            Double parc2 = Convert.ToDouble(Console.ReadLine());

            //Pedir al usuario las notas del tercer computo
            Console.WriteLine("\nIngrese las notas del tercer computo");
            Console.WriteLine("Ingrese las notas del laboratorio 3: ");
            Double lab3 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Ingrese la nota del parcial 3: ");
            Double parc3 = Convert.ToDouble(Console.ReadLine());


            //Calcular el promedio 
            double PromedioLab = (lab1 + lab2 + lab3) * 0.6; 
            double PromedioParc = (parc1 + parc2 + parc3) * 0.4;
            double NotaFinal = (PromedioLab / 3) + (PromedioParc /3);

            Console.WriteLine("\nSu nota final es: " + Math.Round(NotaFinal));

            //Comparar el promedio de la nota final
            if (NotaFinal >= 7){
                Console.WriteLine("\nUsted paso la materia con excelente nota");
            } 
            else if (NotaFinal >= 6){
                Console.WriteLine("\nUsted paso la materia con nota baja");
            }
            else 
            {
                Console.WriteLine("Usted sacó una nota menor a 6, reprobó la materia" ); 
            }

        Console.ReadKey();
        }
            
    }
}