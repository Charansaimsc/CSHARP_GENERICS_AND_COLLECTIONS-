using System;
using System.Collections.Generic;
namespace Collections_extra{
public class StudentManager
{
    private List<Student> students = new List<Student>();
    private Dictionary<int, List<int>> marks =
        new Dictionary<int, List<int>>();

    // Constructor does EVERYTHING
    public StudentManager()
    {
        LoadData();
        ShowPassedButFailedSubject();
        ShowTopperPerSubject();
        RemoveThreeTimeFailures();
    }

    private void LoadData()
    {
        students.Add(new Student(1, "Sai"));
        students.Add(new Student(2, "charan"));
        students.Add(new Student(3, "Muchakarla"));

        marks.Add(1, new List<int> { 45, 35, 5 });
        marks.Add(2, new List<int> { 60, 70,2 });
        marks.Add(3, new List<int> { 3, 3, 20 });
    }

    // Average 
    private double Average(int rollNo)
    {
        if (!marks.ContainsKey(rollNo)) return 0;

        List<int> m = marks[rollNo];
        if (m.Count == 0) return 0;

        int sum = 0;
        for (int i = 0; i < m.Count; i++)
            sum += m[i];

        return (double)sum / m.Count;
    }

    //  Pass check
    private bool IsPass(int rollNo)
    {
        if (!marks.ContainsKey(rollNo)) return false;

        List<int> m = marks[rollNo];
        if (m.Count == 0) return false;

        for (int i = 0; i < m.Count; i++)
            if (m[i] < 30)
                return false;

        return Average(rollNo) >= 40;
    }

    //  Passed overall but failed a subject
    private void ShowPassedButFailedSubject()
    {
        Console.WriteLine("\nPassed Overall but Failed Subject:");

        for (int i = 0; i < students.Count; i++)
        {
            Student s = students[i];

            if (!marks.ContainsKey(s.RollNo)) continue;

            bool avgPass = Average(s.RollNo) >= 40;
            bool hasFail = false;

            List<int> m = marks[s.RollNo];
            for (int j = 0; j < m.Count; j++)
                if (m[j] < 30)
                    hasFail = true;

            if (avgPass && hasFail)
                Console.WriteLine(s.Name);
        }
    }

    //  Top scorer per subject
    private void ShowTopperPerSubject()
    {
        Console.WriteLine("\nTopper Per Subject:");

        int maxSubjects = 0;
        foreach (var kv in marks)
            if (kv.Value.Count > maxSubjects)
                maxSubjects = kv.Value.Count;

        for (int subject = 0; subject < maxSubjects; subject++)
        {
            int top = -1;
            string topper = "";

            for (int i = 0; i < students.Count; i++)
            {
                Student s = students[i];
                if (!marks.ContainsKey(s.RollNo)) continue;
                if (marks[s.RollNo].Count <= subject) continue;

                int score = marks[s.RollNo][subject];
                if (score > top)
                {
                    top = score;
                    topper = s.Name;
                }
            }

            if (top >= 0)
                Console.WriteLine("Subject " + (subject + 1) +
                                  " : " + topper + " (" + top + ")");
        }
    }

    //  Remove failed 3 consecutive times 
    private void RemoveThreeTimeFailures()
    {
        List<Student> removeList = new List<Student>();

        for (int i = 0; i < students.Count; i++)
        {
            Student s = students[i];

            if (!IsPass(s.RollNo))
                s.ConsecutiveFailures++;
            else
                s.ConsecutiveFailures = 0;

            if (s.ConsecutiveFailures >= 3)
                removeList.Add(s);
        }

        for (int i = 0; i < removeList.Count; i++)
        {
            students.Remove(removeList[i]);
            marks.Remove(removeList[i].RollNo);
            Console.WriteLine(removeList[i].Name + " removed");
        }
    }
}
}
