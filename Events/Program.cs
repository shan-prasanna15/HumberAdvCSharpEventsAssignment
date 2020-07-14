using System;
using System.Collections;
using System.Collections.Generic;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> st1 = new Stack<int>();
            st1.push(3);
            st1.push(7);
            st1.push(8);
            st1.push(3);
            st1.push(9);
            st1.push(346);
            st1.push(4545);
            st1.push(8768);
            st1.push(123);

            st1.PrintStack();




        }
    }

    public delegate void StackEventHandeler(object source, StackEvents e);
    class Stack<T> {
        // Stack mySampStack = new Stack(); //LIFO
        private List<T> _stack = new List<T>();
        //StackEventHandeler stackEv = new StackEventHandeler();
        public T pop (){
            T temp_ = _stack[0];
            _stack.Remove(temp_);
            return temp_;
        }

        public void push(T value) {
            _stack.Add(value);
        }

        public void PrintStack() {
            foreach (T value in _stack) {
                Console.Write(value + " ");
            }
            
        }
    }

    
    public class StackEvents : EventArgs {
        public object eventItem;
        string action;

        public StackEvents(object eventItem, string action)
        {
            this.eventItem = eventItem;
            this.action = action;
        }
    }

    public static class PushOrPopNotification
    {
        public static void PushEvent(object source, StackEvents e)
        {
            Console.WriteLine("Push to stack was made"); ;
        }

        public static void PopEvent(object source, StackEvents e)
        {
            Console.WriteLine("Pop Event occured");
        }
    }

    //public class Client
    //{
    //    public event EventHandeler StackEvents;

    //    public void Alarm()
    //    {

    //    }
    //}
}
