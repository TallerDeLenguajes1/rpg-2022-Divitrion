using System.Text.Json;

static class TextHelper
{
    public static void writeCSV(Personaje ganador)
    {
        using (StreamWriter sw = new StreamWriter(File.Open("ganadores.csv",FileMode.Append)))
        {
            sw.WriteLine($"{ganador.Rasgos.Nombre},{ganador.Rasgos.Clase},{ganador.Rasgos.Apodo}\n");
            sw.Close();
        }
    }

    public static void writeJSON(List<Personaje> personajes)
    {
           string texto = JsonSerializer.Serialize(personajes);
           File.WriteAllText("jugadores.json", texto);

    }

    public static string readJSON(string ruta)
    {
        string jsonText;
        jsonText= File.ReadAllText(ruta);
        return jsonText;
    }

    public static List<Personaje> jsonConverter(string jsonText)
    {
        return JsonSerializer.Deserialize<List<Personaje>>(jsonText);
    }
}