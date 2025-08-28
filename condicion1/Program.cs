// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int edad;
Console.Write("Ingrese su edad: ");
string? entrada = Console.ReadLine();// ...existing code...

if (string.IsNullOrEmpty(entrada))
{
    Console.WriteLine("No ingresaste ningún valor.");
    return;
}
edad = int.Parse(entrada);
// ...existing code...
if (string.IsNullOrEmpty(entrada))
{
    Console.WriteLine("No ingresaste ningún valor.");
    return;
}
edad = int.Parse(entrada);

if (edad >= 18)
{
    Console.WriteLine("Eres mayor de edad");
}
else
{
    Console.WriteLine("Eres menor de edad");
}