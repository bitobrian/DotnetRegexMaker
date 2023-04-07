namespace RegexMaker.Ssr.Data
{
    public class RegexMakerVM
    {
        public string RegexString { get; set; } = "";
        public string BuildSelected { get; set; } = "Starts With";
        public string CharacterSelected { get; set; } = "Any Character";
        public string OccurrenceSelected { get; set; } = "Once";
        public string TestString { get; set; } = "";
        public string SpecificCharacter { get; set; } = "";
        public SpecificOccurrence SpecificOccurrence { get; set; } = new();
        public string HistoryLog { get; set; } = "";

        public string[] BuildSelection =
        {
            "Starts With", 
            "Contains"
        };
        
        public string[] CharacterTypeSelection =
        {
            "Any Character", 
            "Any Integer",
            "Any Letter", 
            "Any Lower Cased Letter", 
            "Any Upper Cased Letter", 
            "Any Alphanumeric",
            "String",
            "Specify", 
        };
        
        public string[] OccurrenceSelection =
        {
            "Once", 
            "One or More", 
            "Between.."
        };
    
        public bool TestPass { get; set; }

        public string LogMessage { get; set; } = "";
        public bool ShowCharacterInput = false;
        public bool ShowOccurrenceInput = false;
    }

    public class SpecificOccurrence
    {
        public string First { get; set; } = "";
        public string Last { get; set; } = "";
    }
}