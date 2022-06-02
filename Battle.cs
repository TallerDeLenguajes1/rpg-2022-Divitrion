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
        PD = atacante.destreza*atacante.fuerza*atacante.nivel;
        ED = new Random().Next(1,100);
        VA = PD * ED;
        PDef = defensor.armadura*defensor.velocidad;
        Damage=(((VA*ED)-PDef)/max)*100;
        defensor.salud=defensor.salud - Damage;
        if (defensor.salud<0)
        {
            defensor.salud=0;
        }
    }

    public void Start(Personaje participante1, Personaje participante2)
    {
        if (participante1.velocidad>participante2.velocidad)
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