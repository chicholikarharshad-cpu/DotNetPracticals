namespace practicalsAsProject.Models;
using System;
using System.ComponentModel.DataAnnotations;

public class TimeTable
{
    public int TimeTableId { get; set; }
    public int CourseId { get; set; }
    public Course Course { get; set; }
    public int Semester { get; set; }
    public int SubjectId { get; set; }
    public Subject Subject { get; set; }
    public int FacultyId { get; set; }
    public Faculty Faculty { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public string RoomNumber { get; set; }
    public int DayOfWeek { get; set; }
}
