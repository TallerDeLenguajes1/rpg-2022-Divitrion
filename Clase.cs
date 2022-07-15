public class Clase
{
    public static void Guerrero(SkillSet habilidades)
    {
        habilidades.basico.Damage=8;
        habilidades.basico.CD=0;

        habilidades.especial.Damage=15;
        habilidades.especial.CD=2;

        habilidades.ulti.Damage=25;
        habilidades.ulti.CD=4;
    }

    public static void Mago(SkillSet habilidades)
    {
        habilidades.basico.Damage=2;
        habilidades.basico.CD=0;

        habilidades.especial.Damage=18;
        habilidades.especial.CD=3;

        habilidades.ulti.Damage=35;
        habilidades.ulti.CD=6;
    }

    public static void Picaro(SkillSet habilidades)
    {
        habilidades.basico.Damage=3;
        habilidades.basico.CD=0;

        habilidades.especial.Damage=10;
        habilidades.especial.CD=1;

        habilidades.ulti.Damage=15;
        habilidades.ulti.CD=2;
    }

    public static void selector(Personaje personaje)
    {
        switch (personaje.Rasgos.Clase)
        {
            case clases.Guerrero:Guerrero(personaje.Habilidad);
            break;
            case clases.Mago:Mago(personaje.Habilidad);
            break;
            case clases.Picaro:Picaro(personaje.Habilidad);
            break;
        }
    }
}