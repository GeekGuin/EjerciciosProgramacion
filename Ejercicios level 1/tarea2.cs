using System;

public class SamuelGay{
	 public static void Main(){
      int cargo;
      string nombre;
      // Ingreso nombre del empleado
      Console.WriteLine("Ingrese Nombre Completo");
      nombre = Console.ReadLine();
      // Ingreso cargo del empleado
      Console.WriteLine("Listado de Cargos");
      Console.WriteLine("1.- Vice - Presidente");
      Console.WriteLine("2.- Administrador");
      Console.WriteLine("3.- Gerente");
      Console.WriteLine("4.- Empleado");
      Console.WriteLine("5.- Ayudante");
      
      Console.WriteLine("Ingrese cargo segun la lista anterior");
      cargo = Int32.Parse(Console.ReadLine());
       
	  //Condiciones y Arojo de Resultados
		switch (cargo){
		case 1:
			Console.WriteLine("Nombre: " + nombre + ", Cargo: Vice - Presidente y Gana: 200$");
			break;
		case 2:
			Console.WriteLine("Nombre: " + nombre + ", Cargo: Administrador y Gana: 150$");
			break;
		case 3:
			Console.WriteLine("Nombre: " + nombre + ", Cargo: Gerente y Gana: 125$");
			break;
		case 4:
			Console.WriteLine("Nombre: " + nombre + ", Cargo: Empleado y Gana 100$");
			break;
		case 5:
			Console.WriteLine("Nombre: " + nombre + ", Cargo: Ayudante y Gana 75$");
			break;
		default:
			Console.WriteLine("Default case");
			break;
		}  
   }
}
