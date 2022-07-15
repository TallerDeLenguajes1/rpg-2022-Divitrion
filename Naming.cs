public class Naming
{
    public static void Selector(List<Personaje> personajes)
    {
        string[] ElfName = new string[] {"Glynran Starmane","Sylsandoral Emberflight","Kearan Willowbreath","Keamaris Siaphostrethra","Ralomaer Yieshixith","Gilsatra Shadowrest","Eilhana Shudri","Faephine Farhold"};
        string[] OrcName = new string[] {"Shun","Drall","Rhak","Shab","Zaon","Duv","Ghouz","Aola"};
        string[] HumanName = new string[] {"Roi Fusecaller","Humioz Raltrahr","Wuiy Zian","Fie Pung","Cai Lu","Yerve Mivrobi","Hulu Vihpat","Leh Churnav"};
        string[] HumanNickName = new string[] {"Davis","Bruce","Victorianus","Chaunte","Elfie","Minne","Walda","Valdemar"};
        string[] ElfNickName = new string[] {"Soft Foot","Sleepless","Tree Hugger","Mist Chaser","Moon Dancer","The Crimson Bone","Clamaconda","The Elusive"};
        string[] OrcNickName = new string[] {"The Broad","The Ruthless","The Prime","Flame Skinner","The Cold","Knee Quelcher","Gnoll Piercer","The Repulsive"};

        var ElfList = ElfName.ToList();
        var OrcList = OrcName.ToList();
        var HumanList = HumanName.ToList();
        var ElfNickList = ElfNickName.ToList();
        var OrcNickList = OrcNickName.ToList();
        var HumanNickList = HumanNickName.ToList();

        int index;

        foreach (var personaje in personajes)
        {
             if (personaje.Rasgos.Raza == razas.Elfo)
             {
                index = new Random().Next(0,ElfList.Count());
                personaje.Rasgos.Nombre= ElfList[index];
                ElfList.Remove(ElfList[index]);
                index = new Random().Next(0,ElfNickList.Count());
                personaje.Rasgos.Apodo = ElfNickList[index];
                ElfNickList.Remove(ElfNickList[index]);

             }
             if (personaje.Rasgos.Raza == razas.Orco)
             {
                index = new Random().Next(0,OrcList.Count());
                personaje.Rasgos.Nombre= OrcList[index];
                OrcList.Remove(OrcList[index]);
                index = new Random().Next(0,OrcNickList.Count());
                personaje.Rasgos.Apodo = OrcNickList[index];
                OrcNickList.Remove(OrcNickList[index]);
             }
             if (personaje.Rasgos.Raza == razas.Humano)
             {
                index = new Random().Next(0,ElfList.Count());
                personaje.Rasgos.Nombre= HumanList[index];
                HumanList.Remove(HumanList[index]);
                index = new Random().Next(0,HumanNickList.Count());
                personaje.Rasgos.Apodo = HumanNickList[index];
                ElfNickList.Remove(HumanNickList[index]);
             }
        }

    }
}