// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Area
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class GameIndex
    {
        public int game_index { get; set; }
        public Generation generation { get; set; }
    }

    public class Generation
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Language
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Name
    {
        public string name { get; set; }
        public Language language { get; set; }
    }

    public class Region
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Location
    {
        public int id { get; set; }
        public string name { get; set; }
        public Region region { get; set; }
        public List<Name> names { get; set; }
        public List<GameIndex> game_indices { get; set; }
        public List<Area> areas { get; set; }
    }

