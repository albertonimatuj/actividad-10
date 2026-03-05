Dictionary<int, string> estudiantes = new Dictionary<int, string>();

for (int i = 1; i <= 3; i++)
{
    Console.Write("Ingrese el ID del estudiante " + i + ": ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Ingrese el nombre del estudiante " + i + ": ");
    string nombre = Console.ReadLine();
    estudiantes.Add(id, nombre);

}

Console.Write("\nIngrese el ID del estudiante que desea buscar: ");

int idABuscar = int.Parse(Console.ReadLine());

if (estudiantes.ContainsKey(idABuscar))
{

    Console.WriteLine("Resultado: " + estudiantes[idABuscar]);

}

else

{

    Console.WriteLine("El ID no se encuentra en el diccionario.");

}