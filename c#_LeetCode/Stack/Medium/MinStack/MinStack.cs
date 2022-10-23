using System.Collections.Generic;

namespace LeetCode.Stack.Medium.MinStack
{
    //https://leetcode.com/problems/min-stack/
    public class StackValue
    {
        public int Value { get; set; }
    }

    public class MinStack
    {
        private Stack<StackValue> _stack = new();
        private Stack<StackValue> _min = new();

        public void Push(int val)
        {
            var value = new StackValue() { Value = val };

            if(_stack.Count == 0)
                _min.Push(value);
            
            if(_min.Peek().Value > val)
                _min.Push(value);

            _stack.Push(value);
        }

        public void Pop()
        {
            var value = _stack.Pop();

            if(value == _min.Peek())
                _min.Pop();
        }

        public int Top()
        {
            return _stack.Peek().Value;
        }

        public int GetMin()
        {
            return _min.Peek().Value;
        }
    }
}
