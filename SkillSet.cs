public class SkillSet
{
    public Skill basico { get; set; } = new Skill();
    public Skill especial { get; set; } = new Skill();
    public Skill ulti { get; set; } = new Skill();
}
public class Skill
{
    public int Damage { get; set; }
    public int CD { get; set; }
}

