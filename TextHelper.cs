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
       using (var sw = new StreamWriter(File.Open("jugadores.json",FileMode.Create)))
       {
           string texto = JsonSerializer.Serialize(personajes);
           sw.WriteLine(texto);
           sw.Close();
       }

    }
}