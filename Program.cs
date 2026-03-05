Dictionary<string, double> notas = new Dictionary<string, double>();

for (int i = 1; i <= 3; i++)
{
    Console.Write("Ingrese el nombre del estudiante " + i + ": ");
    string nombre = Console.ReadLine();

    Console.Write("Ingrese la nota de " + nombre + ": ");
    double nota = double.Parse(Console.ReadLine());
    notas.Add(nombre, nota);
}

Console.Write("\nIngrese el nombre del estudiante que desea consultar: ");
string buscar = Console.ReadLine();

if (notas.ContainsKey(buscar))
{
    Console.WriteLine("La nota de " + buscar + " es: " + notas[buscar]);
}
else
{
    Console.WriteLine("El estudiante no está registrado.");
=======
﻿Dictionary<int, string> productos = new Dictionary<int, string>();

for (int i = 1; i <= 3; i++)
{
    Console.Write("Ingrese el código del producto " + i + ": ");
    int codigo = int.Parse(Console.ReadLine());

    Console.Write("Ingrese el nombre del producto " + i + ": ");
    string nombre = Console.ReadLine();
    productos.Add(codigo, nombre);
}

Console.WriteLine("\n--- Lista de Productos ---");
foreach (var item in productos)
{
    Console.WriteLine("Código: " + item.Key + " - Producto: " + item.Value);
>>>>>>> b134a40516d785b5ce4591b1079387bb800c6f35
}