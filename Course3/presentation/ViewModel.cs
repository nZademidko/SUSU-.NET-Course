using System;
using System.Collections.Generic;
using System.IO;
using AbstractVirtualMachine.Logging;
using Course3.data.Logger;
using Course3.presentation.keyboard;
using Course3.presentation.percussion;
using Course3.presentation.strings;
using Newtonsoft.Json;

namespace Course3.presentation
{
    public class ViewModel : observer.IObservable<MusicGroup<Instrument>>
    {
        private observer.IObserver<MusicGroup<Instrument>> observer;
        private List<MusicGroup<Instrument>> musicGroups;
        private Logger _logger = new Logger();

        public ViewModel(string dataUrl)
        {
            _logger.Notify += FileLogger.LogToFile;
            _logger.Notify += ConsoleLogger.LogToConsole;
            _logger.LogInfo("Start Program");
            _logger.LogInfo("ViewModel Initialized");
            musicGroups = new List<MusicGroup<Instrument>>();
            InitDb(dataUrl);
        }


        private void InitDb(string dataUrl)
        {
            _logger.LogInfo("Initialize DataBase...");
            Root groupJsonModel = File.Exists(dataUrl)
                ? JsonConvert.DeserializeObject<Root>(File.ReadAllText(dataUrl))
                : new Root();
            _logger.LogInfo(" DataBase initialized");

            JsonToList(groupJsonModel);
        }

        private void JsonToList(Root root)
        {
            _logger.LogInfo("Parsing Json to List...");
            foreach (var group in root.groups)
            {
                List<Instrument> _listInstruments = new List<Instrument>();
                foreach (var instrument in group.instruments)
                {
                    if (instrument.type.Equals("Guitar"))
                    {
                        _listInstruments.Add(new Guitar(instrument.isAvailable, instrument.person));
                    }
                    else if (instrument.type.Equals("BassGuitar"))
                    {
                        _listInstruments.Add(new BassGuitar(instrument.isAvailable, instrument.person));
                    }
                    else if (instrument.type.Equals("Drum"))
                    {
                        _listInstruments.Add(new Drum(instrument.isAvailable, instrument.person));
                    }
                    else if (instrument.type.Equals("Congas"))
                    {
                        _listInstruments.Add(new Congas(instrument.isAvailable, instrument.person));
                    }
                    else if (instrument.type.Equals("Organ"))
                    {
                        _listInstruments.Add(new Organ(instrument.isAvailable, instrument.person));
                    }
                    else if (instrument.type.Equals("Piano"))
                    {
                        _listInstruments.Add(new Piano(instrument.isAvailable, instrument.person));
                    }
                }

                musicGroups.Add(new MusicGroup<Instrument>(group.name, _listInstruments));
            }
            _logger.LogInfo("Json to List was parsed.");
        }

        public void RegisterObserver(observer.IObserver<MusicGroup<Instrument>> e)
        {
            _logger.LogInfo("Register Observer.");
            observer = e;
        }

        public void UnregisterObserver()
        {
            _logger.LogInfo("Unregister Observer.");
            observer = null;
        }

        public void Task1Clicked()
        {
            observer.PrintGroups(musicGroups);
        }

        public void Task2Clicked(string name)
        {
            getMusicGroupOrNull(name);
        }

        public void  Task3Clicked()
        {
            getAllInstruments();
        }
        public void  Task4Clicked()
        {
            getSortedListOfInstruments();
        }

        private void getSortedListOfInstruments()
        {
            List<Instrument> list = new List<Instrument>();
            foreach (var group in musicGroups)
            {
                foreach (var instrument in group.Instruments)
                {
                    list.Add(instrument);
                }
            }    
        }
        private void getAllInstruments()
        {
            List<Instrument> list = new List<Instrument>();
            foreach (var group in musicGroups)
            {
                foreach (var instrument in group.Instruments)
                {
                    list.Add(instrument);
                }
            }
            observer.PrintInstruments(list);
        }

        private void getMusicGroupOrNull(string name)
        {
            foreach (var group in musicGroups)
            {
                foreach (var instrument in group.Instruments)
                {
                    if (instrument.Person.ToLower().Contains(name.ToLower()))
                    {
                        observer.PrintPerson(instrument.Person, group.Name, instrument.Type);
                        return;
                    }
                }
            }

            observer.PrintPerson(null, null, null);
        }
    }
}