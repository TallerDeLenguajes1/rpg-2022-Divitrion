public class Naming
{
    public static void Selector(List<Personaje> personajes)
    {
        var ElfList = new List<string>() {"Glynran Starmane","Sylsandoral Emberflight","Kearan Willowbreath","Keamaris Siaphostrethra","Ralomaer Yieshixith","Gilsatra Shadowrest","Eilhana Shudri","Faephine Farhold"};
        var OrcList = new List<string>() {"Shun","Drall","Rhak","Shab","Zaon","Duv","Ghouz","Aola"};
        var HumanList = new List<string>() {"Roi Fusecaller","Humioz Raltrahr","Wuiy Zian","Fie Pung","Cai Lu","Yerve Mivrobi","Hulu Vihpat","Leh Churnav"};
        var ElfNickList = new List<string>() {"Soft Foot","Sleepless","Tree Hugger","Mist Chaser","Moon Dancer","The Crimson Bone","Clamaconda","The Elusive"};
        var OrcNickList = new List<string>() {"The Broad","The Ruthless","The Prime","Flame Skinner","The Cold","Knee Quelcher","Gnoll Piercer","The Repulsive"};
        var HumanNickList = new List<string>() {"Davis","Bruce","Victorianus","Chaunte","Elfie","Minne","Walda","Valdemar"};

        int index;

        foreach (var personaje in personajes)
        {
             if (personaje.Rasgos.Raza == razas.Elfo)
             {
                index = new Random().Next(0,ElfList.Count()-1);
                personaje.Rasgos.Nombre= ElfList[index];
                ElfList.Remove(ElfList[index]);
                index = new Random().Next(0,ElfNickList.Count()-1);
                personaje.Rasgos.Apodo = ElfNickList[index];
                ElfNickList.Remove(ElfNickList[index]);

             }
             if (personaje.Rasgos.Raza == razas.Orco)
             {
                index = new Random().Next(0,OrcList.Count()-1);
                personaje.Rasgos.Nombre= OrcList[index];
                OrcList.Remove(OrcList[index]);
                index = new Random().Next(0,OrcNickList.Count()-1);
                personaje.Rasgos.Apodo = OrcNickList[index];
                OrcNickList.Remove(OrcNickList[index]);
             }
             if (personaje.Rasgos.Raza == razas.Humano)
             {
                index = new Random().Next(0,ElfList.Count()-1);
                personaje.Rasgos.Nombre= HumanList[index];
                HumanList.Remove(HumanList[index]);
                index = new Random().Next(0,HumanNickList.Count()-1);
                personaje.Rasgos.Apodo = HumanNickList[index];
                ElfNickList.Remove(HumanNickList[index]);
             }
        }

    }
}