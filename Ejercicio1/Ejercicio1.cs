using System;

class Ejercicio1{
	static void Main(){
		int input;
		string[] dias = new string[]{"Domingo", "Lunes", "Martes", "Miercoles",
									 "Jueves", "Viernes", "Sabado", "Domingo"};
									 
		Console.WriteLine("Ingrese un numero entre 1 y 7: ");
		input = Int32.Parse(Console.ReadLine());
		if(input > 0 && input < 8){
			Console.WriteLine("!!" + dias[input-1] + "!!");
		}else{
			Console.WriteLine("Entrada Invalida");
		}
	}
}
