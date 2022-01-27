using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using ToDoListApp;
using System.Windows.Input;
using Xamarin.Forms;

namespace TodoListApplication
{
    public class ToDoListViewModel
    {
        public ObservableCollection<TodoItems> TodoItem { get; set; }
        public string NewToDo { get; set; }

        
        

        public ToDoListViewModel()
        {
            TodoItem = new ObservableCollection<TodoItems>();

            TodoItem.Add(new TodoItems("Shopping The Book", false));
            TodoItem.Add(new TodoItems("Cook Dinner", false));
            TodoItem.Add(new TodoItems("Reading Time", false));
            TodoItem.Add(new TodoItems("Cleaning", false));
            TodoItem.Add(new TodoItems("Walk the Dog", false));
        }

        public ICommand AddTodoCommand => new Command(AddTodoItem);
        void AddTodoItem()
        {
            TodoItem.Add(new TodoItems(NewToDo, false));
        }

        public ICommand RemoveTodoCommand => new Command(RemoveTodoItem);
        void RemoveTodoItem(object o)
        {
            TodoItems todoItemBeingRemoved = o as TodoItems;
            TodoItem.Remove(todoItemBeingRemoved);
        }
    }
}
