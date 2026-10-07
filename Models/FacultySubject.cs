namespace practicalsAsProject.Models;

using System;
using System.ComponentModel.DataAnnotations;

public class FacultySubject
{
    public int FacultySubjectId { get; set; }

    [Required(ErrorMessage = "Faculty is required.")]
    public int FacultyId { get; set; }

    public Faculty Faculty { get; set; }

    [Required(ErrorMessage = "Subject is required.")]
    public int SubjectId { get; set; }

    public Subject Subject { get; set; }
}