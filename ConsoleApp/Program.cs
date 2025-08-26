
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

Coche coche1 = new Coche();

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


