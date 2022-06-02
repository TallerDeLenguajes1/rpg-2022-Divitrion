class Elfo
{
    public string [] nombres = {"owo","uwu"};
    public string [] apodos = {"owo","uwu"};
    public Elfo(Personaje personaje)
    {
        personaje.armadura = new Random().Next(1,2);
        personaje.destreza = new Random().Next(2,4);
        personaje.velocidad = new Random().Next(2,4);
        personaje.fuerza = new Random().Next(1,2);
        personaje.edad= new Random().Next(100,300);
    }
}