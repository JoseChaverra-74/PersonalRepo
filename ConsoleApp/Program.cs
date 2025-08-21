// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Vehiculos vehiculo = new Vehiculos();
vehiculo.Placa = "JJJ000";
vehiculo.Tipo = "Eléctrico";
vehiculo.Marca = "Tesla";
vehiculo.Cc = 1020.0m;
vehiculo.Fecha = DateTime.Now;

public class Vehiculos
{
    public string? Placa;
    public string? Tipo;
    public decimal Cc;
    public string? Marca;
    public DateTime Fecha;
}

public class Modos
{
    public int Id;
    public string? Nombre;
}
public class Carros : Vehiculos
{
    public int Llantas;
    public bool Funciona;
    public Modos? Modos;

}

