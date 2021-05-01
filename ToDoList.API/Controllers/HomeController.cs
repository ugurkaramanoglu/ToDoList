using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoList.Core.Service;
using ToDoList.Data.Model;

namespace ToDoList.API.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]    
    public class HomeController : Controller
    {

        ToDoListService toDoListService = new ToDoListService();

        [HttpPost]
        public IActionResult AddToDoList(ToDoEntity toDoEntity)
        {
            toDoListService.AddToDoList(toDoEntity);
            return Ok(true);
        }
        public IActionResult DeleteToDoList(ToDoEntity toDoEntity)
        {
            toDoListService.DeleteToDoList(toDoEntity.Id);
            return Ok(true);
        }

        public IActionResult UpdateToDoList (ToDoEntity toDoEntity)
        {
            toDoListService.UpdateToDoList(toDoEntity); 
            return Ok(true);
        }    

        public List<ToDoEntity> GetAllToDoList()
        {
            List<ToDoEntity> toDoEntityList = toDoListService.GetAllToDoList();
            return toDoEntityList;
        }


    }
}
