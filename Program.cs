Dictionary<int, string> estudiantes = new Dictionary<int, string>();

for (int i = 1; i <= 5; i++)
{
    Console.Write("Ingrese el ID del estudiante " + i + ": ");
    int id = int.Parse(Console.ReadLine());
    while (estudiantes.ContainsKey(id))
    {
        Console.WriteLine("El ID ya existe. Ingrese uno diferente.");
        Console.Write("Ingrese el ID del estudiante " + i + ": ");
        id = int.Parse(Console.ReadLine());
    }
  
    Console.Write("Ingrese el nombre del estudiante " + i + ": ");
    string nombre = Console.ReadLine();

    estudiantes.Add(id, nombre);

}
Console.Write("-------------");
foreach (var item in estudiantes)
{
    Console.WriteLine("ID: " + item.Key + " - Nombre: " + item.Value);
}