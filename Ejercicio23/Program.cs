/* Algoritmo simplificado (20 líneas de código) de un Cajero automático Este ejercicio podría ser muy
largo o complicarse más, pero lo que importa en una estructuración inicial simple para poder
ampliarlo, si se desea, más adelante. Se pueden obtener tantas soluciones como personas
resuelvan este ejercicio. */

Console.WriteLine("\t Cajero automático");

float saldo = 1000.0f;
int opcion;
bool salir = false;

do
{
    Console.WriteLine("\n 1- Consultar saldo\n 2- Extraer efectivo\n 3- Ingresar dinero\n 4- Salir\n");
    opcion = int.Parse(Console.ReadLine());


    switch (opcion)
    {
        case 1:
            MostrarSaldo();
            break;
        case 2:
            ExtraerSaldo();
            break;
        case 3:
            Ingresar();
            break;
        case 4:
            Console.WriteLine("Salir");
            salir = true;
            break;
        default:
            break;
    }

} while (!salir);

void Ingresar()
{
    Console.Write("Monto a ingresar: ");
    float monto = float.Parse(Console.ReadLine());
    saldo += monto;
    Console.WriteLine("Transacción exitosa");
}

float ExtraerSaldo()
{
    Console.Write("Ingrese el monto a retirar: ");
    float monto = float.Parse(Console.ReadLine());

    if (monto <= saldo)
    {
        saldo -= monto;
        Console.WriteLine("Retiro exitoso");
    }
    else
    {
        Console.WriteLine("Fondos insuficientes.");
    }

    return saldo;
}

void MostrarSaldo()
{
    Console.WriteLine($"Saldo: $ {saldo}");
}



