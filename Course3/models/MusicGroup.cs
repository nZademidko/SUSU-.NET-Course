using System.Collections;
using System.Collections.Generic;

namespace Course3
{
    public class MusicGroup<T>: IEnumerable<T>
    {
        public string Name;
        public List<T> Instruments;
        
        public MusicGroup(string name, List<T> instruments)
        {
            Name = name;
            Instruments = instruments;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return Instruments.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}