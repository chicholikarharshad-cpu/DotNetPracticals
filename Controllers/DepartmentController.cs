using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using practicalsAsProject.Models;

namespace practicalsAsProject.Controllers;

public class DepartmentController : Controller
{


    public static dynamic[] departments = new dynamic[]
{
    new {
        DeptId = 1,
        DeptName = "Computer Science & Engineering",
        Code = "CSE",
        HODName = "Dr. Rajesh Sharma",
        HODEmail = "hod.cse@school.edu",
        Faculties = new[] { "Prof. Amit Verma", "Dr. Neha Gupta", "Prof. Suresh Patel", "Dr. Kavita Das" },
        Facilities = new[] { "High-Performance Computing Lab", "AI & Robotics Lab", "IoT Hardware Lab", "Digital Library" }
    },
    new {
        DeptId = 2,
        DeptName = "Management Studies",
        Code = "MGMT",
        HODName = "Dr. Sunita Mehta",
        HODEmail = "hod.mgmt@school.edu",
        Faculties = new[] { "Dr. Vikas Rao", "Prof. Pooja Shah", "Prof. Nitin Saxena" },
        Facilities = new[] { "Corporate Discussion Room", "Business Simulation Lab", "Seminar Hall" }
    },
    new {
        DeptId = 3,
        DeptName = "Information Technology",
        Code = "IT",
        HODName = "Dr. Manish Kapoor",
        HODEmail = "hod.it@school.edu",
        Faculties = new[] { "Prof. Ritu Sen", "Dr. Deepak Varma", "Prof. Anjali Roy" },
        Facilities = new[] { "Cloud Computing Center", "Cyber Security Cell", "Software Engineering Studio" }
    },
    new {
        DeptId = 4,
        DeptName = "Electronics & Communication",
        Code = "ECE",
        HODName = "Dr. Anand Joshi",
        HODEmail = "hod.ece@school.edu",
        Faculties = new[] { "Prof. Sunita Pillai", "Dr. Alok Pandey", "Prof. Vikram Singh" },
        Facilities = new[] { "VLSI Design Lab", "DSP & Embedded Systems Lab", "Communication Engineering Lab" }
    },
    new {
        DeptId = 5,
        DeptName = "Mechanical Engineering",
        Code = "ME",
        HODName = "Dr. Rameshwar Prasad",
        HODEmail = "hod.me@school.edu",
        Faculties = new[] { "Prof. Harish Chandra", "Dr. Subhash Bose", "Prof. Pankaj Tripathi" },
        Facilities = new[] { "CAD/CAM Simulation Center", "CNC Machining Workshop", "Thermodynamics Lab" }
    },
    new {
        DeptId = 6,
        DeptName = "Civil Engineering",
        Code = "CE",
        HODName = "Dr. S. K. Mukherjee",
        HODEmail = "hod.ce@school.edu",
        Faculties = new[] { "Prof. Arvind Trivedi", "Dr. Meena Iyer" },
        Facilities = new[] { "Structural Testing Lab", "Geotechnical Engineering Lab", "Surveying & GIS Lab" }
    },
    new {
        DeptId = 7,
        DeptName = "Electrical Engineering",
        Code = "EE",
        HODName = "Dr. Preeti Deshmukh",
        HODEmail = "hod.ee@school.edu",
        Faculties = new[] { "Prof. Tarun Bajaj", "Dr. Smita Rane", "Prof. Sanjay Duttt" },
        Facilities = new[] { "High Voltage Testing Lab", "Power Systems Studio", "Electrical Machines Workshop" }
    },
    new {
        DeptId = 8,
        DeptName = "Commerce & Finance",
        Code = "COMM",
        HODName = "Dr. Anil Agarwal",
        HODEmail = "hod.comm@school.edu",
        Faculties = new[] { "Prof. Priya Saxena", "Dr. Ramesh Kumar" },
        Facilities = new[] { "FinTech Computer Lab", "Accounting Software Center", "Financial Trading Floor" }
    },
    new {
        DeptId = 9,
        DeptName = "Design & Media Art",
        Code = "DES",
        HODName = "Prof. Vikramaditya Sen",
        HODEmail = "hod.design@school.edu",
        Faculties = new[] { "Prof. Ananya Roy", "Dr. Rohit Shetty", "Prof. Maya Lin" },
        Facilities = new[] { "Apple Mac Studio Lab", "3D Printing & Prototyping Workshop", "Photography Studio" }
    },
    new {
        DeptId = 10,
        DeptName = "Pharmaceutical Sciences",
        Code = "PHARM",
        HODName = "Dr. Meenakshi Sundaram",
        HODEmail = "hod.pharm@school.edu",
        Faculties = new[] { "Dr. Alok Nath", "Prof. Swati Deshmukh", "Dr. K. V. Raman" },
        Facilities = new[] { "Advanced Chemistry Lab", "Drug Formulation & Testing Lab", "Medicinal Botanical Garden" }
    },
    new {
        DeptId = 11,
        DeptName = "Biotechnology",
        Code = "BIOTECH",
        HODName = "Dr. Rashmi Bhatnagar",
        HODEmail = "hod.biotech@school.edu",
        Faculties = new[] { "Dr. Gautam Adhikari", "Prof. Shalini Varma" },
        Facilities = new[] { "Tissue Culture Lab", "Genetic Engineering Lab", "Bioinformatics Suite" }
    },
    new {
        DeptId = 12,
        DeptName = "Humanities & Social Sciences",
        Code = "HSS",
        HODName = "Dr. Christopher D'Souza",
        HODEmail = "hod.hss@school.edu",
        Faculties = new[] { "Dr. Arundhati Roy", "Prof. Robert Langdon", "Dr. Sabina Yasmin" },
        Facilities = new[] { "Language & Communication Lab", "Psychology Testing Room", "Audio-Visual Media Room" }
    },
    new {
        DeptId = 13,
        DeptName = "Physics & Material Science",
        Code = "PHY",
        HODName = "Dr. C. V. Ramanathan",
        HODEmail = "hod.physics@school.edu",
        Faculties = new[] { "Dr. Homi Bhabha", "Prof. Vikram Sarabhai" },
        Facilities = new[] { "Optics & Laser Lab", "Material Characterization Center", "Darkroom Facility" }
    },
    new {
        DeptId = 14,
        DeptName = "Chemical Sciences",
        Code = "CHEM",
        HODName = "Dr. Sarojini Naidu",
        HODEmail = "hod.chem@school.edu",
        Faculties = new[] { "Dr. P. C. Ray", "Prof. Venkatraman Ramakrishnan" },
        Facilities = new[] { "Organic Synthesis Lab", "Spectroscopy Research Center", "Chemical Safety Zone" }
    },
    new {
        DeptId = 15,
        DeptName = "Mathematics & Data Analytics",
        Code = "MATH",
        HODName = "Dr. Srinivasa Ramanujan",
        HODEmail = "hod.math@school.edu",
        Faculties = new[] { "Dr. Shakuntala Devi", "Prof. C. R. Rao", "Dr. Aryabhata Sharma" },
        Facilities = new[] { "Statistical Computing Lab", "Mathematical Modeling Studio", "Big Data Analytics Lab" }
    },
    new {
        DeptId = 16,
        DeptName = "Architecture & Planning",
        Code = "ARCH",
        HODName = "Prof. Charles Correa",
        HODEmail = "hod.arch@school.edu",
        Faculties = new[] { "Prof. Laurie Baker", "Dr. B. V. Doshi" },
        Facilities = new[] { "Drafting Studio", "Scale Model Workshop", "Climatology Testing Lab" }
    },
    new {
        DeptId = 17,
        DeptName = "Law & Legal Studies",
        Code = "LAW",
        HODName = "Dr. B. R. Ambedkar",
        HODEmail = "hod.law@school.edu",
        Faculties = new[] { "Prof. Nani Palkhivala", "Dr. Fali Nariman" },
        Facilities = new[] { "Moot Court Hall", "Legal Aid Clinic", "Law Reference Library" }
    },
    new {
        DeptId = 18,
        DeptName = "Environmental Studies",
        Code = "EVS",
        HODName = "Dr. Medha Patkar",
        HODEmail = "hod.evs@school.edu",
        Faculties = new[] { "Dr. Sunita Narain", "Prof. Sundarlal Bahuguna" },
        Facilities = new[] { "Air & Water Quality Analysis Lab", "GIS Mapping Unit", "Solar Power Research Plant" }
    },
    new {
        DeptId = 19,
        DeptName = "Agriculture & Food Technology",
        Code = "AGRI",
        HODName = "Dr. M. S. Swaminathan",
        HODEmail = "hod.agri@school.edu",
        Faculties = new[] { "Dr. Verghese Kurien", "Prof. Norman Borlaug" },
        Facilities = new[] { "Experimental Polyhouse Farm", "Soil Health Testing Lab", "Food Processing Pilot Unit" }
    },
    new {
        DeptId = 20,
        DeptName = "Physical Education & Sports Science",
        Code = "PED",
        HODName = "Dr. Milkha Singh",
        HODEmail = "hod.ped@school.edu",
        Faculties = new[] { "Prof. Dhyan Chand", "Prof. P. T. Usha" },
        Facilities = new[] { "Biomechanics & Kinesiology Lab", "Indoor Multi-Sports Complex", "Fitness & Physiotherapy Center" }
    }
};


    public IActionResult Departments()
    {
        ViewBag.departments = departments;
        return View();
    }


    public IActionResult Facultys()
    {
        return View();
    }


    public IActionResult HODs()
    {
        return View();
    }


    public IActionResult Facilities()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
