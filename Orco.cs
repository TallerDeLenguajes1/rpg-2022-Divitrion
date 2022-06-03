public class Orco
{
    public string [] nombres = {"owo","uwu"};
    public string [] apodos = {"owo","uwu"};
    public Orco(Stats stat)
    {
        stat.armadura = new Random().Next(2,4);
        stat.destreza = new Random().Next(1,2);
        stat.velocidad = new Random().Next(1,2);
        stat.fuerza = new Random().Next(2,4);
    }
}