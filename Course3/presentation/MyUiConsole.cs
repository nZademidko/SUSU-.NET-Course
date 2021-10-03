using System;
using System.Collections.Generic;

namespace Course3.presentation
{
    public class MyUiConsole : observer.IObserver<MusicGroup<Instrument>>
    {
        private ViewModel viewModel;

        public MyUiConsole()
        {
            viewModel = new ViewModel(@"C:\Users\Nikita\RiderProjects\Course3\Course3\data\instruments.json");
            viewModel.RegisterObserver(this);
        }

        public void Start()
        {
            while (true)
            {
                Console.WriteLine("Введите команду:");
                Console.WriteLine("1 - Получить список групп.");
                Console.WriteLine("2 - Узнать определенного музыканта.");
                Console.WriteLine("3 - Получить список всех инструментов.");
                Console.WriteLine("4 - Получить отсортированный список инструментов по имени музканта.");
                Console.WriteLine("10 - Выйти из программы.");
                Console.Write("Команда: ");
                var command = Int32.Parse(Console.ReadLine());
                if (command == 1)
                {
                    viewModel.Task1Clicked();
                }
                else if (command == 2)
                {
                    Console.Write("Введите имя: ");
                    viewModel.Task2Clicked(Console.ReadLine());
                }
                else if (command == 3)
                {
                    viewModel.Task3Clicked();
                }
                else if (command == 4)
                {
                    viewModel.Task4Clicked();
                }

                if (command == 10)
                {
                    ExitProgram();
                    break;
                }
            }
        }

        public void PrintGroups(List<MusicGroup<Instrument>> groups)
        {
            foreach (MusicGroup<Instrument> group in groups)
            {
                Console.WriteLine($"Группа {group.Name}:");
                foreach (Instrument instrument in group.Instruments)
                {
                    Console.WriteLine(
                        $"Тип: {instrument.Type} | Музыкант: {instrument.Person} | Доступен?: {instrument.IsAvailable} | Дополнительная информация: {instrument.GetAdditionalInfo()}");
                }

                Console.WriteLine("________________________________________________________________________");
            }
        }

        public void PrintPerson(string name, string group, string type)
        {
            if (name == null)
            {
                Console.WriteLine("Такой человек не найден.");
            }
            else
            {
                Console.Write($"{name} играет в группе {group} на {type}");
            }
        }

        public void PrintInstruments(List<Instrument> instruments)
        {
            foreach (var instrument in instruments)
            {
                Console.Write(
                    $"Тип: {instrument.Type} | Музкант: {instrument.Person} | Доступен?: {instrument.IsAvailable} | ");
                Console.WriteLine($"Дополнительная информация: {instrument.GetAdditionalInfo()}");
            }
        }

        public void ExitProgram()
        {
            viewModel.UnregisterObserver();
            Console.WriteLine("Выход из программы...");
        }
    }
}