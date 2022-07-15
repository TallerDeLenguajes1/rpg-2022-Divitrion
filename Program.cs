new Menu().main();
var participantes = new List<Personaje>();

int end=0;
int choice;
    do
    {
        Console.WriteLine("Jugar [1]");
        Console.WriteLine("Seleccionar lista de personajes [2]");
        choice = Convert.ToInt32(Console.ReadLine());
        if (choice == 1)
        {
            for (int i = 0; i < 8; i++)
                {
                    var personaje= new Personaje();
                    personaje.ID=i+1;
                    Traits.Age(personaje.Rasgos);
                    Raza.selector(personaje);
                    Clase.selector(personaje);
                    participantes.Add(personaje);
                }
            end = 1;
        }
        if (choice == 2)
        {
            var listaPersonajes=TextHelper.jsonConverter(TextHelper.readJSON("jugadores.json"));
            foreach (var personaje in listaPersonajes)
            {
                personaje.Rasgos.Mostrar();
                personaje.Caracteristicas.Mostrar();
            }
            Console.WriteLine("Quiere jugar con estos personajes? Si [1] No [2]");
            choice= Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                participantes=listaPersonajes;
                end=1;
            }
        }
    } while (end != 1);
Naming.Selector(participantes);
TextHelper.writeJSON(participantes);
Game.StartTourney(participantes);

participantes[0].Rasgos.Mostrar();
participantes[0].Caracteristicas.Mostrar();