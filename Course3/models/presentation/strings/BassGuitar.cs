using System;
using Course3.interfaces.strings;

namespace Course3.presentation.strings
{
    public class BassGuitar: Strings, IBassGuitar
    {

        
        protected override int StringCount => 4;
        public override string GetAdditionalInfo()
        {
            return $"Кол-во струн: {StringCount}";
        }

        public BassGuitar(bool isAvailable, string person) : base(isAvailable, person)
        {
        }
    }
}