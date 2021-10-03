namespace Course3.presentation.keyboard
{
    public abstract class Keyboard: Instrument
    {
        public override string Type => "Клавишные";
        
        protected abstract int KeyCount { get; }

        protected Keyboard(bool isAvailable, string person) : base(isAvailable, person)
        {
        }
    }
}