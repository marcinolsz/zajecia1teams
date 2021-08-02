using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dzikieweze
{
    public class MyTask
    {
        public MyTask()
        {
            Date = DateTime.Now;
            Id = Guid.NewGuid();
        }
        public Guid Id { get; init; }
        public string Name { get; set; }

        public DateTime Date { get; init; }
    }
}
