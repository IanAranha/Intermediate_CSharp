using System;
using System.Collections.Generic;

namespace StackExercise
{
    public class Stack
    {
        private readonly List<object> _objects;

        public Stack()
        {
            _objects = new List<object>();
        }

        public int StackCounter() => _objects.Count;

        public void Push(Object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("Object cannot be null.");
            else
                _objects.Add(obj);
        }


        public object Pop()
        {
            if (_objects.Count == 0)
                throw new InvalidOperationException("Nothing in stack to delete.");

            var lastElement = _objects.Count - 1;
            _objects.Remove(_objects[lastElement]);
            return lastElement;
        }

        public void Clear()
        {
            _objects.Clear();
        }

    }
}
