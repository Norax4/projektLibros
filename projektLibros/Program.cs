using projektLibros;

bool salir = false;
Dictionary<int, Action> menuOpciones = new Dictionary<int, Action>
{
    {1, IngresarDatosLibro },
    {2, ListarDatosLibro },
    {5, () => salir = true}
};

List<Libro> listaLibros = new List<Libro>();

while (!salir)
{
    MostrarMenu();
    string? entrada = Console.ReadLine();

    if (int.TryParse(entrada, out int opcion))
    {
        if (menuOpciones.ContainsKey(opcion))
        {
            menuOpciones[opcion].Invoke();
        }
        else
        {
            Console.WriteLine("Opción invalida. Presione una tecla e intente nuevamente.");
            Console.ReadKey();
        }
    }
    else
    {
        Console.WriteLine("Por favor, ingrese un número válido. Presione una tecla para continuar.");
        Console.ReadKey();
    }
}

static void MostrarMenu()
{
    Console.Clear();
    Console.WriteLine("Menú de la Biblioteca.");
    Console.WriteLine("1. Ingreso de libros.");
    Console.WriteLine("2. Listado de libros.");
    Console.WriteLine("3. Eliminación de libros.");
    Console.WriteLine("4. Filtrado de libros.");
    Console.WriteLine("5. Salir del programa.");
    Console.WriteLine("");
    Console.WriteLine("Ingrese la opción deseada:");
}

void IngresarDatosLibro()
{
    Console.Clear();
    Console.WriteLine("Ingresar datos del libro nuevo:");

    string? titulo;
    do
    {
        Console.WriteLine("Ingrese el Titulo:");
        titulo = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(titulo))
        {
            Console.WriteLine("El titulo del libro no puede estar vacío o ser solo espacios en blanco.");
        }

    } while (string.IsNullOrEmpty(titulo));

    string? autor;
    do
    {
        Console.WriteLine("Ingrese el Autor:");
        autor = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(autor))
        {
            Console.WriteLine("El autor del libro no puede estar vacío o ser solo espacios en blanco.");
        }
    } while (string.IsNullOrEmpty(autor));

    int anioPub;
    string? anioTexto;
    do
    {
        Console.WriteLine("Ingrese el Año de Publicación:");
        anioTexto = Console.ReadLine();
        if (!int.TryParse(anioTexto, out anioPub))
        {
            Console.WriteLine("El año de publicación debe ser un número");
        }
    } while (!int.TryParse(anioTexto, out anioPub));

    Libro nuevoLibro = new Libro(titulo, autor, anioPub);
    listaLibros.Add(nuevoLibro);

    Console.WriteLine("El nuevo libro fue ingresado exitosamente. Presione una tecla para continuar.");
    Console.ReadKey();
}

void ListarDatosLibro()
{
    Console.Clear();
    Console.WriteLine("Listado de Libros:");

    if (listaLibros.Count < 0)
    {
        Console.WriteLine("No hay libros en la biblioteca.");
    }
    else
    {
        foreach (var libro in listaLibros)
        {
            Console.WriteLine(libro);
        }
    }
}
