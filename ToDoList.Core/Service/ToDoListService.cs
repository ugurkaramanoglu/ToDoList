using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ToDoList.Data.Model;
using ToDoList.Data.Repository.Concrete;
using ToDoList.Data.ToDoListContext;

namespace ToDoList.Core.Service
{
    public class ToDoListService
    {
        ToDoListRepository toDoListRepository = new ToDoListRepository(new DatabaseContext());
      

        public ToDoEntity AddToDoList(ToDoEntity toDoEntity)
        {
            toDoEntity.CreatedDate = DateTime.Now;
            toDoListRepository.AddToDoList(toDoEntity);      

            return toDoEntity;
        }
        public void DeleteToDoList(int Id)
        {
            ToDoEntity toDoEntity = toDoListRepository.GetToDo(Id);
            toDoListRepository.DeleteToDoList(toDoEntity);            
        }

        public ToDoEntity UpdateToDoList(ToDoEntity toDoEntity)
        {
            ToDoEntity toDoEntityId = toDoListRepository.GetToDo(toDoEntity.Id);
            toDoEntity.UpdatedDate= DateTime.Now;
            toDoEntityId.UpdatedDate = toDoEntity.UpdatedDate;
            toDoEntityId.Description = toDoEntity.Description;
            toDoListRepository.UpdateToDoList(toDoEntityId);
            return toDoEntity;
        }

        public List<ToDoEntity> GetAllToDoList()
        {
            List<ToDoEntity> toDoList = toDoListRepository.GetToDoList().ToList();   
            foreach ( var todo in toDoList)
            {
                todo.CreatedShortDate = todo.CreatedDate.ToString();
                todo.UpdatedShortDate = todo.UpdatedDate.ToString();
            }

            return toDoList;
        }

  
    }
}
