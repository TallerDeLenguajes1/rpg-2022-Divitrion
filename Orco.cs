public class Orco
{
    public string [] nombres = {"owo","uwu"};
    public string [] apodos = {"owo","uwu"};
    public Orco(Personaje personaje)
    {
        personaje.armadura = new Random().Next(2,4);
        personaje.destreza = new Random().Next(1,2);
        personaje.velocidad = new Random().Next(1,2);
        personaje.fuerza = new Random().Next(2,4);
    }
}