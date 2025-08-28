// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Ingrese su nota:");
string? entrada = Console.ReadLine();

if (!int.TryParse(entrada, out int nota))
{
    Console.WriteLine("Por favor, ingrese un valor numérico válido.");
    return;
}

if (nota > 85)
{
    Console.WriteLine("Excelente nota");
}
else if (nota >= 80 && nota <= 84)
{
    Console.WriteLine("Buena nota");
}
else if (nota >= 70 && nota <= 79)
{
    Console.WriteLine("Aprobado");
}
else
{
    Console.WriteLine("Necesitas mejorar");
}