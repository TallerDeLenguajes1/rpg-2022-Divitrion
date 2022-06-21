using System.Text.Json;

public class TextHelper
{
    public void writeCSV(Personaje ganador)
    {
        using (StreamWriter sw = new StreamWriter(File.Open("ganadores.csv",FileMode.Append)))
        {
            sw.WriteLine($"{ganador.Rasgos.Nombre},{ganador.Rasgos.Clase},{ganador.Rasgos.Apodo}\n");
            sw.Close();
        }
    }

    public void writeJSON(List<Personaje> personajes)
    {

           string texto = JsonSerializer.Serialize(personajes);
           File.WriteAllText("jugadores.json",texto);

    }
}