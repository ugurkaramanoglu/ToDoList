using System;
using System.Collections.Generic;
using System.Text;
using ToDoList.Data.Model;

namespace ToDoList.Data.Repository.Abstract
{
    public interface IToDoListRepository : IRepository<ToDoEntity>
    {
        ToDoEntity GetToDo(int id);       
        void AddToDoList(ToDoEntity toDO);
        void DeleteToDoList(ToDoEntity toDO);
        void UpdateToDoList(ToDoEntity toDO);
        List<ToDoEntity> GetToDoList();

    }
}
