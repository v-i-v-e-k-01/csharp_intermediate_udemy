using System;
using System.Collections;

namespace Exercise
{

    public class Stack
    {
        private ArrayList _stack;

        public Stack()
        {
            _stack = new ArrayList();
        }

        public void Push(object obj)
        {
            try
            {
                var _obj = obj as object;
                if (_obj == null)
                {
                    throw new InvalidOperationException();
                }
                else
                {
                    _stack.Add(obj);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public object Pop()
        {
            while (true)
            {
                try
                {
                    if (_stack.Count < 1)
                    {
                        throw new InvalidOperationException();
                    }
                    else
                    {
                        var poppedItem = _stack[_stack.Count - 1];
                        _stack.RemoveAt(_stack.Count - 1);

                        return poppedItem;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public void Clear()
        {
            _stack.Clear();
        }
    }
}


