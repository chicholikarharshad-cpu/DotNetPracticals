namespace practicalsAsProject.Models;
using System;
using System.ComponentModel.DataAnnotations;

public class Result
{
    public int ResultId { get; set; }
    public int StudentId { get; set; }
    public Student Student { get; set; }
    public int SubjectId { get; set; }
    public Subject Subject { get; set; }
    public float credit {get;set;}
    public int TheoryMark { get; set; }
    public int PracticalMark { get; set; }
    public int TotalMark { get; set; }
    public string Grade { get; set; }
    public string PercentageRange { get; set; }       
    public string Description { get; set; }
    public float CGPA { get; set; }
    public DateTime CreateAt { get; set; } = DateTime.Now;
}
