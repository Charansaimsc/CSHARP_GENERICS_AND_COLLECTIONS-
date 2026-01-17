using System;
using System.Collections;
using System.Collections.Generic;
//using collectionss;
class ArrayListss
{
    public static void Sample()
    {
        ArrayList Al = new ArrayList{1,2,3,4,5};
        Reverse(Al);
        Print(Al);
    }
    static void Reverse(ArrayList Al)
    {
        int left =0;
        int right = Al.Count -1;
        while(left < right)
        {
            object temp = Al[left];
            Al[left] = Al[right];
            Al[right] = temp;
            left++;
            right--;
        }
    }
    static void Print(ArrayList Al)
    {
        foreach(var item in Al)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
