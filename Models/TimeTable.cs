namespace practicalsAsProject.Models;

using System;
using System.ComponentModel.DataAnnotations;

public class TimeTable
{
    public int TimeTableId { get; set; }

    [Required(ErrorMessage = "Course is required.")]
    public int CourseId { get; set; }

    public Course Course { get; set; }

    [Required(ErrorMessage = "Semester is required.")]
    public int Semester { get; set; }

    [Required(ErrorMessage = "Subject is required.")]
    public int SubjectId { get; set; }

    public Subject Subject { get; set; }

    [Required(ErrorMessage = "Faculty is required.")]
    public int FacultyId { get; set; }

    public Faculty Faculty { get; set; }

    [Required(ErrorMessage = "Start time is required.")]
    [DataType(DataType.Time)]
    public DateTime StartTime { get; set; }

    [Required(ErrorMessage = "End time is required.")]
    [DataType(DataType.Time)]
    public DateTime EndTime { get; set; }

    [Required(ErrorMessage = "Room number is required.")]
    public string RoomNumber { get; set; }

    [Required(ErrorMessage = "Day of week is required.")]
    public int DayOfWeek { get; set; }
}