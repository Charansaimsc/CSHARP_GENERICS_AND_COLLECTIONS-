using System;
using System.Collections.Generic;
class SubsetCheck
{
    public static bool IsSubset(HashSet<int> set1, HashSet<int> set2)
    {
        return set2.IsSupersetOf(set1);
    }
}