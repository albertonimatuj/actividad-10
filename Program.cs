Dictionary<int, string> empleados = new Dictionary<int, string>();
int opcion = 0;

do
{
    Console.WriteLine("\n--- MENU DE EMPLEADOS ---");
    Console.WriteLine("1. Ingresar empleado");
    Console.WriteLine("2. Modificar el nombre del empleado");
    Console.WriteLine("3. Ver empleados");
    Console.WriteLine("4. Salir");
    Console.Write("Seleccione una opcion: ");
    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.Write("Ingrese ID: ");
            int id = int.Parse(Console.ReadLine());

            while (empleados.ContainsKey(id))
            {
                Console.WriteLine("Ese ID ya existe. Ingrese uno diferente.");
                Console.Write("Ingrese ID: ");
                id = int.Parse(Console.ReadLine());
            }

            Console.Write("Ingrese nombre: ");
            string nombre = Console.ReadLine();
            empleados.Add(id, nombre);
            break;

        case 2:
            Console.Write("Ingrese el ID del empleado a modificar: ");
            int idMod = int.Parse(Console.ReadLine());

            if (empleados.ContainsKey(idMod))
            {
                Console.Write("Nuevo nombre: ");
                string nuevoNombre = Console.ReadLine();
                empleados[idMod] = nuevoNombre;
                Console.WriteLine("Nombre actualizado.");
            }
            else
            {
                Console.WriteLine("El empleado no existe.");
            }
            break;

        case 3:
            Console.WriteLine("\n--- LISTA DE EMPLEADOS ---");
            foreach (var item in empleados)
            {
                Console.WriteLine("ID: " + item.Key + " - Nombre: " + item.Value);
            }
            break;

        case 4:
            Console.WriteLine("Saliendo del programa...");
            break;

        default:
            Console.WriteLine("Opcion no valida.");
            break;
    }

} while (opcion != 4);