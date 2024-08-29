/* Diseña un programa que, dado un número entero, determine si este es el doble de un número
impar. (Ejemplo: 14 es el doble de 7, que es impar.) */

Console.Write("Ingresa un nro entero: ");
int num = int.Parse(Console.ReadLine());

int resultado = num/2;

if (resultado % 2 == 0) {
    Console.WriteLine("Es doble de un numero par");
} else {
    Console.WriteLine("Es el doble de un numero impar");
}


