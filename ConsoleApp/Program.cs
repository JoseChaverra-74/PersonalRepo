
/* Persona persona1 = new Persona();

persona1.Id = 1234567;
persona1.Nombre = "Pedro Perez";
persona1.Edad = 23;

Console.WriteLine("Nombre: " + persona1.Nombre);
Console.WriteLine("Edad: " + persona1.Edad);
Console.WriteLine("Documento: " + persona1.Id); */

/* public class Persona
{
	public int Id;
	public string? Nombre;
	public int Edad;
} */

/* Coche coche1 = new Coche();

coche1.Marca = "Toyota";
coche1.Modelo = "Corolla";
coche1.Año = 2020;

coche1.MostrarInfo();

public class Coche
{
	public string? Marca;
	public string? Modelo;
	public int Año;

	public void MostrarInfo()
	{
		Console.WriteLine("Coche: " + this.Marca + ", " + this.Modelo + ", " + this.Año);
	}
}
 */


Console.WriteLine("Hello, World!");

var persona = new Personas();
Personas persona1 = new Personas();
Personas persona2 = new Estudiantes();

persona.Id = 1;
persona.Nombre = "Pepito Perez";
persona.Activo = true;
persona.Salario = 1400000.0m;
persona.Estado = new Estados() { Id = 1, Nombre = "Casado" };
persona.VideoJuegos = new List<VideoJuegos>();
persona.VideoJuegos.Add(new VideoJuegos() { Id = 1, Nombre = "LOZ 2025" });
persona.VideoJuegos.Add(new VideoJuegos() { Id = 2, Nombre = "Tetrix" });

Console.WriteLine(persona.Nombre);
Console.WriteLine(persona.Estado.Nombre);

foreach (var elemento in persona.VideoJuegos)
{
    Console.WriteLine(elemento.Nombre);
}

public class Estados
{
    public int Id = 0;
    public String? Nombre = "";
}

public class VideoJuegos
{
    public int Id = 0;
    public String? Nombre = "";
}

public class Personas
{
    public int Id = 0;
    public String? Nombre = "";
    public DateTime Fecha = DateTime.Now;
    public bool Activo = false;
    public decimal Salario = 0.0m;
    public Estados Estado = new Estados();
    public List<VideoJuegos> VideoJuegos = new List<VideoJuegos>();
}

public class Estudiantes : Personas
{
    public String? Carnet = "";
}