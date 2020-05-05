using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack<String> strings = new MyStack<string>();
            strings.Push("string");
            strings.Push("2string");
            strings.Push("3string");
            strings.Push("string");
            string a = strings.Pop();
            a = strings.Pop();
            a = strings.Pop();
            a = strings.Pop();
            a = strings.Pop();
        }
    }

    struct Point
    {
        public int x;
        public int y;
        
        public void ToConsole()
        {
            Console.WriteLine($"x : {x}, y : {y}");
        }
    }

    public class MyStack<T>
    {
        private List<T> list;

        public MyStack()
        {
            list = new List<T>();
        }
        public void Push(T item)
        {
            list.Add(item);
        }

        public T Pop()
        {
            if (list.Count == 0)
            {
                throw new IndexOutOfRangeException("Stack empty");
            }
            T result = list.Last();
            list.RemoveAt(list.Count - 1);
            return result;
        }

    }
}
