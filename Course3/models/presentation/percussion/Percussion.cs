using Course3.Interfaces.Percussion;

namespace Course3.presentation.percussion
{
    public abstract class Percussion : Instrument, IPercissuion
    {
        public override string Type => "Барабаны";
        
        protected abstract int DrumsCount { get; }

        protected Percussion(bool isAvailable, string person) : base(isAvailable, person)
        {
        }
    }
}