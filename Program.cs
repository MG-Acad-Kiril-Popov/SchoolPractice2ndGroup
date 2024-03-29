﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp12
{
    public class PersonEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }

        public PersonEntity(string firstName, string lastName, DateTime birthDate, string address)
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

    public class TeacherEntity : PersonEntity
    {
        public int StudentId { get; set; }
        public string Major { get; set; }
        public double GPA { get; set; }
        public int YearsOfExperience { get; set; }
        public string Department { get; set; }
        public int AttendanceCount { get; private set; }

        public TeacherEntity(string firstName, string lastName, DateTime birthDate, string address, int studentId, string major, double gpa, int yearsOfExperience, string department)
            : base(firstName, lastName, birthDate, address)
        {
            StudentId = studentId;
            Major = major;
            GPA = gpa;
            YearsOfExperience = yearsOfExperience;
            Department = department;
        }

        public override void DisplayPersonInfo()
        {
            base.DisplayPersonInfo();
            Console.WriteLine($"ID: {StudentId}");
            Console.WriteLine($"Major: {Major}");
            Console.WriteLine($"GPA: {GPA:F2}");
            Console.WriteLine($"Years of Experience: {YearsOfExperience}");
            Console.WriteLine($"Department: {Department}");
        }

        public void StudyHard()
        {
            Console.WriteLine($"Student {FirstName} is studying hard for exams.");
        }

        public void AttendClass()
        {
            Console.WriteLine($"Student {FirstName} is attending a class in {Major}.");
            AttendanceCount++;
        }

        public void TeachLesson()
        {
            Console.WriteLine($"Teacher {FirstName} is conducting a class on {Major} in the {Department} department.");
            AttendanceCount++;
        }

        public void ConductMeeting()
        {
            Console.WriteLine($"Teacher {FirstName} is conducting a departmental meeting.");
            AttendanceCount++;
        }

        public void PlaySports()
        {
            Console.WriteLine($"Student {FirstName} is playing sports in their free time.");
        }

        public void WriteResearchPapers()
        {
            Console.WriteLine($"Teacher {FirstName} is actively involved in writing research papers.");
        }
    }

    public class AttendanceStatistics
    {
        private List<TeacherEntity> studentsAndTeachers;

        public AttendanceStatistics()
        {
            studentsAndTeachers = new List<TeacherEntity>();
        }

        public void RecordAttendance(TeacherEntity studentOrTeacher)
        {
            studentsAndTeachers.Add(studentOrTeacher);
        }

        public void DisplayAttendanceStatistics()
        {
            Console.WriteLine("Attendance Statistics:");
            Console.WriteLine($"Total Students and Teachers: {studentsAndTeachers.Count}");
        }

        public void RankByGPAOrExperience()
        {
            Console.WriteLine("\nRanking Students and Teachers by GPA or Experience:");
            var rankedEntities = studentsAndTeachers.OrderByDescending(entity => entity.GPA).ThenByDescending(entity => entity.YearsOfExperience);
            int rank = 1;
            foreach (var entity in rankedEntities)
            {
                Console.WriteLine($"{rank}. {entity.FirstName} {entity.LastName} - GPA: {entity.GPA:F2}, Experience: {entity.YearsOfExperience} years");
                rank++;
            }
        }
    }

    class EducationalProgram
    {
        static void Main()
        {
            TeacherEntity studentAndTeacher1 = new TeacherEntity("John", "Doe", new DateTime(1995, 5, 15), "123 Main St", 12345, "Computer Science", 3.75, 2, "Science");
            TeacherEntity studentAndTeacher2 = new TeacherEntity("Alice", "Johnson", new DateTime(1998, 10, 8), "456 Elm St", 54321, "Mathematics", 3.90, 5, "Mathematics");
            AttendanceStatistics statistics = new AttendanceStatistics();

            studentAndTeacher1.AttendClass();
            studentAndTeacher2.AttendClass();
            studentAndTeacher1.TeachLesson();
            studentAndTeacher2.ConductMeeting();

            statistics.RecordAttendance(studentAndTeacher1);
            statistics.RecordAttendance(studentAndTeacher2);

            statistics.DisplayAttendanceStatistics();
            statistics.RankByGPAOrExperience();
        }
    }
}
