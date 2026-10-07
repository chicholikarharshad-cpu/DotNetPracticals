namespace practicalsAsProject.Models;

using System;
using System.ComponentModel.DataAnnotations;

public class Result
{
    public int ResultId { get; set; }

    [Required(ErrorMessage = "Student is required.")]
    public int StudentId { get; set; }

    public Student? Student { get; set; }

    [Required(ErrorMessage = "Subject is required.")]
    public int SubjectId { get; set; }

    public Subject? Subject { get; set; }

    [Required(ErrorMessage = "Credit is required.")]
    public float Credit { get; set; }

    [Required(ErrorMessage = "Theory mark is required.")]
    public int TheoryMark { get; set; }

    [Required(ErrorMessage = "Practical mark is required.")]
    public int PracticalMark { get; set; }

    [Required(ErrorMessage = "Total mark is required.")]
    public int TotalMark { get; set; }

    [Required(ErrorMessage = "Grade is required.")]
    public string Grade { get; set; }

    public string PercentageRange { get; set; }

    public string Description { get; set; }

    [Required(ErrorMessage = "CGPA is required.")]
    public float CGPA { get; set; }

    public DateTime CreateAt { get; set; } = DateTime.Now;
}