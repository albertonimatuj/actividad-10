Dictionary<int, string> productos = new Dictionary<int, string>();

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
}