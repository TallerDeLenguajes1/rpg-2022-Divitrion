public class Battle
{
    private int PD;
    private double ED;
    private double VA;
    private int PDef;
    private int max=50000;
    private double Damage;
    public void hit(Personaje atacante,Personaje defensor)
    {
        PD = atacante.caracteristicas.destreza*atacante.caracteristicas.fuerza*atacante.caracteristicas.nivel;
        ED = new Random().Next(1,100);
        VA = PD * ED;
        PDef = defensor.caracteristicas.armadura*defensor.caracteristicas.velocidad;
        Damage=(((VA*ED)-PDef)/max)*10;
        defensor.caracteristicas.salud=defensor.caracteristicas.salud - Damage;
        if (defensor.caracteristicas.salud<0)
        {
            defensor.caracteristicas.salud=0;
        }
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
        for (int i = 0; i < 3; i++)
        {
            if (participante1.turno)
            {
                hit(participante1,participante2);
                participante1.turno=false;
                participante2.turno=true;
            }else
            {
                hit(participante2,participante1);
                participante1.turno=true;
                participante2.turno=false;
            }
        }
    }
}