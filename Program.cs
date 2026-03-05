Dictionary<string, string> usuarios = new Dictionary<string, string>();

for (int i = 1; i <= 3; i++)
{
    Console.Write("Ingrese nombre de usuario " + i + ": ");
    string user = Console.ReadLine();

    Console.Write("Ingrese contraseña para " + user + ": ");
    string pass = Console.ReadLine();

    usuarios.Add(user, pass);
}

Console.Write("\nUsuario a consultar: ");
string buscar = Console.ReadLine();

if (usuarios.ContainsKey(buscar))
{
    Console.WriteLine("La contraseña es: " + usuarios[buscar]);
}
else
{
    Console.WriteLine("Usuario no encontrado.");
}