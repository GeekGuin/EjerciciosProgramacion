using System;

public class estudiantes{
	 public static void Main(){
	  int cedula, nota, edad, alumnos;
	  string nombre;
	  int mayor = -1;
	  int cantidad = 0;
	  string nombre_ganador = "";
	  int cedula_ganador = -1;
      Console.WriteLine("Ingrese cantidad de Alumnos: ");
      alumnos = Int32.Parse(Console.ReadLine());
      for (int i = 0; i < alumnos; i++){
		Console.WriteLine("Alumno ID " + (i+1));
		Console.WriteLine(" ");
		
		Console.WriteLine("Ingrese Nombre: ");
		nombre = Console.ReadLine();
		Console.WriteLine("Ingrese Cedula: ");
		cedula = Int32.Parse(Console.ReadLine());
		Console.WriteLine("Ingrese Nota: ");
		nota = Int32.Parse(Console.ReadLine());
		Console.WriteLine("Ingrese Edad: ");
		edad = Int32.Parse(Console.ReadLine());
		
		if (nota > mayor){
		  mayor = nota;
		  nombre_ganador = nombre;
		  cedula_ganador = cedula;
		}
		if (edad >= 18){
			cantidad++;
		}
	  }
	  Console.WriteLine("Mayor Nota: " + mayor + " Nombre: " + nombre_ganador + " Cedula: " + cedula_ganador);
	  Console.WriteLine("Cuantos con edad mayor a 18: " + cantidad);
   }
}
