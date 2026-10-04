using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using practicalsAsProject.Models;

namespace practicalsAsProject.Controllers;

public class CourseController : Controller
{





public static dynamic[] courses = new dynamic[]
{
    new
    {
        Index = 1,
        courseName = "BCA",
        courseFullName = "Bachelor of Computer Applications",
        duration = "3 Years",
        fees = "$3,500/year",
        eligibility = "10+2 (Any Stream)",
        mode = "On-Campus",
        subjects = new[] { "Programming in C", "Data Structures", "DBMS", "Computer Networks", "Operating Systems", "Web Development", "Software Engineering" }
    },

    new
    {
        Index = 2,
        courseName = "MCA",
        courseFullName = "Master of Computer Applications",
        duration = "2 Years",
        fees = "$4,500/year",
        eligibility = "BCA / B.Sc CS",
        mode = "On-Campus",
        subjects = new[] { "Advanced Java", "Advanced DBMS", "Data Structures", "Computer Networks", "Cloud Computing", "Artificial Intelligence", "Software Engineering" }
    },

    new
    {
        Index = 3,
        courseName = "B.Tech CS",
        courseFullName = "Bachelor of Technology in Computer Science",
        duration = "4 Years",
        fees = "$6,000/year",
        eligibility = "10+2 (PCM)",
        mode = "On-Campus",
        subjects = new[] { "Programming", "Data Structures", "Algorithms", "DBMS", "Operating Systems", "Computer Networks", "Artificial Intelligence", "Machine Learning" }
    },

    new
    {
        Index = 4,
        courseName = "M.Tech CS",
        courseFullName = "Master of Technology in Computer Science",
        duration = "2 Years",
        fees = "$5,500/year",
        eligibility = "B.Tech / BE",
        mode = "On-Campus",
        subjects = new[] { "Advanced Algorithms", "Advanced DBMS", "Machine Learning", "Artificial Intelligence", "Distributed Systems", "Cloud Computing", "Research Methodology" }
    },

    new
    {
        Index = 5,
        courseName = "B.Sc CS",
        courseFullName = "Bachelor of Science in Computer Science",
        duration = "3 Years",
        fees = "$3,000/year",
        eligibility = "10+2 (PCM)",
        mode = "On-Campus",
        subjects = new[] { "Programming in C", "Data Structures", "DBMS", "Operating Systems", "Computer Networks", "Web Development", "Mathematics" }
    },

    new
    {
        Index = 6,
        courseName = "M.Sc CS",
        courseFullName = "Master of Science in Computer Science",
        duration = "2 Years",
        fees = "$4,000/year",
        eligibility = "B.Sc CS / BCA",
        mode = "On-Campus",
        subjects = new[] { "Advanced Programming", "Advanced DBMS", "Artificial Intelligence", "Machine Learning", "Cloud Computing", "Data Mining", "Research Methodology" }
    },

    new
    {
        Index = 7,
        courseName = "BBA",
        courseFullName = "Bachelor of Business Administration",
        duration = "3 Years",
        fees = "$3,800/year",
        eligibility = "10+2 (Any Stream)",
        mode = "On-Campus",
        subjects = new[] { "Principles of Management", "Business Economics", "Financial Accounting", "Marketing Management", "Human Resource Management", "Business Law", "Entrepreneurship" }
    },

    new
    {
        Index = 8,
        courseName = "MBA",
        courseFullName = "Master of Business Administration",
        duration = "2 Years",
        fees = "$8,000/year",
        eligibility = "Graduation",
        mode = "On-Campus",
        subjects = new[] { "Business Management", "Marketing Management", "Financial Management", "Human Resource Management", "Operations Management", "Business Analytics", "Strategic Management" }
    },

    new
    {
        Index = 9,
        courseName = "B.Com",
        courseFullName = "Bachelor of Commerce",
        duration = "3 Years",
        fees = "$2,500/year",
        eligibility = "10+2 (Commerce)",
        mode = "On-Campus",
        subjects = new[] { "Financial Accounting", "Business Economics", "Business Law", "Corporate Accounting", "Taxation", "Auditing", "Business Statistics" }
    },

    new
    {
        Index = 10,
        courseName = "M.Com",
        courseFullName = "Master of Commerce",
        duration = "2 Years",
        fees = "$3,200/year",
        eligibility = "B.Com",
        mode = "On-Campus",
        subjects = new[] { "Advanced Accounting", "Corporate Finance", "Taxation", "Auditing", "Financial Management", "Business Research", "Economics" }
    },

    new
    {
        Index = 11,
        courseName = "B.Des",
        courseFullName = "Bachelor of Design",
        duration = "4 Years",
        fees = "$5,000/year",
        eligibility = "10+2 (Any Stream)",
        mode = "Hybrid",
        subjects = new[] { "Design Fundamentals", "Drawing", "Typography", "Graphic Design", "UI/UX Design", "Product Design", "Design Thinking" }
    },

    new
    {
        Index = 12,
        courseName = "M.Des",
        courseFullName = "Master of Design",
        duration = "2 Years",
        fees = "$6,200/year",
        eligibility = "B.Des / B.Arch",
        mode = "On-Campus",
        subjects = new[] { "Advanced Design", "Design Research", "UI/UX Design", "Product Design", "Design Management", "Visual Communication", "Design Innovation" }
    },

    new
    {
        Index = 13,
        courseName = "Data Sci",
        courseFullName = "Data Science Certification",
        duration = "1 Year",
        fees = "$2,000/year",
        eligibility = "Graduation",
        mode = "Online",
        subjects = new[] { "Python", "Statistics", "Data Analysis", "Machine Learning", "Data Visualization", "SQL", "Deep Learning" }
    },

    new
    {
        Index = 14,
        courseName = "Cyber Sec",
        courseFullName = "Cyber Security Certification",
        duration = "6 Months",
        fees = "$1,500/year",
        eligibility = "10+2 or Diploma",
        mode = "Online",
        subjects = new[] { "Network Security", "Ethical Hacking", "Cryptography", "Cyber Forensics", "Web Security", "Malware Analysis", "Security Fundamentals" }
    },

    new
    {
        Index = 15,
        courseName = "AI & ML",
        courseFullName = "Artificial Intelligence and Machine Learning",
        duration = "1 Year",
        fees = "$2,500/year",
        eligibility = "Graduation (STEM)",
        mode = "Online",
        subjects = new[] { "Python", "Mathematics for AI", "Machine Learning", "Deep Learning", "Natural Language Processing", "Computer Vision", "Reinforcement Learning" }
    },

    new
    {
        Index = 16,
        courseName = "Cloud Comp",
        courseFullName = "Cloud Computing Certification",
        duration = "6 Months",
        fees = "$1,200/year",
        eligibility = "Basic IT knowledge",
        mode = "Online",
        subjects = new[] { "Cloud Fundamentals", "AWS", "Microsoft Azure", "Cloud Security", "Docker", "Kubernetes", "Cloud Architecture" }
    },

    new
    {
        Index = 17,
        courseName = "B.Pharm",
        courseFullName = "Bachelor of Pharmacy",
        duration = "4 Years",
        fees = "$4,200/year",
        eligibility = "10+2 (PCB/PCM)",
        mode = "On-Campus",
        subjects = new[] { "Pharmaceutics", "Pharmaceutical Chemistry", "Pharmacology", "Pharmacognosy", "Human Anatomy", "Biochemistry", "Microbiology" }
    },

    new
    {
        Index = 18,
        courseName = "M.Pharm",
        courseFullName = "Master of Pharmacy",
        duration = "2 Years",
        fees = "$5,000/year",
        eligibility = "B.Pharm",
        mode = "On-Campus",
        subjects = new[] { "Advanced Pharmacology", "Pharmaceutical Research", "Drug Development", "Clinical Pharmacy", "Pharmacokinetics", "Toxicology", "Research Methodology" }
    },

    new
    {
        Index = 19,
        courseName = "BA English",
        courseFullName = "Bachelor of Arts in English",
        duration = "3 Years",
        fees = "$2,000/year",
        eligibility = "10+2 (Any Stream)",
        mode = "On-Campus",
        subjects = new[] { "English Literature", "Poetry", "Drama", "English Grammar", "Literary Criticism", "Communication Skills", "Creative Writing" }
    },

    new
    {
        Index = 20,
        courseName = "MA English",
        courseFullName = "Master of Arts in English",
        duration = "2 Years",
        fees = "$2,800/year",
        eligibility = "BA English",
        mode = "On-Campus",
        subjects = new[] 
        { 
            "Advanced Literature", 
            "Literary Theory", 
            "Poetry Studies", 
            "Drama Studies", 
            "Modern Literature", 
            "Postcolonial Literature", 
            "Research Methodology" 
        }
    }
};

    public IActionResult Courses()
    {

        ViewBag.Courses = courses;

        return View();
    }



    public IActionResult CourseDetails(int id)
    {
        var selectedCourse = courses.FirstOrDefault((c => c.Index == id));
        if(selectedCourse == null)
        {
            return NotFound("Something went wrong....");
        }

        ViewBag.course = selectedCourse;
        return View();
    }


    public IActionResult Subjects(String courseName)
    {
        var selectedCourse = courses.FirstOrDefault((c => c.courseName == courseName));
        if(selectedCourse == null)
        {
            return NotFound("Subject not Found....");
        }

        ViewBag.subjects = selectedCourse.subjects;
        return View();
    }


    public IActionResult Timetables(int id)
    {
        return View();
    }

    

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
