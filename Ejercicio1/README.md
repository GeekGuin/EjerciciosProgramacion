# Tarea 1
Realiza un programa en C# que lea un numero entero
ingresado por el usuario, y que imprima el dia
correspondiente como una cadena segun el numero ingresado,
si el usuario ingresa un numero no valido, el programa
debe imprimir el mensaje "Entrada Invalida".
Se consideran numeros validos los enteros en el rango
[0, 7].
Ejemplo:

Entrada del Usuario | Salida del programa
------------------- | -------------------
 1					| "Domingo"
 3					| "Martes"
 0					| "Entrada Invalida"
 8					| "Entrada Invalida"
 7 					| "Sabado"

>NOTA: No es necesario, pero se recomienda el uso de la estructura
de control switch. Sintaxis switch C#:

```C#
switch(var){
	case value1:
		//Case 1 code
		break;
	case value2:
		//Case 2 code
		break;
	//....
	//....
	//....
	case valueN:
		//Case N code
		break;
	defaukt:
}
```

> Recordar que el tipo de dato de `value1, value2, ..,
valueN`, debe ser del mismo tipo de dato que de la variable
`var`
