using System;
using Lab3OOP.Domain;
using Lab3OOP.MenuEngine;

namespace Lab3OOP.Executables
{
    class AddWorkLogEntryExecutable : IExecutable
    {
        private WorkLogEntriesRepository _workLogEntriesRepository;

        public AddWorkLogEntryExecutable(WorkLogEntriesRepository repository)
        {
            _workLogEntriesRepository = repository;
        }

        public void Execute()
        {
            var dateTime = DateTime.Now;
            const string description = "Работа над изделием прошла нормально";
            const string responsible = "Иванов Петр Сергеевич";
            Console.WriteLine("Введите время, затраченное на изготовление изделия (в формате час:минута:секунда)");
            var timeSpent = TimeSpan.Parse(Console.ReadLine());

            var workLogEntry = new WorkLogEntry(dateTime, description, responsible, timeSpent);
            _workLogEntriesRepository.AddWorkLogEntry(workLogEntry);
        }
    }
}
