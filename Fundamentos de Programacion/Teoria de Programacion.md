// Datos Recopilados Mediante una lectura de fundamentos de programacion en varios sitios web y varios libros.

# Fundamentos de Programacion

## Que es un Algoritmo?

Por Algoritmo se entiende como un conjunto finito de instrucciones ordenadas de manera logica que se deben seguir para resolver un problema. 

###### Caracteristicas

- Tiene que ser preciso, eso es finito.
- Tiene que estar bien definido de manera logica.
- La Programacion significa: Adaptar un Algoritmo a la computadora.

- **Cada paso de un algoritmo debe estar bien definido** : Esto significac que la definicion de un paso debe ser suficientemente clara para que una persona pueda entenderla y realizarla. 

- **Un algoritmo debe tener principio y un fin** : Un programa es un algoritmo escrito con un objetivo: conseguir un resultado. No tiene sentido crear un programa que espere ~ segundos (infinitos segundos) y luego escriba en pantalla "Hola Mundo!", del mismo modo que un algoritmo debe tener un principio bien definido (tampoco tiene sentido el algoritmo "haz nada, y luego escribe Hola Mundo!")

## Como se realiza un algoritmo?

Para desarrollar un algoritmo primero se debe analizar profundamente el problema y darle una solucion logica o matematica, luego identificar los procesos de entrada, proceso y salida y luego utilizar alguna tecnica algoritmica como diagramas o pseudocodigos que son los mas comunes.

**Ejemplo:**
Elabora un programa que halle la suma de dos numeros enteros. Deberias hacerte preguntas como las siguientes:
- Que datos voy a ingresar?
- Que dato sera mi resultado?
- Como consigo ese resultado?

**La respuesta seria**: Que deberas ingrear dos numeros enteros que el resultado seria la suma de esos dos numeros y el proceso para conseguirlo seria la suma del numero 1 y el numero 2.

**Como empezar?** Aunque no existe un metodo general para dise;ar un algoritmo se puede empezar por los siguientes pasos

- **El Analisis**: Es imporatnte hacer un buen analisis de cual es especificamente el problema a resolver y como solucionarlo. De un buen analisis dependeran los buenos resultados que arroje el algoritmo.

- **Escribir el algoritmo **: Despues de haber analizado el problema de forma abstracta, se debe llevar al papel, mediante instrucciones y tecnicas adecuadas de analisis.

- **Depuracion (Debugging)**: o Ejecutar en papel, recuerda que la programacion es un trabajo de oficina, primero piensa luego programa, para ello los algoritmos se desarrollan primero en papel, prueba tu algoritmo con valores distintos donde siempre te retorne el resultado deseado, una vez concluida esta fase recienn ahi se sugiere llevarlo a la computadora con el lenguaje de programacion que se desee.

# Tecnicas Basicas de Programacion

La programación estructurada sigue tres reglas: la secuencia, la iteración y la decisión. La primera de ellas indica que las instrucciones del código se leerán de principio a fin; la segunda indica que, según cierta condición, un número de instrucciones podrían repetirse un numero determinado de veces, y la tercera indica que según unas ciertas condiciones se ejecutarán o no un conjunto de instrucciones.

Ejemplo basico de un codigo

```
coger plato
     mientras haya suciedad
        echar jabon
        pasar el estropajo por el plato
     si plato es azul
        ponerlo con los azules
```

En codigo estructurado

```
  1 coger plato
  2 echar jabon
  3 pasar el estropajo por el plato
  4 si hay suciedad ir a la instrucción 2
  5 si el plato no es azul ir a la instrucción 7
  6 ponerlo con los azules
  7 si hay más platos ir a la instrucción 1
```

## Variables y Constantes

Como hemos visto, el ordenador sigue una serie de instrucciones. Pero esas instrucciones tienen que operar sobre una serie de datos. El ordenador típico sólo procesa una instrucción a la vez, por lo que necesita 'espacios de memoria' donde guardar o depositar, a modo de cajones, por usar un símil conocido, los diversos datos con los que trabaja. Aquí es donde entran en juego las variables y constantes.

Quizás suene más complicado de lo que es. Un ejemplo: Queremos sumar dos números. Nuestro programa tendrá que tener tres cajones: Uno para cada número y otro para el resultado. Cada cajón tiene un nombre en vez de una posición de memoria, de manera que sólo hay que nombrarlo:

```
Necesito cajones A, B y Resultado
  Lee un número y guárdalo en A
  Lee un número y guárdalo en B
  Suma A y B y guárdalo en Resultado
  Imprime el contenido de Resultado
  
```
He aquí nuestro programa. Como cabe pensar, un procesador no tiene la instrucción "Imprime por pantalla"; esto es una llamada a otra porción de código que, gracias a la abstracción, nosotros no hemos escrito, o hemos escrito una sola vez; a partir de lo cual podemos imprimir todo el texto que queramos en la pantalla.

Las posiciones de memoria A y B son Variables. Si queremos leerlas o escribirlas, podemos hacerlo. Típicamente, existirán datos que no pensamos modificar; no querremos que el usuario tenga que introducirlos cada vez, pues son de naturaleza más constante que otros (como puede ser el valor Pi para calcular el perímetro o área de un círculo). Para evitar modificarlos por error, podemos pedir al sistema variables especiales, que no puedan ser reescritas. Son las Constantes.

```
Comentario: Este programa calcula el área de un círculo
```
```
  Constante PI = 3'14159265
  Variable R
  Variable Resultado;
```
```
  Leer número y guardar en R
  Calcular PI * (R * R) y guardar en Resultado
  Imprimir Resultado;
```
El uso de variables y constantes se asemeja al uso que se les da en el álgebra o en otras ramas matemáticas.

Nótese también la clara separación entre estructuras de datos y algoritmos. Según los lenguajes, esto puede ser o no obligatorio, pero es recomendable en aras de una mayor claridad del trabajo.

*En general, las variables son espacios que se reservan o se separan en la memoria para almacenar cualquier tipo de información (números, letras, frases, etc.), las variables pueden tener cualquier nombre pero preferiblemente deben ser mnemotécnico, es decir, que tenga relación con él o los datos que se almacenarán en la variable.*

1.No pueden comenzar con números. 
2.No pueden contener símbolos u operadores en ninguna posición del nombre, excepto “_”.
3.No pueden contener espacios.
4.Se sugiere que el nombre de las variables no sean mayor de 8 caracteres. 

**###Comentarios**
El útil concepto del comentario: son líneas de texto que el compilador o el intérprete no consideran como parte del código, con lo cual no están sujetas a restricciones de sintaxis y sirven para aclarar partes de código en posteriores lecturas y, en general, para anotar cualquier cosa que el programador considere oportuno.

Uno como programador debe tener como prioridad documentar nuestro código fuente ya que al momento de depurar (*Depuración de programas es el proceso de identificar y corregir errores de programación. En inglés se le conoce como debugging, es que se asemeja a la eliminación bugs*) nos ahorrará mucho tiempo de analisis para su corrección o estudio.

Los programadores profesionales tienen la buena costumbre de documentar sus programas con encabezados de texto (encabezados de comentarios) en donde describen la función que va a realizar dicho programa, la fecha de creación, el nombre del autor y en algunos casos las fechas de revisión y el nombre del revisor.

asdasdasd