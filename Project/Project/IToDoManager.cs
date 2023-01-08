using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    internal interface IToDoManager
    {
        TodoItem[] ToDoItems { get; }
        void AddToDoItem(TodoItem todoitem);
        TodoItem[] GetAllTodoItems();
        TodoItem[] GetAllDelayedTasks();
        void ChangeTodoItemStatus(int no, Status status);
        void EditTodoItem(int no, DateTime? deadline, string title = null, string decription=null);
        TodoItem[] DeleteTodoItem(int no);
        TodoItem[] GetAllTodoItemsByStatus(string status);
        TodoItem[] SearchTodoItems(string title);
        TodoItem[] FilterTodoItems(DateTime fromDate, DateTime ToDate, Status? status);

    }
}
