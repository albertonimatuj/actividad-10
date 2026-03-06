using static System.Runtime.InteropServices.JavaScript.JSType;

Dictionary<int, string> inventario = new Dictionary<int, string>();
int opcion = 0;

do
{
    Console.WriteLine("\n--- INVENTARIO ---");
    Console.WriteLine("1. Ingresar prodructo");
    Console.WriteLine("2. eliminar producto");
    Console.WriteLine("3. ver inventario");
    Console.WriteLine("4. Salir");
    Console.Write("Seleccione una opcion: ");
    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.Write("Ingrese el producto: ");
            string produc = Console.ReadLine();
            Console.Write("Ingrese el codigo del producto: ");
            int cod = int.Parse(Console.ReadLine());

            while (inventario.ContainsKey(cod))
            {
                Console.WriteLine("El codigo ya existe. Ingrese uno diferente.");
                Console.Write("Ingrese el codigo del producto: ");
                cod = int.Parse(Console.ReadLine());
            }
            inventario.Add(cod, produc);
            break;

        case 2:
            Console.WriteLine("--- ELIMINAR PRODUCTO---");
            Console.Write("Ingrese el codigo del producto que desea eliminar: ");
            int Eliminar = int.Parse(Console.ReadLine());

            if (inventario.Remove(Eliminar))
            {
                Console.WriteLine("Registro eliminado correctamente.");
            }
            else
            {
                Console.WriteLine("El codigo no existe, no se pudo eliminar.");
            }

            Console.WriteLine("Lista actualizada:");
            break;
        case 3:
                        Console.WriteLine("\n--- INVENTARIO ---");
            foreach (var item in inventario)
            {
                Console.WriteLine("Codigo: " + item.Key + " - Producto: " + item.Value);
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