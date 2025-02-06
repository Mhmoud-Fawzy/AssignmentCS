using System;
class Program
{
    static void Main()
    {
        #region Q1
        //Given a Queue, implement a function to reverse the elements of a queue using a stack
        //Queue<int> queue = new Queue<int>();
        //queue.Enqueue(1);
        //queue.Enqueue(2);
        //queue.Enqueue(3);
        //queue.Enqueue(4);
        //queue.Enqueue(5);


        //static void ReverseQueueByStack(Queue<int> queue)
        //{
        //    Stack<int> stack = new Stack<int>();
        //    while (queue.Count > 0)
        //    {
        //        stack.Push(queue.Dequeue());
        //    }
        //    while (stack.Count > 0)
        //    {
        //        queue.Enqueue(stack.Pop());
        //    }
        //}
        //ReverseQueueByStack(queue);
        //foreach (int item in queue)
        //{
        //    Console.WriteLine(item);
        //} 
        #endregion
        #region Q2
        //Given a Stack, implement a function to check if a string of parentheses is balanced using a stack
        //static bool IsBalanced(string expression)
        //{
        //    Stack<char> stack = new Stack<char>();
        //    foreach (char c in expression)
        //    {
        //        if (c == '(' || c == '{' || c == '[')
        //        {
        //            stack.Push(c);
        //        }
        //        else if (c == ')' || c == '}' || c == ']')
        //        {
        //            if (stack.Count == 0) return false;

        //            char top = stack.Pop();
        //            if ((c == ')' && top != '(') ||
        //                (c == '}' && top != '{') ||
        //                (c == ']' && top != '['))
        //            {
        //                return false;
        //            }
        //        }
        //    }
        //    return stack.Count == 0;
        //}


        //string expression = "({[]})";
        //Console.WriteLine($"Is {expression} balanced? {IsBalanced(expression)}"); 
        #endregion
    }
}