using System;
using System.Collections.Generic;
using System.Linq;

public class TeacherEntity : PersonEntity
{
	public int YearsOfExperience { get; set; }
	public string Department { get; set; }
	public int AttendanceCount { get; private set; }

	public TeacherEntity(string firstName, string lastName, DateTime birthDate, string address, int yearsOfExperience, string department) : base(firstName, lastName, birthDate, address)
	{
		YearsOfExperience = yearsOfExperience;
		Department = department;
	}

	public override void DisplayPersonInfo()
	{
		base.DisplayPersonInfo();
		
		Console.WriteLine($"Years of Experience: {YearsOfExperience}");
		Console.WriteLine($"Department: {Department}");
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

	public void WriteResearchPapers()
	{
		Console.WriteLine($"Teacher {FirstName} is actively involved in writing research papers.");
	}
}
