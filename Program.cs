using System.Net;
using System.Text.Json;

var participantes = new List<Personaje>();
var localizacion = get();

int end=0;
int choice;
    do
    {
        Menu.main();
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
                Console.WriteLine("-------------------------------------");
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
Console.WriteLine("-------------------------------------");
Console.WriteLine($"El torneo de hoy transcurre en la region de: {localizacion.region.name.ToUpper()}!!\n");
Console.WriteLine($"En la ubicacion: {localizacion.names.First().name}!");
Console.WriteLine("-------------------------------------");
System.Threading.Thread.Sleep(1000);
TextHelper.writeJSON(participantes);
Game.StartTourney(participantes);

participantes[0].Rasgos.Mostrar();
participantes[0].Caracteristicas.Mostrar();

static Location get()
{
    var url = $"https://pokeapi.co/api/v2/location/{new Random().Next(1,51)}/";
    var request = (HttpWebRequest)WebRequest.Create(url);
    request.Method = "GET";
    request.ContentType = "application/json";
    request.Accept = "application/json";

    try
    {
        using (WebResponse response = request.GetResponse())
        {
            using (Stream strReader = response.GetResponseStream())
            {
                if (strReader == null) return null;
                using (StreamReader objReader = new StreamReader(strReader))
                {
                    string responseBody = objReader.ReadToEnd();
                    var location = JsonSerializer.Deserialize<Location>(responseBody);
                    return location;
                }
            }
        }
    }
    catch (System.Exception)
    {

        throw;
    }
}