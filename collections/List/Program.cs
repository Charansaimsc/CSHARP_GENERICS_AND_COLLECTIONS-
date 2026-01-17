using System;
using System.Collections;

namespace collectionss
{
    class Program
    {
        static void Main(string[] args)
        {
        //    // ArrayListss.Sample();
        //     LinkedLstReverse.Sample();
        //     List<string> list = new List<string>
        //     {
        //         "a","w","o","p","w","p","a"
        //     };
        //     FrequencyFind.PrintFrequency(list);


            // int k =3;
            // List<int> lists = new List<int>{1,2,3,4,5,5,6,8};
            // List<int> result = RotateList.Rotation(lists, k);

            // for (int i = 0; i < result.Count; i++)
            // {
            //      Console.Write(result[i] + " ");
            // }



            // List<int> nums = new List<int>{1,2,33,4,5,44,33,22,22,33,44};
            // foreach(var result in RemoveDuplicates.Removing(nums))
            // {
            //     Console.WriteLine(result);
            // }



            // LinkedList element = new LinkedList();
            // element.Add(1);
            // element.Add(2);
            //  element.Add(3);
            //   element.Add(4);
            //    element.Add(5);
            //     element.Add(6);
            //      element.Add(7);
            //    element.Add(8);
            // element.Add(9);
            
            // Console.WriteLine(element.FindNth(9));




            HashSet<int> set1 = new HashSet<int>{1,2,3,4,5};
            
            HashSet<int> set2 = new HashSet<int>{1,2,3,4,5};
            // bool result = TwoSets.AreEqual(set1,set2);
            // Console.Write(result);

        //    var a = Setss.Union(set1,set2);

        //     Console.Write(String.Join(',',a));




        // var a = SymmetricDifference.Find(set1,set2);
        // Console.Write(String.Join(',',a));


        // var a = SetToSortedSet.Solve();
        // Console.WriteLine(string.Join(',',a));



        Console.WriteLine(SubsetCheck.IsSubset(set1,set2));


        }
    }
}