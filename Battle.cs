public class Battle
{
    private double VA;
    private int AD;
    private double Damage;
    public void hit(Personaje atacante,Personaje defensor)
    {
        if (atacante.habilidad.ulti.CD == 0)
        {
            AD=atacante.habilidad.ulti.Damage;
        }else if(atacante.habilidad.especial.CD == 0)
        {
            AD=atacante.habilidad.especial.Damage;
        }else
        {
            AD=atacante.habilidad.basico.Damage;
        }
        switch (atacante.clase)
        {
            case clases.Guerrero:new Frames().guerrero();
            break;
            case clases.Mago:new Frames().mago();
            break;
            case clases.Picaro:new Frames().picaro();
            break;
        }
        VA= ((2*atacante.caracteristicas.nivel)/50)+2;
        Damage=(VA*AD*(atacante.caracteristicas.fuerza/defensor.caracteristicas.armadura));
        defensor.caracteristicas.salud -= Damage;
    }

    public void Start(Personaje participante1, Personaje participante2)
    {
        if (participante1.caracteristicas.velocidad>participante2.caracteristicas.velocidad)
        {
            participante1.turno=true;
        }else
        {
            participante2.turno=true;
        }
        while (participante1.caracteristicas.salud > 0 && participante2.caracteristicas.salud > 0)
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
        if (personaje.habilidad.ulti.CD>0)
        {
            personaje.habilidad.ulti.CD--;
        }else
        {
            personaje.habilidad.ulti.CD=4;
        }

        if (personaje.habilidad.especial.CD>0)
        {
            personaje.habilidad.especial.CD--;
        }else
        {
            personaje.habilidad.especial.CD=2;
        }
    }

}