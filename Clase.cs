public class Clase
{
    public void Guerrero(SkillSet habilidades)
    {
        habilidades.basico.Damage=5;
        habilidades.basico.CD=0;
        habilidades.basico.tipo=tipos.fisico;

        habilidades.especial.Damage=15;
        habilidades.especial.CD=2;
        habilidades.especial.tipo=tipos.fisico;

        habilidades. ulti.Damage=25;
        habilidades. ulti.CD=4;
        habilidades. ulti.tipo=tipos.fisico;
    }

    public void Mago(SkillSet habilidades)
    {
        habilidades.basico.Damage=5;
        habilidades.basico.CD=0;
        habilidades.basico.tipo=tipos.magico;

        habilidades.especial.Damage=15;
        habilidades.especial.CD=2;
        habilidades.especial.tipo=tipos.magico;

        habilidades. ulti.Damage=25;
        habilidades. ulti.CD=4;
        habilidades. ulti.tipo=tipos.magico;
    }

    public void Picaro(SkillSet habilidades)
    {
        habilidades.basico.Damage=5;
        habilidades.basico.CD=0;
        habilidades.basico.tipo=tipos.fisico;

        habilidades.especial.Damage=15;
        habilidades.especial.CD=2;
        habilidades.especial.tipo=tipos.fisico;

        habilidades. ulti.Damage=25;
        habilidades. ulti.CD=4;
        habilidades. ulti.tipo=tipos.fisico;
    }

    public void selector(Personaje personaje)
    {
        switch (personaje.clase)
        {
            case clases.Guerrero:Guerrero(personaje.habilidad);
            break;
            case clases.Mago:Mago(personaje.habilidad);
            break;
            case clases.Picaro:Picaro(personaje.habilidad);
            break;
        }
    }
}