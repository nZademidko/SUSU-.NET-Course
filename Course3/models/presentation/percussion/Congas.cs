using Course3.interfaces.percussion;

namespace Course3.presentation.percussion
{
    public class Congas: Percussion,ICongas
    {
        protected override int DrumsCount => 2;
        
        public override string GetAdditionalInfo()
        {
            return $"Кол-во барабанов: {DrumsCount}";
        }

        public Congas(bool isAvailable, string person) : base(isAvailable, person)
        {
        }
    }
}