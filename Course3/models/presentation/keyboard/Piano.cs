using Course3.Interfaces.Keyboards;

namespace Course3.presentation.keyboard
{
    public class Piano: Keyboard, IPiano
    {
        protected override int KeyCount => 88;

        public override string GetAdditionalInfo()
        {
            return $"Кол-во клавиш: {KeyCount}";
        }

        public Piano(bool isAvailable, string person) : base(isAvailable, person)
        {
        }
    }
}