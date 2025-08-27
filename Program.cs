// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;

var persona = new Personas();
Personas persona1 = new Personas();
var persona2 = new Estudiantes(); //SI es: Personas persona2 = new Estudiantes(); no funcion (o eso creo), (Es polimorfismo si es Personas persona2)

persona.Id = 1;
persona.Nombre = "Pepito Perez";
persona.Activo = true;
persona.Salario = 1400000.0m;
persona.Tipo = new Tipos() { Id = 1, Nombre = "Casado" };
persona.VideoJuegos = new List<VideoJuegos>();
persona.VideoJuegos.Add(new VideoJuegos() { Id = 1, Nombre = "LOZ 2025" });
persona.VideoJuegos.Add(new VideoJuegos() { Id = 2, Nombre = "Tetrix" });

Console.WriteLine(persona.Nombre);
Console.WriteLine(persona.Tipo.Nombre);

foreach (var elemento in persona.VideoJuegos)
{
    Console.WriteLine(elemento.Nombre);
}

Console.WriteLine("\n"); //caracter de salto de linea

persona2.Id = 2;
persona2.Nombre = "Juan Carlos";
persona2.Activo = false;
persona2.Salario = 140.0m;
persona2.Tipo = new Tipos() { Id = 2, Nombre = "Soltero" };
persona2.VideoJuegos = new List<VideoJuegos>();
persona2.VideoJuegos.Add(new VideoJuegos() { Id = 4, Nombre = "GTA" });
persona2.VideoJuegos.Add(new VideoJuegos() { Id = 3, Nombre = "ZZZ" });
persona2.Carnet = "1025465789";

Console.WriteLine(persona2.Nombre);
Console.WriteLine(persona2.Carnet);
foreach (var i in persona2.VideoJuegos)
{
    Console.WriteLine(i.Id);
    Console.WriteLine(i.Nombre);
}

public class Tipos
{
    public int Id = 0; //o public int Id; Este atributo NO puede ser nulo
    public String? Nombre = ""; //o public String? Nombre; Este atributo puede ser nulo (Por eso el "?")
}

public class VideoJuegos
{
    public int Id = 0;
    public string? Nombre = "";
}

public class Personas
{
    public int Id = 0;
    public string? Nombre = "";
    public DateTime Fecha = DateTime.Now;
    public bool Activo = false;
    public decimal Salario = 0.0m;
    public Tipos Tipo = new Tipos();
    public List<VideoJuegos> VideoJuegos = new List<VideoJuegos>();
}

public class Estudiantes : Personas, Estudiantes2, Seguros //herencia
{
    public string? Carnet = "";
    public bool Matricula()
    {
        return true;
    }

    public decimal Seguro(string nombre)
    {
        return 0.0m;
    }
}
public interface Estudiantes2
{
    bool Matricula();
}

public interface Seguros
{
    decimal Seguro(string nombre);
}
/*
Console.WriteLine("Hello, World!");

Personas persona = new Personas();
var persona1 = new Personas();
Estudiantes persona2 = new Estudiantes();
Personas persona3 = persona2;
Personas persona4 = (Personas)persona2;
Personas persona5 = (Estudiantes)persona2;

persona.Id = 1;
persona.Nombre = "Pepito Perez";
persona.Estatura = 1.60m;
persona.Vive = false;
persona.Fecha = DateTime.Now;
persona.Estado = new Estados() { Id = 1, Nombre = "Viudo" };
persona.VideoJuegos = new List<VideoJuegos>();
persona.VideoJuegos.Add(new VideoJuegos() { Id = 1, Nombre = "GTA" });
persona.VideoJuegos.Add(new VideoJuegos() { Id = 2, Nombre = "DOOM" });

Console.WriteLine(persona.Nombre);
Console.WriteLine(persona.Estado.Nombre);

foreach (var elemento in persona.VideoJuegos)
{
    Console.WriteLine(elemento.Nombre);
}

public class Estados
{
    public int Id;
    public string? Nombre;
}

public class VideoJuegos
{
    public int Id;
    public string? Nombre;
}

public class Personas
{
    public int Id;
    public string? Nombre;
    public decimal Estatura;
    public bool Vive;
    public DateTime Fecha;
    public Estados? Estado;
    public List<VideoJuegos>? VideoJuegos;
}

public class Estudiantes : Personas
{
    public string? Carnet;
}
*/

//Clase 26/08/2025