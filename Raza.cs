public class Raza
{
    public string [] nombres = {"owo","uwu"};
    public string [] apodos = {"owo","uwu"};
    public void Elfo(Stats stat)
    {
        stat.armadura = new Random().Next(1,2);
        stat.destreza = new Random().Next(2,4);
        stat.velocidad = new Random().Next(2,4);
        stat.fuerza = new Random().Next(1,2);
    }

    public void Humano(Stats stat)
    {
        stat.armadura = new Random().Next(2,3);
        stat.destreza = new Random().Next(2,3);
        stat.velocidad = new Random().Next(2,3);
        stat.fuerza = new Random().Next(2,3);
    }

    public void Orco(Stats stat)
    {
        stat.armadura = new Random().Next(2,4);
        stat.destreza = new Random().Next(1,2);
        stat.velocidad = new Random().Next(1,2);
        stat.fuerza = new Random().Next(2,4);
    }

    public void selector(Personaje personaje)
    {
        switch (personaje.raza)
        {
            case razas.Elfo: Elfo(personaje.caracteristicas);
            break;
            case razas.Humano: Humano(personaje.caracteristicas);
            break;
            case razas.Orco: Orco(personaje.caracteristicas);
            break;
        }
    }
}