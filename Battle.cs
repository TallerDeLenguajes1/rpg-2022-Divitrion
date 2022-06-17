public class Battle
{
    private double VA; // Attack Value
    private int AD; // Attack damage
    private double totalDamage;
    public void hit(Personaje atacante,Personaje defensor)
    {
        if (atacante.Habilidad.ulti.CD == 0)
        {
            AD=atacante.Habilidad.ulti.Damage;
        }else if(atacante.Habilidad.especial.CD == 0)
        {
            AD=atacante.Habilidad.especial.Damage;
        }else
        {
            AD=atacante.Habilidad.basico.Damage;
        }
        VA= ((2*atacante.Caracteristicas.Nivel)/50)+2;
        totalDamage=(VA*AD*(atacante.Caracteristicas.Fuerza/defensor.Caracteristicas.Armadura));
        if (new Random().Next(0,100) > 75)
        {
            defensor.Caracteristicas.Salud -= totalDamage * 1.5;
        }else
        {
            defensor.Caracteristicas.Salud -= totalDamage;
        }
    }

    public void Start(Personaje participante1, Personaje participante2)
    {
        if (participante1.Caracteristicas.Velocidad>participante2.Caracteristicas.Velocidad)
        {
            participante1.turno=true;
        }else
        {
            participante2.turno=true;
        }
        while (participante1.Caracteristicas.Salud > 0 && participante2.Caracteristicas.Salud > 0)
        {
            turno(participante1,participante2);
        }
    }

    public void turno(Personaje personaje1,Personaje personaje2)
    {
        if (personaje1.turno)
        {
            hit(personaje1,personaje2);
            reduceCD(personaje1);
            personaje1.turno=false;
        }else
        {
            hit(personaje2,personaje1);
            reduceCD(personaje2);
            personaje1.turno=true;
        }
    }

    public void reduceCD(Personaje personaje)
    {
        if (personaje.Habilidad.ulti.CD>0)
        {
            personaje.Habilidad.ulti.CD--;
        }else
        {
            personaje.Habilidad.ulti.CD=4;
        }

        if (personaje.Habilidad.especial.CD>0)
        {
            personaje.Habilidad.especial.CD--;
        }else
        {
            personaje.Habilidad.especial.CD=2;
        }
    }

}