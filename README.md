# C\#
C# es un lenguaje de programacion interpretado, el que compila a un lenguaje
intermedio, y luego el interprete se encarga de ejecutar este lenguaje
intermedio y nos genera un ejecutable.

Aqui podemos ver un programa basico que posee un metodo Main, cabe destacar
que el metodo Main se llama solo al ejecutar el .exe.

```C#
using System;

class Demo{
	static void Main(){
		int x = 2;
		int y = 3;
		//~ Console.WriteLine( f(x) );
		Console.WriteLine( f(y) );
	}
	
	static int f(int mierda){
		return(mierda + 1);
	}
}
```

