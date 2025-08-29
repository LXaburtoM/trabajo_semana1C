// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int num;
int suma = 0;
string entrada;
Console.WriteLine(" dime un numero:");
entrada = Console.ReadLine();
num = Convert.ToInt32(entrada);

while (num > 0)
{
    suma += num;
    Console.WriteLine(" dime un numero:");
    entrada = Console.ReadLine();
    num = Convert.ToInt32(entrada);
}
Console.WriteLine("la suma es:" + suma);