public class Humano
{
    public string [] nombres = {"owo","uwu"};
    public string [] apodos = {"owo","uwu"};
     public Humano(Personaje personaje)
    {
        personaje.armadura = new Random().Next(2,3);
        personaje.destreza = new Random().Next(2,3);
        personaje.velocidad = new Random().Next(2,3);
        personaje.fuerza = new Random().Next(2,3);
        personaje.edad= new Random().Next(18,60);
    }
}