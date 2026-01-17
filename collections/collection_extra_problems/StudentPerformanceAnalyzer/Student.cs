/*Create a C# program to analyze student performance.
Each student appears for multiple subjects.
Store:
● Student details in a List<Student>
● Marks in a Dictionary<int, List<int>> (RollNo → Marks)

Tasks
1. Calculate average marks for each student.
2. A student passes if:
○ Average ≥ 40
○ No subject mark < 30
3. Display:
○ Students who passed overall but failed in at least one subject
○ Top scorer of each subject
4. Remove students who failed 3 consecutive exams.

Edge Cases
● Student with no marks recorded
● Marks exactly 30 or 40
● Subjects count differs per student

● Removing items while iterating a collection
● Duplicate roll numbers*/
namespace Collections_extra{
public class Student
{
    public int RollNo;
    public string Name;
    public int ConsecutiveFailures;

    public Student(int rollNo, string name)
    {
        RollNo = rollNo;
        Name = name;
        ConsecutiveFailures = 0;
    }
}
}



