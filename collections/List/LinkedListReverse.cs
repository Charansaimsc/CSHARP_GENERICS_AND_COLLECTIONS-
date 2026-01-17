using System;
using System.Collections;
using System.Collections.Generic;
class LinkedLstReverse
{
    public static void Sample()
    {
    LinkedList<int> list =new LinkedList<int>(new int[]{5,5,6,7,8,9,0});
    LinkedList<int> Reversed = Reverse(list);
    Print(Reversed);
    }
    static LinkedList<int> Reverse(LinkedList<int> list)
    {
        LinkedList<int> Reversed = new LinkedList<int>();
        foreach(var item in list)
        {
            Reversed.AddFirst(item);
        }
        return Reversed;
    }
    public static void Print(LinkedList<int> list)
    {
        foreach(int item in list)
        {
            Console.WriteLine(item +"   ");
        }
    }

}