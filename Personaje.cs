public enum tipos
{
    Orco=1,
    Elfo=2,
    Humano=3
}

public class Personaje
{
    public int velocidad;
    public int destreza;
    public int fuerza;
    public int nivel;
    public int armadura;
    public int edad;
    public double salud;
    public string apodo;
    public string nombre;
    public DateTime fechaNac;
    public tipos tipo;
    public int ID;
    public bool turno=false;

    public Personaje()
    {
        nivel = 1;
        velocidad = 0;
        destreza = 0;
        fuerza = 0;
        armadura = 0;
        tipo = (tipos)new Random().Next(1,3);
        salud = 100;
    }

    public void Caracteristicas()
    {
        Console.WriteLine($"Nivel: {nivel}\n");
        Console.WriteLine($"Salud: {salud}\n");
        Console.WriteLine($"Destreza: {destreza}\n");
        Console.WriteLine($"Fuerza: {fuerza}\n");
        Console.WriteLine($"Armadura: {armadura}\n");
        Console.WriteLine($"Velocidad: {velocidad}\n");
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
        nivel++;
        velocidad = velocidad + new Random().Next(1,2);
        destreza = destreza + new Random().Next(1,2);
        fuerza = fuerza + new Random().Next(1,2);
        armadura = armadura + new Random().Next(1,2);
        salud+=salud*0.2;
    }
    
}