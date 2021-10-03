// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 

using System.Collections.Generic;

public class Instrument
{
    public string type { get; set; }
    public bool isAvailable { get; set; }
    public string person { get; set; }
}

public class Group
{
    public string name { get; set; }
    public List<Instrument> instruments { get; set; }
}

public class Root
{
    public List<Group> groups { get; set; }
}