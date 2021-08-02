using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace dzikieweze
{
    public class BasicToDoList :IToDoList
    {
        private readonly MyTaskDbContext _context;

        public  BasicToDoList(MyTaskDbContext context)
        {
            _context = context;
        }

        public void AddSpecified(MyTask obj)
        {
            if (obj != null)
            {
                _context.Add(obj);
                _context.SaveChanges();
            }
        }

        public IEnumerable<MyTask> GetAll()
        {
            return _context.ToDoList.ToList();
        }

        public MyTask GetSpecified(Guid id)
        {
            return _context.ToDoList.FirstOrDefault(x => x.Id == id);
        }
        public void UpdateSpecified(MyTask task)
        {
            _context.ToDoList.Update(task);
            _context.SaveChanges();
        }
       
        public void DeleteSpecified(Guid id)
        {
            _context.Remove(_context.ToDoList.Single(x => x.Id == id));
            _context.SaveChanges();
        }

        public void DeleteAll()
        {
            throw new NotImplementedException();
        }
    }
}
