/*1. Check if Two Sets Are Equal
Compare two sets and determine if they contain the same elements, regardless
of order.
Example:
Set1: {1, 2, 3}, Set2: {3, 2, 1}
Output: true*/

using System;
using System.Collections.Generic;
class TwoSets
{
    public static bool AreEqual(HashSet<int> set1,HashSet<int> set2)
    {
        foreach(var item in set1)
        {
            if(!set2.Contains(item))
            {
                return false;
            }
        }
        return true;
    }
}