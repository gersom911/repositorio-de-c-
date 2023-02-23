// See https://aka.ms/new-console-template for more information

using System.Drawing;

//Ejercicio 1

//Variables Escribe un programa que reciba datos de una persona y genera un mensaje, usa una variable para cada dato y otra para el mensaje. Ej: nombre, apellido, edad, sabe programar, etc.

//Ejercicio 2

//Tipos Usando los tipos de variables más adecuados, describe los objetos siguientes:

//Coche: puertas, ruedas, marca, ITV vigente

//Mesa: peso, largo, material, color

//Nota: puedes escribir estos datos por consola si prefieres verlos. La idea del ejercicio es almacenar los datos en los tipos más adecuados.

//Ejercicio 3

//Operadores Determina los operadores para verificar las siguientes condiciones:

//Un número es mayor o igual a 18

//Un char es ‘a’

//Se cumplen dos conciones a la vez (ambas verdaderas)

//Se cumple una de dos condiciones a la vez (una true y otra false)

//Nota: puedes escribir estos datos por consola si prefieres verlos. La idea del ejercicio es almacenar los datos en los tipos más adecuados.


//Ejercicio 1

////Variables Escribe un programa que reciba datos de una persona y
///genera un mensaje, usa una variable para cada dato y otra para el mensaje. Ej:
///nombre, apellido, edad, sabe programar, etc.

// capto el nombre
Console.WriteLine("esciba su nombre");
string? nombre = Console.ReadLine();

// capto la edad
Console.WriteLine("esciba tu edad");
string? edad = Console.ReadLine();
// establesco el mensaje comouna variable y 
// lo escribo en pantalla
string? mensaje = "tu nombre es: " + nombre + ", y tu edad es: " + edad;
Console.WriteLine(mensaje);

//Ejercicio 2

//Tipos Usando los tipos de variables más adecuados, describe los objetos siguientes:

//Coche: puertas, ruedas, marca, ITV vigente

//Mesa: peso, largo, material, color

//Nota: puedes escribir estos datos por consola si prefieres verlos. La idea del ejercicio es almacenar los datos en los tipos más adecuados.

// coche
Console.WriteLine("a acontinuación deberás descriobir el carro de tus sueños");
Console.WriteLine("responde a cada item");
Console.WriteLine("¿cuántas puertas tiene?"); 
string? puerta = Console.ReadLine();
int? puertaNum = Convert.ToInt32(puerta);
Console.WriteLine("¿cuántas ruedas tiene?");
string? rueda = Console.ReadLine();
int? ruedaNum = Convert.ToInt32(rueda);
Console.WriteLine("¿cuántas es su marca?");
string? marca = Console.ReadLine();
Console.WriteLine("La descripción del carro es:"+  ruedaNum +" Ruesdas,"+ puertaNum + " puertes,  marca: " + marca) ;
//Mesa: peso, largo, material, color

Console.WriteLine("Describe una mesa");
Console.WriteLine("¿Qu tiene?");
string? peso = Console.ReadLine();
float? pesoNum = Convert.ToSingle(peso);
Console.WriteLine("¿Qué largo  tiene?");
string? largo = Console.ReadLine();
float? largoNum = Convert.ToSingle(largo);
Console.WriteLine("¿Qué color  tiene?");
string? color = Console.ReadLine();
Console.WriteLine("la mesa tiene: un peso de " + pesoNum + ", un largo de: " + largoNum + "y un color de: " + color);


//Ejercicio 3

//Operadores Determina los operadores para verificar las siguientes condiciones:

//Un número es mayor o igual a 18

//Un char es ‘a’

//Se cumplen dos conciones a la vez (ambas verdaderas)

//Se cumple una de dos condiciones a la vez (una true y otra false)

//Nota: puedes escribir estos datos por consola si prefieres verlos. La idea del ejercicio es almacenar los datos en los tipos más adecuados.



//Un número es mayor o igual a 18
Console.WriteLine("escriba un numero mayor o igual a 18");
string? numero = Console.ReadLine();
int? numeroNum = Convert.ToInt32(numero);



if (numeroNum >= 18)
    {
        Console.WriteLine("el número es correcto");
    }
else
    {
        Console.WriteLine("el número es incorrecto ");
    }

Console.WriteLine("escribe la letra a");
string? letra = Console.ReadLine();
string a = "a";
if (letra == a)
    {
         Console.WriteLine("la letra es correcta");
    }
else
    {
         Console.WriteLine("la letra es incorrecta ");
    }

Console.WriteLine("escriba un numero mayor o igual a 18");
string? numero1 = Console.ReadLine();
int? numeroNum1 = Convert.ToInt32(numero1);
Console.WriteLine("escribe la letra  a");
string? letra1 = Console.ReadLine();

if (letra1 == a && numeroNum1 >= 18)
{
    Console.WriteLine("el numero y la letra son correctos");
}
else
{
    Console.WriteLine("el numero y la letra son carrectos ");
}



Console.WriteLine("escriba un numero mayor o igual a 18");
string? numero2 = Console.ReadLine();
int? numeroNum2 = Convert.ToInt32(numero2);
Console.WriteLine("escribe una letra que no sea a");
string? letra2 = Console.ReadLine();

if (letra2 != a && numeroNum2 >= 18)
{
    Console.WriteLine("el numero y la letra son correctos");
}
else
{
    Console.WriteLine("el numero y la letra son carrectos ");
}

