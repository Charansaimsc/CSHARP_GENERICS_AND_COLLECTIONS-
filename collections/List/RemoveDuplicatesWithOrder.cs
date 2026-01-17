using System;
using System.Collections.Generic;
class RemoveDuplicates
{
    public static List<int> Removing(List<int> listss)
    {
        HashSet<int> set = new HashSet<int>();
        List<int> ans = new List<int>();
        for(int i = 0; i < listss.Count; i++)
        {
            if (!set.Contains(listss[i]))
            {
                set.Add(listss[i]);
                ans.Add(listss[i]);
            }
        }
        return ans;
    }
}