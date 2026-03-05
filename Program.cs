Dictionary<string, int> personas = new Dictionary<string, int>();
int opcion = 0;

do
{
    Console.WriteLine("\n--- MENU DE EMPLEADOS ---");
    Console.WriteLine("1. Ingresar nombre");
    Console.WriteLine("2. ver nombres");
    Console.WriteLine("3. Salir");
    Console.Write("Seleccione una opcion: ");
    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.Write("Ingrese nombre: ");
            string nom = Console.ReadLine();

            while (personas.ContainsKey(nom))
            {
                Console.WriteLine("El nombre ya existe. Ingrese uno diferente.");
                Console.Write("Ingrese nombre: ");
                nom = Console.ReadLine();
            }

            Console.Write("Ingrese nota: ");
            int nota = int.Parse(Console.ReadLine());
            personas.Add(nom, nota);
            break;

        case 2:
            Console.WriteLine("\n--- LISTA DE personas ---");
            foreach (var item in personas)
            {
                Console.WriteLine("NOMBRE: " + item.Key + " - NOTA: " + item.Value);
            }
            break;

        case 3:
            Console.WriteLine("Saliendo del programa...");
            break;

        default:
            Console.WriteLine("Opcion no valida.");
            break;
    }

} while (opcion != 3);