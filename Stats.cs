public class Stats
{
    private double salud;
    private int velocidad,destreza,fuerza,nivel,armadura;


    public double Salud {get => salud; set => salud = value;}
    public int Velocidad {get => velocidad; set => velocidad = value;}
    public int Destreza {get => destreza; set => destreza = value;}
    public int Fuerza {get => fuerza; set => fuerza = value;}
    public int Nivel {get => nivel; set => nivel = value;}
    public int Armadura {get => armadura; set => armadura = value;}

    public void Mostrar()
    {
        Console.WriteLine($"Nivel: {Nivel}\n");
        Console.WriteLine($"Salud: {Math.Ceiling(Salud)}\n");
        Console.WriteLine($"Destreza: {Destreza}\n");
        Console.WriteLine($"Fuerza: {Fuerza}\n");
        Console.WriteLine($"Armadura: {Armadura}\n");
        Console.WriteLine($"Velocidad: {Velocidad}");
    }

    public Stats()
    {
        this.Nivel = 1;
        this.Salud = 100;
    }
}