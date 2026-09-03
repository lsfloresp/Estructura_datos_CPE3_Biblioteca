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
}