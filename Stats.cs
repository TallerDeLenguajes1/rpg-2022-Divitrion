public class Stats
{
    public double salud;
    public int velocidad;
    public int destreza;
    public int fuerza;
    public int nivel;
    public int armadura;

    public void Mostrar()
    {
        Console.WriteLine($"Nivel: {nivel}\n");
        Console.WriteLine($"Salud: {Math.Ceiling(salud)}\n");
        Console.WriteLine($"Destreza: {destreza}\n");
        Console.WriteLine($"Fuerza: {fuerza}\n");
        Console.WriteLine($"Armadura: {armadura}\n");
        Console.WriteLine($"Velocidad: {velocidad}\n");
    }
}