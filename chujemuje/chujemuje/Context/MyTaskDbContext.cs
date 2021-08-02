using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace dzikieweze
{
    public class MyTaskDbContext : DbContext
    {
        public MyTaskDbContext(DbContextOptions<MyTaskDbContext>options):base(options)
        {
            this.Database.EnsureCreated();
        }

        public DbSet<MyTask> ToDoList { get; set; }

    }
}
