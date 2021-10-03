
namespace Course3
{
    public abstract class Instrument
    {
        public bool IsAvailable { get; set; }
        
        public string Person { get; set; }

        public abstract string Type { get; }

        public Instrument(bool isAvailable, string person)
        {
            IsAvailable = isAvailable;
            Person = person;
        }
        public abstract string GetAdditionalInfo();
    }
}