var participantes = new List<Personaje>();

for (int i = 0; i < 4; i++)
{
    var personaje= new Personaje();
    personaje.ID=i+1;
    new Raza().selector(personaje);
    new Clase().selector(personaje);
    participantes.Add(personaje);
}
new Game().StartTourney(participantes);

participantes[0].caracteristicas.Mostrar();





