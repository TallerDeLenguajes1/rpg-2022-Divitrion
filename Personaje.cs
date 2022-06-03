public enum razas
{
    Orco=1,
    Elfo=2,
    Humano=3
}

public enum clases
{
    Guerrero=1,
    Mago=2,
    Picaro=3
}

public class Personaje
{
    public Stats caracteristicas = new Stats();
    public SkillSet habilidad= new SkillSet();
    public int edad;
    public string apodo;
    public string nombre;
    public DateTime fechaNac;
    public razas raza;
    public clases clase;
    public int ID;
    public bool turno=false;

    public Personaje()
    {
        caracteristicas.nivel = 1;
        caracteristicas.velocidad = 0;
        caracteristicas.destreza = 0;
        caracteristicas.fuerza = 0;
        caracteristicas.armadura = 0;
        raza = (razas)new Random().Next(1,4);
        clase = (clases)new Random().Next(1,4);
        caracteristicas.salud = 100;
    }

    public void Datos()
    {
        Console.WriteLine($"Tipo: {raza}\n");
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