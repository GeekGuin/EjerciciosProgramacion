using System;

public class VictorGay{
	static void Main(){		
		int a;
		Console.WriteLine("Ingrese un numero");
		a = Int32.Parse(Console.ReadLine());
		
		if (a%2 == 0){
			Console.WriteLine("Numero par");
		}else{
			Console.WriteLine("Numero impar");
		}
		
	}
}

