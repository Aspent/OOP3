using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3OOP.Domain;
using Lab3OOP.MenuEngine;

namespace Lab3OOP.Executables
{
    class ShowWorkLogExecutable : IExecutable
    {
        private WorkLogEntriesRepository _workLogEntriesRepository;

        public ShowWorkLogExecutable(WorkLogEntriesRepository repository)
        {
            _workLogEntriesRepository = repository;
        }

        public void Execute()
        {
            var workLogs = _workLogEntriesRepository.GetAll();
            for (var i = 1; i <= workLogs.Count; i++) 
            {
                Console.WriteLine("{0} - {1}", i, workLogs[i-1].TimeSpent);
            }
        }
    }
}
