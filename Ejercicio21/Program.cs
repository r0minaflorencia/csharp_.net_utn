/* Diseña un programa que, dado un número real que debe representar la calificación numérica de un
examen, proporcione la calificación cualitativa correspondiente al número dado. La calificación
cualitativa será una de las siguientes:
✭✭Suspenso✮✮ (nota menor que 5),
✭✭Aprobado✮✮ (nota mayor o igual que 5, pero menor que 7),
✭✭Notable✮✮ (nota mayor o igual que 7, pero menor que 8.5),
✭✭Sobresaliente✮✮ (nota mayor o igual que 8.5, pero menor que 10),
✭✭Matrícula de Honor✮✮ (nota 10). */

Console.WriteLine("Ingresa la calificación:");

float calificacion = float.Parse(Console.ReadLine());

if (calificacion < 5)
{
    Console.WriteLine($"Tu calificación es: {calificacion}. Suspenso");
}
else if (calificacion >= 5 && calificacion < 7)
{
    Console.WriteLine($"Tu calificación es: {calificacion}. Aprobado");
}
else if (calificacion >= 7 && calificacion < 8.5)
{
    Console.WriteLine($"Tu calificación es: {calificacion}. Notable");
}
else if (calificacion >= 8.5 && calificacion < 10)
{
    Console.WriteLine($"Tu calificación es: {calificacion}. Sobresaliente");
} else if (calificacion == 10) {
     Console.WriteLine($"Tu calificación es: {calificacion}. Matricula de Honor");
}
else
{
    Console.WriteLine("Debes ingresar una nota entre 0 y 10.");
}



