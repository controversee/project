using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    internal class TodoItem
    {
        public int No => _no;
        public Status Status=Status.ToDo;
        public string Title;
        public string Description;
        private DateTime _deadLine;
        public DateTime StausChangedAt;
        private static int _counter;
        private int _no;
        public TodoItem()
        {
            _counter++;
            _no = _counter;

        }
        public DateTime Deadline
        {
            get => _deadLine;
            set
            {
                if (value > DateTime.Now)
                    _deadLine = value;

            }

        }

    }
}
