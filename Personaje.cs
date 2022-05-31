public enum tipos
{

}

public class Personaje
{
    public int velocidad;
    public int destreza;
    public int fuerza;
    public int nivel;
    public int armadura;
    public int edad;
    public int salud;
    public string apodo;
    public string nombre;
    public DateTime fechaNac;
    public tipos tipo;

    public Personaje()
    {
        velocidad = new Random().Next(1,10);
        destreza = new Random().Next(1,5);
        fuerza = new Random().Next(1,10);
        nivel = new Random().Next(1,10);
        armadura = new Random().Next(1,10);
        salud = 100;
    }
    
}