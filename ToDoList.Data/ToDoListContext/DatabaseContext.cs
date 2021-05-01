using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ToDoList.Data.Model;

namespace ToDoList.Data.ToDoListContext
{
   public  class DatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost; initial catalog=TodoList; integrated security=true");
        }
    
        public DbSet<ToDoEntity> ToDoEntities { get; set; }
      
    }
   
}
