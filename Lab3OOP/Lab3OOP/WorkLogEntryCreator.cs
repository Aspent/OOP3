using System;

namespace Lab2
{
    class WorkLogEntryCreator
    {
        public WorkLogEntry Create()
        {
            var dateTime = DateTime.Now;
            const string description = "Работа над изделием прошла нормально";
            const string responsible = "Иванов Петр Сергеевич";
            Console.WriteLine("Введите время, затраченное на изготовление изделия (в формате час:минута:секунда)");
            var buf = Console.ReadLine().Split(':');
            var timeSpent = new TimeSpan(int.Parse(buf[0]), int.Parse(buf[1]), int.Parse(buf[2]));

            return new WorkLogEntry(dateTime, description, responsible, timeSpent);
        }
    }
}
