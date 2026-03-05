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
}