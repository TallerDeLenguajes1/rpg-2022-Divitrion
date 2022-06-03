public class Humano
{
    public string [] nombres = {"owo","uwu"};
    public string [] apodos = {"owo","uwu"};
     public Humano(Stats stat)
    {
        stat.armadura = new Random().Next(2,3);
        stat.destreza = new Random().Next(2,3);
        stat.velocidad = new Random().Next(2,3);
        stat.fuerza = new Random().Next(2,3);
    }
}