/*Rotate Elements in a List
Rotate the elements of a list by a given number of positions.
Example:
Input: [10, 20, 30, 40, 50], rotate by 2
Output: [30, 40, 50, 10, 20]*/
using System;
using System.Collections.Generic;

class RotateList
{
    public static List<int> Rotation(List<int> lists, int k)
    {
        return DoRotation(lists, k);
    }

    public static List<int> DoRotation(List<int> list, int k)
    {
        List<int> rotatedList = new List<int>();

        // safety for large k
        k = k % list.Count;

        for (int i = k; i < list.Count; i++)
        {
            rotatedList.Add(list[i]);
        }

        for (int i = 0; i < k; i++)
        {
            rotatedList.Add(list[i]);
        }

        return rotatedList;
    }
}
