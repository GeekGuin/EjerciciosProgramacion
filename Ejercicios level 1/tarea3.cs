using System;

public class SamuelGay{
	 public static void Main(){
      string cargo;
      string nombre;
      // Ingreso nombre del empleado
      Console.WriteLine("Ingrese Nombre Completo");
      nombre = Console.ReadLine();
      // Ingreso cargo del empleado
      Console.WriteLine("Listado de Cargos");
      Console.WriteLine("1.- Presidente");
      Console.WriteLine("2.- Administrador");
      Console.WriteLine("3.- Gerente");
      Console.WriteLine("4.- Empleado");
      Console.WriteLine("5.- Ayudante");
      
      Console.WriteLine("Ingrese cargo segun la lista anterior");
      cargo = Console.ReadLine();
       
	  //Condiciones y Arojo de Resultados
		switch (cargo){
		case "Presidente":
			Console.Write(nombre + "\n\t-Presidente\n\t-200$\n \a");
			break;
		case "Administrador":
			Console.Write(nombre + "\n\t-Administrador\n\t-150$\n \a");
			break;
		case "Gerente":
			Console.Write(nombre + "\n\t-Gerente\n\t-125$\n \a");
			break;
		case "Empleado":
			Console.Write(nombre + "\n\t-Empleado\n\t-100$\n \a");
			break;
		case "Ayudante":
			Console.Write(nombre + "\n\t-Ayudante\n\t-150$\n \a");
			break;
		default:
			Console.WriteLine("Cargo Incorrecto, Intenta de nuevo MARICA");
			break;
		}
   }
}
