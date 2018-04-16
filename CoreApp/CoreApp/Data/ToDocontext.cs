using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.Data
{
    public class ToDocontext:DbContext
    {
        public ToDocontext(DbContextOptions<ToDocontext> options):base(options)
        {

        }

        public DbSet<Todo> ToDos{ get; set; }



    }
}
