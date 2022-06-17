public enum razas
{
    Orco=1,
    Elfo=2,
    Humano=3
}

public enum clases
{
    Guerrero=1,
    Mago=2,
    Picaro=3
}

public class Personaje
{
    private Stats caracteristicas;
    private SkillSet habilidad;
    private Traits rasgos;
    private int id;

    public Stats Caracteristicas {get => caracteristicas; set => caracteristicas = value;}
    public SkillSet Habilidad {get => habilidad; set => habilidad= value;}
    public Traits Rasgos {get => rasgos; set => rasgos = value;}
    public int ID {get => id; set => id = value;}
    public bool turno=false;

    public Personaje()
    {
        this.caracteristicas= new Stats();
        this.habilidad = new SkillSet();
        this.rasgos = new Traits();
    }

    public void LevelUp()
    {
        caracteristicas.Nivel++;
        caracteristicas.Velocidad += new Random().Next(1,2);
        caracteristicas.Destreza +=  new Random().Next(1,2);
        caracteristicas.Fuerza +=  new Random().Next(1,2);
        caracteristicas.Armadura += new Random().Next(1,2);
    }
}