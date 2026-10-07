namespace practicalsAsProject.Models;

using System;
using System.ComponentModel.DataAnnotations;

public class Attendance
{
   public int AttendanceId { get; set; }

    public int StudentId { get; set; }
    public Student Student { get; set; }

    public int SubjectId { get; set; }
    public Subject Subject { get; set; }

    public int FacultyId { get; set; }
    public Faculty Faculty { get; set; }

    [Required(ErrorMessage = "Attendance Date required.")]
    [DataType(DataType.Date)]
    public DateTime AttendanceDate { get; set; } = DateTime.Now;

    [Required(ErrorMessage = "Status required.")]
    [StringLength(20)]
    public string Status { get; set; }

    public DateTime CreateAt { get; set; } = DateTime.Now;
}