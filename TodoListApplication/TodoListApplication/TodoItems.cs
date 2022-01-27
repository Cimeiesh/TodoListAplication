using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListApp
{
    public class TodoItems
    {
        public string TodoText { get; set; }
        public bool IsCompleted { get; set; }

        public TodoItems(string TodoText, bool IsCompleted)
        {
            this.TodoText = TodoText;
            this.IsCompleted = IsCompleted;
        }
    }
}
