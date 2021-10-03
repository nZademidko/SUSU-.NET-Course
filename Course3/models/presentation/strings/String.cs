namespace Course3.presentation.strings
{
    public abstract class Strings: Instrument
    {
        public override string Type => "Струнные";

        protected abstract int StringCount { get; }

        protected Strings(bool isAvailable, string person) : base(isAvailable, person)
        {
        }
    }
}