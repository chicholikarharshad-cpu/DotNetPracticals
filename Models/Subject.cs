namespace practicalsAsProject.Models;

using System;
using System.ComponentModel.DataAnnotations;

public class Subject
{
    public int SubjectId { get; set; }

    [Required(ErrorMessage = "Subject name is required.")]
    public string SubjectName { get; set; }

    [Required(ErrorMessage = "Subject code is required.")]
    public int SubjectCode { get; set; }

    [Required(ErrorMessage = "Course is required.")]
    public int CourseId { get; set; }

    public Course Course { get; set; }

    [Required(ErrorMessage = "Semester is required.")]
    public int Semester { get; set; }

    public bool IsPractical { get; set; }
}