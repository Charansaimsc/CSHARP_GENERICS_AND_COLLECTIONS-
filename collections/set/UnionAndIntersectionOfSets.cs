using System;
using System.Collections.Generic;
using System.Security;
class Setss
{
    public static HashSet<int> Union(HashSet<int> set1,HashSet<int> set2)
    {
        HashSet<int> unionans = new HashSet<int>();
        foreach(var item in set1)
        {
            unionans.Add(item);
        }
        foreach(var item in set2)
        {
           
                unionans.Add(item);
            
        }
        return unionans;
    }
    public static HashSet<int> Intersection(HashSet<int> set1,HashSet<int> set2)
    {
        
        HashSet<int> Intersectans = new HashSet<int>();
            foreach(var item in set1)
        {
            if (set2.Contains(item))
            {
                Intersectans.Add(item);
            }
        }
        return Intersectans;
    }

}