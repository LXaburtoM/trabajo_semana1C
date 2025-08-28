
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.Write("Ingrese la temperatura actual: ");
string? entrada = Console.ReadLine();

if (!int.TryParse(entrada, out int temperatura))
{
    Console.WriteLine("Por favor, ingrese un valor numérico válido.");
    return;
}

if (temperatura > 25)
{
    Console.WriteLine("Hace calor.");
}
else
{
    Console.WriteLine("Hace frío.");
}