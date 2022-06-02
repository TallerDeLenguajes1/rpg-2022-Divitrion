public class Game
{
    public void StartTourney(List<Personaje> personajes)
    {
        Personaje perdedor;
        while (personajes.Count != 1)
        {
            int stop = personajes.Count;
            var perdedores = new List<Personaje>();
            int k=0;
            while ((2*k+1)<=(stop-1))
            {
                new Battle().Start(personajes[2*k],personajes[2*k+1]);
                if (personajes[2*k].salud == personajes[2*k+1].salud)
                {
                    if (new Random().Next(1,2) != 1)
                    {
                        perdedor = personajes[2*k];
                    }else
                    {
                        perdedor=personajes[2*k+1];
                    }
                }else if (personajes[2*k].salud > personajes[2*k+1].salud)
                    {
                        perdedor=personajes[2*k+1];
                    }else
                    {
                        perdedor=personajes[2*k];
                    }
                perdedores.Add(perdedor);
                k++;
            }
            for (int i = 0; i < personajes.Count; i++)
            {
                for (int j = 0; j < perdedores.Count; j++)
                {
                    if (personajes[i].ID==perdedores[j].ID)
                    {
                        personajes.Remove(perdedores[j]);
                    }
                }
            }
            foreach (var personaje in personajes)
            {
                personaje.LevelUp();
            }
        }
    }
}