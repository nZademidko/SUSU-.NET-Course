using Course3.interfaces.strings;

namespace Course3.presentation.strings
{
    public class Guitar: Strings, IGuitar
    {
        protected override int StringCount => 4;
        public override string GetAdditionalInfo()
        {
            return $"Кол-во струн: {StringCount}";
        }

        public Guitar(bool isAvailable, string person) : base(isAvailable, person)
        {
        }
    }
}