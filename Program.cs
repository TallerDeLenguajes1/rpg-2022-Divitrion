﻿var participantes = new List<Personaje>();

for (int i = 0; i < 8; i++)
{
    var personaje= new Personaje();
    personaje.ID=i+1;
    switch (personaje.tipo)
    {
        case tipos.Elfo: new Elfo(personaje);
        break;
        case tipos.Humano: new Humano(personaje);
        break;
        case tipos.Orco: new Orco(personaje);
        break;
    }
    participantes.Add(personaje);
}
new Game().StartTourney(participantes);

participantes[0].Caracteristicas();





