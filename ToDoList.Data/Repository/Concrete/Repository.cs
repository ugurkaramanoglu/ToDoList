using System;
using System.Collections.Generic;
using System.Text;
using ToDoList.Data.Repository.Abstract;
using ToDoList.Data.ToDoListContext;

namespace ToDoList.Data.Repository.Concrete
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected DatabaseContext _context;

        public Repository(DatabaseContext context)
        {
            _context = context;

        }
    }
}
