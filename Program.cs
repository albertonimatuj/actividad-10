Dictionary<int, string> ciudades = new Dictionary<int, string>();

for (int i = 1; i <= 5; i++)
{
    Console.Write("Ingrese el código de la ciudad " + i + ": ");
    int codigo = int.Parse(Console.ReadLine());

    Console.Write("Ingrese el nombre de la ciudad " + i + ": ");
    string nombre = Console.ReadLine();

    ciudades.Add(codigo, nombre);
}

Console.Write("\nIngrese el código de la ciudad que desea buscar: ");
int buscar = int.Parse(Console.ReadLine());

if (ciudades.ContainsKey(buscar))
{
    Console.WriteLine("Ciudad encontrada: " + ciudades[buscar]);
}
else
{
    Console.WriteLine("El código no existe.");
}