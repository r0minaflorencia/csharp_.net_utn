/*Realizar un programa que calcule nota media de 3 asignaturas de cada uno de los 5 alumnos de la clase. */

Console.WriteLine("\t Calcular promedio");

float promedio, suma;

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("\n Alumno n° " + (i + 1));

    suma = 0;

    for (int j = 1; j <= 3; j++)
    {
        Console.Write($"Ingresa la nota de la {j}° asignatura: ");
        float nota = float.Parse(Console.ReadLine());
        suma += nota;
    }

    promedio = suma / 3;
    Console.Write($"\t El promedio es {Math.Round(promedio)}\n"); //arreglar

}

