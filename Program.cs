using System;

Biblioteca biblioteca = new Biblioteca();

int opcion;

do
{
    Console.WriteLine();
    Console.WriteLine("========================================");
    Console.WriteLine("          SISTEMA DE BIBLIOTECA");
    Console.WriteLine("========================================");
    Console.WriteLine("1. Registrar libro");
    Console.WriteLine("2. Mostrar libros");
    Console.WriteLine("3. Buscar libro por código");
    Console.WriteLine("4. Modificar ejemplares");
    Console.WriteLine("5. Eliminar libro");
    Console.WriteLine("6. Mostrar categorías");
    Console.WriteLine("7. Operaciones entre conjuntos");
    Console.WriteLine("8. Salir");
    Console.WriteLine("========================================");
    Console.Write("Seleccione una opción: ");

    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.Write("Ingrese el código del libro: ");
            int codigo = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el título del libro: ");
            string titulo = Console.ReadLine();

            Console.Write("Ingrese el autor del libro: ");
            string autor = Console.ReadLine();

            Console.Write("Ingrese la categoría del libro: ");
            string categoria = Console.ReadLine();

            Console.Write("Ingrese el número de ejemplares: ");
            int cantidad = int.Parse(Console.ReadLine());

            biblioteca.RegistrarLibro(codigo, titulo, autor, categoria, cantidad);
            break;

        case 2:
            biblioteca.MostrarLibros();
            break;

        case 3:
            Console.Write("Ingrese el código del libro a buscar: ");
            int codigoBuscar = int.Parse(Console.ReadLine());

            biblioteca.BuscarLibro(codigoBuscar);
            break;

        case 4:
            Console.Write("Ingrese el código del libro a modificar: ");
            int codigoModificar = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el nuevo número de ejemplares: ");
            int nuevosEjemplares = int.Parse(Console.ReadLine());

            biblioteca.ModificarEjemplares(codigoModificar, nuevosEjemplares);
            break;

        case 5:
            Console.Write("Ingrese el código del libro a eliminar: ");
            int codigoEliminar = int.Parse(Console.ReadLine());

            biblioteca.EliminarLibro(codigoEliminar);
            break;

        case 6:
            biblioteca.MostrarCategorias();
            break;

        case 7:
            biblioteca.OperacionesConjuntos();
            break;

        case 8:
            Console.WriteLine("Saliendo del sistema...");
            break;

        default:
            Console.WriteLine("Opción no válida.");
            break;
    }

} while (opcion != 8);