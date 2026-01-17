/*Generate Binary Numbers Using a Queue
Generate the first N binary numbers using a queue.
Example:
Input: N=5
Output: {"1", "10", "11", "100", "101"}*/
using System;
using System.Collections.Generic;
public class BinaryQueue
{
    public static List<string> BinaryGenerator(int n )
    {
        Queue<string> queue = new Queue<String>();
        List<string> result = new List<string>();
        queue.Enqueue("1");
        for(int i = 0; i < n; i++)
        {
            string current = queue.Dequeue();
            result.Add(current);
            queue.Enqueue(current+"0");
            queue.Enqueue(current+"1");
        }
            return result;
    }
}