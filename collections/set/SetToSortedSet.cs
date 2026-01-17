/*Convert a Set to a Sorted List
Convert a HashSet<int> into a sorted list in ascending order.
Example:
Input: {5, 3, 9, 1}
Output: [1, 3, 5, 9]*/
using System;
using System.Collections.Generic;
class SetToSortedSet
{
    public static List<int> Solve()
    {
        HashSet<int> sett = new HashSet<int >{2,6,4,6,22,1,0,9};
        List<int> listtt = new List<int>(sett);
        listtt.Sort();
        return listtt;
    }
}