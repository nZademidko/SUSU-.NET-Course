using System.Collections.Generic;

namespace Course3.presentation.observer
{
    public interface IObserver<T>
    {

        void PrintGroups(List<T> groups);
        void PrintPerson(string name, string group, string type);

        void PrintInstruments(List<Instrument> instruments);
        void ExitProgram();

    }
}