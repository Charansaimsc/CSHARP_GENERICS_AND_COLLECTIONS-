/*Symmetric Difference
Find the symmetric difference (elements present in either set but not both).
Example:
Input: {1, 2, 3}, {3, 4, 5}
Output: {1, 2, 4, 5}*/
using System;
using System.Collections.Generic;
class SymmetricDifference
{
    public static HashSet<int> Find(HashSet<int> set1,HashSet<int> set2)
    {
        HashSet<int> Symmetric = new HashSet<int>();
        foreach(var item in set1)
        {
            Symmetric.Add(item);
        }
        foreach(var item in set2)
        {
            if (Symmetric.Contains(item))
            {
                Symmetric.Remove(item);
            }else{
                Symmetric.Add(item);
            }
            
        }
        return Symmetric;
    }
}