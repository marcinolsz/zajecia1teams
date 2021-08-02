using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dzikieweze
{
    public interface IToDoList
    {
        void AddSpecified(MyTask task);
        IEnumerable<MyTask> GetAll();
        MyTask GetSpecified(Guid id);
        void UpdateSpecified(MyTask task);
        void DeleteSpecified(Guid id);
        void DeleteAll();
    }
}
