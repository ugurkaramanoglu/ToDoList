using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ToDoList.Data.Model
{
    public class ToDoEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        [NotMapped]
        public string UpdatedShortDate { get; set; }
        [NotMapped]
        public string CreatedShortDate { get; set; }
    }
}
