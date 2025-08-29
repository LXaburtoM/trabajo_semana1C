// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Ingrese un número del 1 al 3:");
int numero = Convert.ToInt32(Console.ReadLine());

switch (numero)
{
    case 1:
        Console.WriteLine("estudia sistemas");
        break;
    case 2:
        Console.WriteLine("estudia medicina");
        break;
    case 3:
        Console.WriteLine("marketing");
        break;
    default:
        Console.WriteLine("Número fuera de rango");
        break;
}