using System;

public class SoyGay{
	public static void Main(){
		int[] array = new int[6] {0, 3, 5, 8, 10, 9};
		int variable = 0;  //~ array[0] = 2;
		Console.WriteLine("Ingrese el numero que desea buscar: ");
		int seek = Int32.Parse(Console.ReadLine());	
		
			// Inicializacion; Condicion; Iteración
		for (int i = 0; i < array.Length; i++){
			if(array[i] == seek){
				Console.WriteLine("Esta es la posicion en que se encuentra el numero: " + i);
				variable = 1;
			}
		}
		
		if (variable == 0){
			Console.WriteLine("La cagaste");
		}
	}
}


