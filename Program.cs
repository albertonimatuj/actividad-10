Dictionary<int, string> estudiantes = new Dictionary<int, string>();

for (int i = 1; i <= 3; i++)
{
    Console.Write("Ingrese ID del estudiante " + i + ": ");
    int id = int.Parse(Console.ReadLine());

    while (estudiantes.ContainsKey(id))
    {
        Console.WriteLine("Ese ID ya existe. Ingrese uno diferente.");
        Console.Write("Ingrese ID del estudiante " + i + ": ");
        id = int.Parse(Console.ReadLine());
    }

    Console.Write("Ingrese nombre del estudiante " + i + ": ");
    string nombre = Console.ReadLine();
    estudiantes.Add(id, nombre);
}

Console.Write("\nIngrese el ID del estudiante que desea eliminar: ");
int idAEliminar = int.Parse(Console.ReadLine());

if (estudiantes.Remove(idAEliminar))
{
    Console.WriteLine("Registro eliminado correctamente.");
}
else
{
    Console.WriteLine("El ID no existe, no se pudo eliminar.");
}

Console.WriteLine("\nLista actualizada:");
foreach (var item in estudiantes)
{
    Console.WriteLine("ID: " + item.Key + " - Nombre: " + item.Value);
}