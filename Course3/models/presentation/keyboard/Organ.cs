using Course3.Interfaces.Keyboards;

namespace Course3.presentation.keyboard
{
    public class Organ: Keyboard, IOrgan
    {
        protected override int KeyCount => 61;
        public override string GetAdditionalInfo()
        {
            return $"Кол-во клавиш: {KeyCount}";
        }

        public Organ(bool isAvailable, string person) : base(isAvailable, person)
        {
        }
    }
}