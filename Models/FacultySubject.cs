namespace practicalsAsProject.Models;
using System;
using System.ComponentModel.DataAnnotations;

public class FacultySubject
{
    public int FacultySubjectId { get; set; }
    public int FacultyId { get; set; }
    public Faculty Faculty { get; set; }
    public int SubjectId { get; set; }
    public Subject Subject { get; set; }
}
