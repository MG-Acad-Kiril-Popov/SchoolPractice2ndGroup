class EducationalProgram
{
    static void Main()
    {
        StudentAndTeacherEntity studentAndTeacher1 = new StudentAndTeacherEntity("John", "Doe", new DateTime(1995, 5, 15), "123 Main St", 12345, "Computer Science", 3.75, 2, "Science");
        StudentAndTeacherEntity studentAndTeacher2 = new StudentAndTeacherEntity("Alice", "Johnson", new DateTime(1998, 10, 8), "456 Elm St", 54321, "Mathematics", 3.90, 5, "Mathematics");
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

