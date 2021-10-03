using Course3.interfaces.percussion;

namespace Course3.presentation.percussion
{
    public class Drum: Percussion, IDrum
    {
        protected override int DrumsCount => 5;
        
        public override string GetAdditionalInfo()
        {
            return $"Кол-во барабанов: {DrumsCount}";
        }

        public Drum(bool isAvailable, string person) : base(isAvailable, person)
        {
        }
    }
}