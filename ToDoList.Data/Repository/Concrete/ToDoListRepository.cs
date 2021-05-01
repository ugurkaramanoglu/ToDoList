using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDoList.Data.Model;
using ToDoList.Data.Repository.Abstract;
using ToDoList.Data.ToDoListContext;

namespace ToDoList.Data.Repository.Concrete
{
    public class ToDoListRepository : Repository<ToDoEntity>, IToDoListRepository
    {
        public ToDoListRepository(DatabaseContext context) : base(context)
        {
            _context = context;
        }
        private DatabaseContext Context
        {
            get { return _context as DatabaseContext; }
        }
        public void AddToDoList(ToDoEntity toDO)
        {
            _context.ToDoEntities.Add(toDO);
            _context.SaveChanges();
        }

        public void DeleteToDoList(ToDoEntity toDO)
        {
            _context.ToDoEntities.Remove(toDO);
            _context.SaveChanges();
        }
        public void UpdateToDoList(ToDoEntity toDO)
        {
            _context.ToDoEntities.Update(toDO);
            _context.SaveChanges();

        }

        public ToDoEntity GetToDo(int id)
        {
            return _context.ToDoEntities.FirstOrDefault(x => x.Id == id);
        }
        public List<ToDoEntity> GetToDoList()
        {
            return _context.ToDoEntities.ToList();
        }
    }
}
