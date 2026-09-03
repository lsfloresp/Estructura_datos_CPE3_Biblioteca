using System;
using System.Collections.Generic;

// Conjunto para almacenar las categorías disponibles
HashSet<string> categorias = new HashSet<string>();

// Diccionarios para almacenar la información de los libros
Dictionary<int, string> titulos = new Dictionary<int, string>();
Dictionary<int, string> autores = new Dictionary<int, string>();
Dictionary<int, string> categoriasLibros = new Dictionary<int, string>();
Dictionary<int, int> ejemplares = new Dictionary<int, int>();

// Registro de categorías
categorias.Add("Programación");
categorias.Add("Redes");
categorias.Add("Bases de Datos");
categorias.Add("Literatura");

// Registro de libros
titulos.Add(101, "Introducción a C#");
autores.Add(101, "Juan Pérez");
categoriasLibros.Add(101, "Programación");
ejemplares.Add(101, 3);

titulos.Add(102, "Redes de Computadores");
autores.Add(102, "María López");
categoriasLibros.Add(102, "Redes");
ejemplares.Add(102, 2);

titulos.Add(103, "Fundamentos de Bases de Datos");
autores.Add(103, "Carlos Gómez");
categoriasLibros.Add(103, "Bases de Datos");
ejemplares.Add(103, 4);

Console.WriteLine("----------------------------------------");
Console.WriteLine("          LIBROS REGISTRADOS");
Console.WriteLine("----------------------------------------");

foreach (int codigo in titulos.Keys)
{
    Console.WriteLine($"Código: {codigo}");
    Console.WriteLine($"Título: {titulos[codigo]}");
    Console.WriteLine($"Autor: {autores[codigo]}");
    Console.WriteLine($"Categoría: {categoriasLibros[codigo]}");
    Console.WriteLine($"Ejemplares: {ejemplares[codigo]}");
    Console.WriteLine("----------------------------------------");
}

Console.WriteLine();
Console.WriteLine("----------------------------------------");
Console.WriteLine("           REGISTRO DE LIBRO");
Console.WriteLine("----------------------------------------");

Console.Write("Ingrese el código del libro: ");
int codigoNuevo = int.Parse(Console.ReadLine());

if (titulos.ContainsKey(codigoNuevo))
{
    Console.WriteLine("El código ingresado ya está registrado.");
}
else
{
    Console.WriteLine("Código disponible para registrar.");

    Console.Write("Ingrese el título del libro: ");
    string tituloNuevo = Console.ReadLine();

    Console.Write("Ingrese el autor del libro: ");
    string autorNuevo = Console.ReadLine();

    Console.Write("Ingrese la categoría del libro: ");
    string categoriaNueva = Console.ReadLine();

    Console.Write("Ingrese el número de ejemplares: ");
    int ejemplaresNuevos = int.Parse(Console.ReadLine());

    titulos.Add(codigoNuevo, tituloNuevo);
    autores.Add(codigoNuevo, autorNuevo);
    categoriasLibros.Add(codigoNuevo, categoriaNueva);
    ejemplares.Add(codigoNuevo, ejemplaresNuevos);

    categorias.Add(categoriaNueva);

    Console.WriteLine("Libro registrado correctamente.");
}

Console.WriteLine();
Console.WriteLine("Libro registrado:");
Console.WriteLine($"Código: {codigoNuevo}");
Console.WriteLine($"Título: {titulos[codigoNuevo]}");
Console.WriteLine($"Autor: {autores[codigoNuevo]}");
Console.WriteLine($"Categoría: {categoriasLibros[codigoNuevo]}");
Console.WriteLine($"Ejemplares: {ejemplares[codigoNuevo]}");

Console.WriteLine();
Console.WriteLine("----------------------------------------");
Console.WriteLine("          LIBROS REGISTRADOS");
Console.WriteLine("----------------------------------------");

foreach (int codigo in titulos.Keys)
{
    Console.WriteLine($"Código: {codigo}");
    Console.WriteLine($"Título: {titulos[codigo]}");
    Console.WriteLine($"Autor: {autores[codigo]}");
    Console.WriteLine($"Categoría: {categoriasLibros[codigo]}");
    Console.WriteLine($"Ejemplares: {ejemplares[codigo]}");
    Console.WriteLine("----------------------------------------");
}

Console.WriteLine();
Console.WriteLine("----------------------------------------");
Console.WriteLine("          BUSCAR LIBRO");
Console.WriteLine("----------------------------------------");

Console.Write("Ingrese el código del libro a buscar: ");
int codigoBuscar = int.Parse(Console.ReadLine());

if (titulos.ContainsKey(codigoBuscar))
{
    Console.WriteLine("Libro encontrado.");
    Console.WriteLine($"Título: {titulos[codigoBuscar]}");
    Console.WriteLine($"Autor: {autores[codigoBuscar]}");
    Console.WriteLine($"Categoría: {categoriasLibros[codigoBuscar]}");
    Console.WriteLine($"Ejemplares: {ejemplares[codigoBuscar]}");
}
else
{
    Console.WriteLine("El libro no está registrado.");
}

Console.WriteLine();
Console.WriteLine("----------------------------------------");
Console.WriteLine("       MODIFICAR EJEMPLARES");
Console.WriteLine("----------------------------------------");

Console.Write("Ingrese el código del libro: ");
int codigoModificar = int.Parse(Console.ReadLine());

if (ejemplares.ContainsKey(codigoModificar))
{
    Console.Write("Ingrese el nuevo número de ejemplares: ");
    int nuevosEjemplares = int.Parse(Console.ReadLine());

    ejemplares[codigoModificar] = nuevosEjemplares;

    Console.WriteLine("Número de ejemplares actualizado correctamente.");
    Console.WriteLine($"Ejemplares actuales: {ejemplares[codigoModificar]}");
}
else
{
    Console.WriteLine("El libro no está registrado.");
}

Console.WriteLine();
Console.WriteLine("----------------------------------------");
Console.WriteLine("          ELIMINAR LIBRO");
Console.WriteLine("----------------------------------------");

Console.Write("Ingrese el código del libro a eliminar: ");
int codigoEliminar = int.Parse(Console.ReadLine());

if (titulos.ContainsKey(codigoEliminar))
{
    titulos.Remove(codigoEliminar);
    autores.Remove(codigoEliminar);
    categoriasLibros.Remove(codigoEliminar);
    ejemplares.Remove(codigoEliminar);

    Console.WriteLine("Libro eliminado correctamente.");
}
else
{
    Console.WriteLine("El libro no está registrado.");
}

Console.WriteLine();
Console.WriteLine("----------------------------------------");
Console.WriteLine("          CATEGORÍAS DISPONIBLES");
Console.WriteLine("----------------------------------------");

foreach (string categoria in categorias)
{
    Console.WriteLine($"- {categoria}");
}

Console.WriteLine();
Console.WriteLine("----------------------------------------");
Console.WriteLine("       OPERACIONES ENTRE CONJUNTOS");
Console.WriteLine("----------------------------------------");

HashSet<string> conjuntoA = new HashSet<string>
{
    "Programación",
    "Redes",
    "Matemáticas",
    "Historia"
};

HashSet<string> conjuntoB = new HashSet<string>
{
    "Programación",
    "Redes",
    "Literatura"
};

HashSet<string> union = new HashSet<string>(conjuntoA);
union.UnionWith(conjuntoB);

HashSet<string> interseccion = new HashSet<string>(conjuntoA);
interseccion.IntersectWith(conjuntoB);

HashSet<string> diferencia = new HashSet<string>(conjuntoA);
diferencia.ExceptWith(conjuntoB);

Console.WriteLine("Conjunto A:");
foreach (string elemento in conjuntoA)
{
    Console.WriteLine($"- {elemento}");
}

Console.WriteLine();
Console.WriteLine("Conjunto B:");
foreach (string elemento in conjuntoB)
{
    Console.WriteLine($"- {elemento}");
}

Console.WriteLine();
Console.WriteLine("Unión:");
foreach (string elemento in union)
{
    Console.WriteLine($"- {elemento}");
}

Console.WriteLine();
Console.WriteLine("Intersección:");
foreach (string elemento in interseccion)
{
    Console.WriteLine($"- {elemento}");
}

Console.WriteLine();
Console.WriteLine("Diferencia A - B:");
foreach (string elemento in diferencia)
{
    Console.WriteLine($"- {elemento}");
}

Console.WriteLine();
Console.WriteLine("----------------------------------------");
Console.WriteLine("       CLAVES Y VALORES DEL DICCIONARIO");
Console.WriteLine("----------------------------------------");

foreach (int codigo in titulos.Keys)
{
    Console.WriteLine($"Clave: {codigo}");
    Console.WriteLine($"Valor: {titulos[codigo]}");
    Console.WriteLine("----------------------------------------");
}