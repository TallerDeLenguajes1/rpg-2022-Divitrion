public enum tipos
{
    Orco=1,
    Elfo=2,
    Humano=3
}

public class Personaje
{
    public Stats caracteristicas = new Stats();
    public int edad;
    public string apodo;
    public string nombre;
    public DateTime fechaNac;
    public tipos tipo;
    public int ID;
    public bool turno=false;

    public Personaje()
    {
        caracteristicas.nivel = 1;
        caracteristicas.velocidad = 0;
        caracteristicas.destreza = 0;
        caracteristicas.fuerza = 0;
        caracteristicas.armadura = 0;
        tipo = (tipos)new Random().Next(1,3);
        caracteristicas.salud = 100;
    }

    public void Datos()
    {
        Console.WriteLine($"Tipo: {tipo}\n");
        Console.WriteLine($"Nombre: {nombre}\n");
        Console.WriteLine($"Apodo: {apodo}\n");
        Console.WriteLine($"Fecha de nacimiento: {fechaNac}\n");
        Console.WriteLine($"Edad: {edad}\n");
    }

    public void LevelUp()
    {
        caracteristicas.nivel++;
        caracteristicas.velocidad += new Random().Next(1,2);
        caracteristicas.destreza +=  new Random().Next(1,2);
        caracteristicas.fuerza +=  new Random().Next(1,2);
        caracteristicas.armadura += new Random().Next(1,2);
    }
    
}