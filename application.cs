class EducationalProgram
{
    static void Main()
    {
        TeacherEntity teacher = new StudentEntity("John", "Doe", new DateTime(1995, 5, 15), "123 Main St", 12345, "Computer Science", 3.75, 2, "Science");
        StudentEntity student = new StudentEntity("Alice", "Johnson", new DateTime(1998, 10, 8), "456 Elm St", 54321, "Mathematics", 3.90, 5, "Mathematics");
        AttendanceStatistics statistics = new AttendanceStatistics();
     

        student.AttendClass();
        teacher.AttendClass();
        student.AttendClass();
        teacher.TeachLesson();
        student.ConductMeeting();

        statistics.RecordAttendance(student);
        statistics.RecordAttendance(teacher);

        statistics.DisplayAttendanceStatistics();
        statistics.RankByGPAOrExperience();
    }
}


