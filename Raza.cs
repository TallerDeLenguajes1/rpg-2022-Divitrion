public class Raza
{
    public string [] nombres = {"owo","uwu"};
    public string [] apodos = {"owo","uwu"};
    public void Elfo(Stats stat)
    {
        stat.Armadura = new Random().Next(1,2);
        stat.Destreza = new Random().Next(2,4);
        stat.Velocidad = new Random().Next(2,4);
        stat.Fuerza = new Random().Next(1,2);
    }

    public void Humano(Stats stat)
    {
        stat.Armadura = new Random().Next(2,3);
        stat.Destreza = new Random().Next(2,3);
        stat.Velocidad = new Random().Next(2,3);
        stat.Fuerza = new Random().Next(2,3);
    }

    public void Orco(Stats stat)
    {
        stat.Armadura = new Random().Next(2,4);
        stat.Destreza = new Random().Next(1,2);
        stat.Velocidad = new Random().Next(1,2);
        stat.Fuerza = new Random().Next(2,4);
    }

    public void selector(Personaje personaje)
    {
        switch (personaje.Rasgos.Raza)
        {
            case razas.Elfo: Elfo(personaje.Caracteristicas);
            break;
            case razas.Humano: Humano(personaje.Caracteristicas);
            break;
            case razas.Orco: Orco(personaje.Caracteristicas);
            break;
        }
    }
}