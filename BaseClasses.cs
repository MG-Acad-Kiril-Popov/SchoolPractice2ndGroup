using System;
using System.Collections.Generic;
using System.Linq;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public string Address { get; set; }

    public Person(string firstName, string lastName, DateTime birthDate, string address)
    {
        FirstName = firstName;
        LastName = lastName;
        BirthDate = birthDate;
        Address = address;
    }

    public int CalculatePersonAge()
    {
        int age = DateTime.Now.Year - BirthDate.Year;
        if (DateTime.Now < BirthDate.AddYears(age)) age--;
        return age;
    }

    public virtual void DisplayPersonInfo()
    {
        Console.WriteLine($"Name: {FirstName} {LastName}");
        Console.WriteLine($"Birth Date: {BirthDate.ToShortDateString()}");
        Console.WriteLine($"Age: {CalculatePersonAge()} years old");
        Console.WriteLine($"Address: {Address}");
    }
}

class EducationalProgram
{
    static void Main()
    {
        Student student = new Student("John", "Doe", new DateTime(1995, 5, 15), "123 Main St", 12345, "Computer Science", 3.75, 2, "Science");
        Teacher teacher = new Teacher("Alice", "Johnson", new DateTime(1998, 10, 8), "456 Elm St", 54321, "Mathematics", 3.90, 5, "Mathematics");
        AttendanceStatistics statistics = new AttendanceStatistics();

        student.AttendClass();
        student.AttendClass();
        teacher.TeachLesson();
        teacher.ConductMeeting();

        statistics.RecordAttendance(student);
        statistics.RecordAttendance(teacher);

        statistics.DisplayAttendanceStatistics();
        statistics.RankByGPAOrExperience();
    }
}