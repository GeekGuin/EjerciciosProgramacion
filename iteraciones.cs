// Iteraciones
using System;

public class VictorGay{
	static void Main(){		
		// For de 0 a 10
		for (int i = 0; i <= 10; i++){
			Console.WriteLine(i);
		}
		// While n = 1 mientras n < 5, escribe N y sumale +1
		int n = 1;
        while (n < 5)
        {
			Console.WriteLine("El valor de N es = {0}", n);
            n = n+1;
        }
        
        int victorgay = factorial(10);
        Console.WriteLine(victorgay);
	}
	
	static int factorial(int n){
		 //Factorial numero anterior a n: n-1, numero mayor n+1
        int f = 1;
        for (int i = 1; i <= n; i++){
			f *= i;			
		}
		return f;
	}	
}

