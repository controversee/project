using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Project
{
    internal class TodoManager : IToDoManager
    {
        private TodoItem[] _todoItems = new TodoItem[0];

        public TodoItem[] ToDoItems => throw new NotImplementedException();

        public void AddToDoItem(TodoItem todoitem)

        {
            Array.Resize(ref _todoItems, _todoItems.Length + 1);
            _todoItems[_todoItems.Length - 1] = todoitem;

        }


        public void ChangeTodoItemStatus(int no, Status status)
        {
            for (int i = 0; i < _todoItems.Length; i++)
            {
                if (_todoItems[i].No == no)
                {
                    _todoItems[i].Status = status;

                }


            }
        }

        public TodoItem[] DeleteTodoItem(int no)
        {
            int wantedIndex = 0;
            for (int i = 0; i < _todoItems.Length; i++)
            {
                if (_todoItems[i].No == no)
                {
                    wantedIndex = i;
                    break;
                }
            }
            for (int i = wantedIndex; i < _todoItems.Length - 1; i++)
            {
                _todoItems[i] = _todoItems[i + 1];

            }
            Array.Resize(ref _todoItems, _todoItems.Length - 1);
            return _todoItems;

        }

        public void EditTodoItem(int no, DateTime? deadline, string title = null, string description = null)
        {
            for (int i = 0; i < _todoItems.Length; i++)
            {
                if (_todoItems[i].No == no)
                {
                    if (title == null && description == null && deadline != null)
                    {
                        _todoItems[i].Deadline = (DateTime)deadline;

                    }
                    else if (title == null && deadline == null && description != null)
                    {
                        _todoItems[i].Description = description;

                    }
                    else if (description == null && deadline == null && title != null)
                    {
                        _todoItems[i].Title = title;

                    }

                }
            }
        }

        public TodoItem[] FilterTodoItems(DateTime fromDate, DateTime ToDate, Status? status)
        {
            TodoItem[] filteredTodoItems = new TodoItem[0];
            if (status != null)
            {
                for (int i = 0; i < _todoItems.Length; i++)
                {
                    if (_todoItems[i].Deadline <= ToDate && _todoItems[i].Deadline >= fromDate && _todoItems[i].Status == status)
                    {
                        Array.Resize(ref filteredTodoItems, filteredTodoItems.Length + 1);
                        filteredTodoItems[filteredTodoItems.Length - 1] = _todoItems[i];

                    }
                  
                }

            }
            else
            {

                for (int i = 0; i < _todoItems.Length; i++)
                {
                    if (_todoItems[i].Deadline <= ToDate && _todoItems[i].Deadline >= fromDate)
                    {
                        Array.Resize(ref filteredTodoItems, filteredTodoItems.Length + 1);
                        filteredTodoItems[filteredTodoItems.Length - 1] = _todoItems[i];

                    }

                }

            }
            return filteredTodoItems;




        }
        public TodoItem[] GetAllDelayedTasks()
        {
            TodoItem[] DelayedTasks = new TodoItem[0];

            for (int i = 0; i < _todoItems.Length; i++)
            {
                if (_todoItems[i].Deadline < DateTime.Now)
                {
                    Array.Resize(ref DelayedTasks, DelayedTasks.Length + 1);
                    DelayedTasks[DelayedTasks.Length - 1] = DelayedTasks[i];
                }
            }
            return DelayedTasks;
        }

        public TodoItem[] GetAllTodoItems()
        {
            TodoItem[] todoItems = new TodoItem[0];
            for (int i = 0; i < _todoItems.Length; i++)
            {
                Array.Resize(ref todoItems, todoItems.Length + 1);
                todoItems[todoItems.Length - 1] = _todoItems[i];

            }
            return todoItems;
        }

        public TodoItem[] GetAllTodoItemsByStatus(string status)
        {
            TodoItem[] TodoItemsByStatus = new TodoItem[0];

            for (int i = 0; i < _todoItems.Length; i++)
            {
                if (_todoItems[i].Status.ToString() == status)
                {
                    Array.Resize(ref TodoItemsByStatus, TodoItemsByStatus.Length + 1);
                    TodoItemsByStatus[TodoItemsByStatus.Length - 1] = _todoItems[i];
                }
            }
            return TodoItemsByStatus;
        }

        public TodoItem[] SearchTodoItems(string title)
        {
            TodoItem[] SearchTodoItems = new TodoItem[0];

            for (int i = 0; i < _todoItems.Length; i++)
            {
                if (_todoItems[i].Title == title)
                {
                    Array.Resize(ref SearchTodoItems, SearchTodoItems.Length + 1);
                    SearchTodoItems[SearchTodoItems.Length - 1] = _todoItems[i];
                }
            }
            return SearchTodoItems;
        }
    }
}
