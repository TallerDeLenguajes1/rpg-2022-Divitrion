class Elfo
{
    public string [] nombres = {"owo","uwu"};
    public string [] apodos = {"owo","uwu"};
    public Elfo(Stats stat)
    {
        stat.armadura = new Random().Next(1,2);
        stat.destreza = new Random().Next(2,4);
        stat.velocidad = new Random().Next(2,4);
        stat.fuerza = new Random().Next(1,2);
    }
}