# Programas por Consola

 Investigar como imprimir (o mostrar) datos por consola, y tambien
 como leer datos del usuario (por consola) en c#.

 Incluir como leer distintos tipos de dato, ya sea entero, cadena,
 entro otros.
 
```c#
using System;

public class Hello1
{
   public static void Main()
   {
     int Numero1 = 18;
     int Numero2;
     int Numero3 = 2016;
     Console.WriteLine("Introduzca su año de nacimiento");
     Numero2 = Int32.Parse(Console.ReadLine()); 
     
     int Numero4 = Numero3 - Numero2;
     
     if (Numero4 < Numero1){
        Console.WriteLine("Usted es menor de edad");
     }
     else{
        Console.WriteLine("Usted es Mayor de edad");
     } 
   }
}
```