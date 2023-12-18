using System;
using System.Collections.Generic;
using System.Linq;

public class AttendanceStatistics
{
    private List<StudentEntity> students;

    public AttendanceStatistics()
    {
        students = new List<StudentEntity>();
    }

    public void RecordAttendance(StudentEntity student)
    {
        students.Add(student);
    }

    public void DisplayAttendanceStatistics()
    {
        Console.WriteLine("Attendance Statistics:");
        Console.WriteLine($"Total Students: {students.Count}");
    }

    public void RankByGPA()
    {
        Console.WriteLine("\nRanking Students by GPA:");
        var rankedEntities = students.OrderByDescending(entity => entity.GPA);
        int rank = 1;
        foreach (var entity in rankedEntities)
        {
            Console.WriteLine($"{rank}. {entity.FirstName} {entity.LastName} - GPA: {entity.GPA:F2}");
            rank++;
        }
    }

    private List<TeacherEntity> teachers;

    public AttendanceStatistics()
    {
        teachers = new List<TeacherEntity>();
    }

    public void RecordAttendance(TeacherEntity teacher)
    {
        teachers.Add(teacher);
    }

    public void DisplayAttendanceStatistics()
    {
        Console.WriteLine("Attendance Statistics:");
        Console.WriteLine($"Total Teachers: {teachers.Count}");
    }

    public void RankByExperience()
    {
        Console.WriteLine("\nRanking Teachers by Experience:");
        var rankedEntities = teachers.OrderByDescending(entity => entity.YearsOfExperience);
        int rank = 1;
        foreach (var entity in rankedEntities)
        {
            Console.WriteLine($"{rank}. {entity.FirstName} {entity.LastName} - GPA: {entity.GPA:F2}, Experience: {entity.YearsOfExperience} years");
            rank++;
        }
    }
}
