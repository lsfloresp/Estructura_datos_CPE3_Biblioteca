using System;
using System.Collections.Generic;

public class Biblioteca
{
    // Conjunto para almacenar las categorías
    private HashSet<string> categorias = new HashSet<string>();

    // Diccionarios para almacenar la información de los libros
    private Dictionary<int, string> titulos = new Dictionary<int, string>();
    private Dictionary<int, string> autores = new Dictionary<int, string>();
    private Dictionary<int, string> categoriasLibros = new Dictionary<int, string>();
    private Dictionary<int, int> ejemplares = new Dictionary<int, int>();



    public void RegistrarLibro(int codigo, string titulo, string autor, string categoria, int cantidadEjemplares)
{
    if (titulos.ContainsKey(codigo))
    {
        Console.WriteLine("El código ingresado ya está registrado.");
    }
    else
    {
        titulos.Add(codigo, titulo);
        autores.Add(codigo, autor);
        categoriasLibros.Add(codigo, categoria);
        ejemplares.Add(codigo, cantidadEjemplares);

        categorias.Add(categoria);

        Console.WriteLine("Libro registrado correctamente.");
    }
}
    public void MostrarLibros()
{
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
}
    public void BuscarLibro(int codigo)
{
    if (titulos.ContainsKey(codigo))
    {
        Console.WriteLine("Libro encontrado.");
        Console.WriteLine($"Título: {titulos[codigo]}");
        Console.WriteLine($"Autor: {autores[codigo]}");
        Console.WriteLine($"Categoría: {categoriasLibros[codigo]}");
        Console.WriteLine($"Ejemplares: {ejemplares[codigo]}");
    }
    else
    {
        Console.WriteLine("El libro no está registrado.");
    }
}
    public void ModificarEjemplares(int codigo, int nuevosEjemplares)   
{
    if (ejemplares.ContainsKey(codigo))
    {
        ejemplares[codigo] = nuevosEjemplares;

        Console.WriteLine("Número de ejemplares actualizado correctamente.");
        Console.WriteLine($"Ejemplares actuales: {ejemplares[codigo]}");
    }
    else
    {
        Console.WriteLine("El libro no está registrado.");
    }
}
    public void EliminarLibro(int codigo)
{
    if (titulos.ContainsKey(codigo))
    {
        titulos.Remove(codigo);
        autores.Remove(codigo);
        categoriasLibros.Remove(codigo);
        ejemplares.Remove(codigo);

        Console.WriteLine("Libro eliminado correctamente.");
    }
    else
    {
        Console.WriteLine("El libro no está registrado.");
    }
}
    public void MostrarCategorias()
{
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("       CATEGORÍAS DISPONIBLES");
    Console.WriteLine("----------------------------------------");

    foreach (string categoria in categorias)
    {
        Console.WriteLine($"- {categoria}");
    }
}
    public void OperacionesConjuntos()
{
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

    Console.WriteLine("----------------------------------------");
    Console.WriteLine("       OPERACIONES ENTRE CONJUNTOS");
    Console.WriteLine("----------------------------------------");

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
}
}