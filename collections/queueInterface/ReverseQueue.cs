/*Queue Interface Problems
1. Reverse a Queue
Reverse the elements of a queue using only queue operations.
Example:
Input: [10, 20, 30]
Output: [30, 20, 10]*/
using System;
using System.Collections.Generic;
class Queues
{
    public static Queue<int> Reversing(Queue<int> queue)
    {
        Stack<int> Reversed = new Stack<int>();
        while (queue.Count > 0)
        {
            Reversed.Push(queue.Dequeue());
        }
        while (Reversed.Count > 0)
        {
            queue.Enqueue(Reversed.Pop());
        }
        return queue;
    }
}
