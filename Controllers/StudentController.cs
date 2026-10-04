using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using practicalsAsProject.Models;

namespace practicalsAsProject.Controllers;

public class StudentController : Controller
{

public static dynamic[] students = new dynamic[]
{
    new {
        Index = 1,
        FullName = "Rahul Sharma",
        DOB = "2005-04-15",
        Gender = "Male",
        BloodGroup = "B+",
        PassportPhoto = "https://randomuser.me/api/portraits/men/32.jpg",
        RollNumber = "BCA001",
        Email = "rahul@gmail.com",
        PhoneNumber = "9876543210",
        PermanentAddress = "Adajan, Surat, Gujarat",
        ParentName = "Rajesh Sharma",
        ParentContactNumber = "9876500011",
        Course = "BCA",
        Semester = 5,
        CollegeName = "ABC College of Computer Applications",
        GPA = 8.2,
        AdmissionNumber = "202407100510001",
        EmergencyName = "Rajesh Sharma",
        EmergencyNumber = "9876500011",
        Hobbies = "Cricket, Music, Coding",
        CollegeIconImage = "https://i.pravatar.cc/100?img=1",
        Class = "BCA - A"
    },

    new {
        Index = 2,
        FullName = "Priya Patel",
        DOB = "2006-02-20",
        Gender = "Female",
        BloodGroup = "O+",
        PassportPhoto = "https://randomuser.me/api/portraits/women/44.jpg",
        RollNumber = "BCA002",
        Email = "priya@gmail.com",
        PhoneNumber = "9876543211",
        PermanentAddress = "Vesu, Surat, Gujarat",
        ParentName = "Mahesh Patel",
        ParentContactNumber = "9876500012",
        Course = "BCA",
        Semester = 5,
        CollegeName = "ABC College of Computer Applications",
        GPA = 8.7,
        AdmissionNumber = "202407100510002",
        EmergencyName = "Mahesh Patel",
        EmergencyNumber = "9876500012",
        Hobbies = "Dancing, Reading, Painting",
        CollegeIconImage = "https://i.pravatar.cc/100?img=1",
        Class = "BCA - A"
    },

    new {
        Index = 3,
        FullName = "Amit Shah",
        DOB = "2004-11-08",
        Gender = "Male",
        BloodGroup = "A+",
        PassportPhoto = "https://randomuser.me/api/portraits/men/45.jpg",
        RollNumber = "MCA001",
        Email = "amit@gmail.com",
        PhoneNumber = "9876543212",
        PermanentAddress = "Athwa, Surat, Gujarat",
        ParentName = "Suresh Shah",
        ParentContactNumber = "9876500013",
        Course = "MCA",
        Semester = 3,
        CollegeName = "ABC College of Computer Applications",
        GPA = 8.9,
        AdmissionNumber = "202407100510003",
        EmergencyName = "Suresh Shah",
        EmergencyNumber = "9876500013",
        Hobbies = "Coding, Gaming, Photography",
        CollegeIconImage = "https://i.pravatar.cc/100?img=1",
        Class = "MCA - A"
    },

    new {
        Index = 4,
        FullName = "Neha Desai",
        DOB = "2005-07-12",
        Gender = "Female",
        BloodGroup = "AB+",
        PassportPhoto = "https://randomuser.me/api/portraits/women/65.jpg",
        RollNumber = "BCA003",
        Email = "neha@gmail.com",
        PhoneNumber = "9876543213",
        PermanentAddress = "Pal, Surat, Gujarat",
        ParentName = "Ramesh Desai",
        ParentContactNumber = "9876500014",
        Course = "BCA",
        Semester = 5,
        CollegeName = "ABC College of Computer Applications",
        GPA = 8.4,
        AdmissionNumber = "202407100510004",
        EmergencyName = "Ramesh Desai",
        EmergencyNumber = "9876500014",
        Hobbies = "Singing, Reading, Yoga",
        CollegeIconImage = "https://i.pravatar.cc/100?img=1",
        Class = "BCA - A"
    },

    new {
        Index = 5,
        FullName = "Karan Mehta",
        DOB = "2004-09-25",
        Gender = "Male",
        BloodGroup = "O-",
        PassportPhoto = "https://randomuser.me/api/portraits/men/52.jpg",
        RollNumber = "BIT001",
        Email = "karan@gmail.com",
        PhoneNumber = "9876543214",
        PermanentAddress = "Varachha, Surat, Gujarat",
        ParentName = "Dinesh Mehta",
        ParentContactNumber = "9876500015",
        Course = "B.Sc IT",
        Semester = 5,
        CollegeName = "ABC College of Computer Applications",
        GPA = 7.9,
        AdmissionNumber = "202407100510005",
        EmergencyName = "Dinesh Mehta",
        EmergencyNumber = "9876500015",
        Hobbies = "Football, Coding, Movies",
        CollegeIconImage = "https://i.pravatar.cc/100?img=1",
        Class = "B.Sc IT - A"
    },

    new {
        Index = 6,
        FullName = "Riya Joshi",
        DOB = "2006-01-18",
        Gender = "Female",
        BloodGroup = "B+",
        PassportPhoto = "https://randomuser.me/api/portraits/women/33.jpg",
        RollNumber = "MCA002",
        Email = "riya@gmail.com",
        PhoneNumber = "9876543215",
        PermanentAddress = "City Light, Surat, Gujarat",
        ParentName = "Anil Joshi",
        ParentContactNumber = "9876500016",
        Course = "MCA",
        Semester = 3,
        CollegeName = "ABC College of Computer Applications",
        GPA = 9.1,
        AdmissionNumber = "202407100510006",
        EmergencyName = "Anil Joshi",
        EmergencyNumber = "9876500016",
        Hobbies = "Writing, Music, Coding",
        CollegeIconImage = "https://i.pravatar.cc/100?img=1",
        Class = "MCA - A"
    },

    new {
        Index = 7,
        FullName = "Vivek Patel",
        DOB = "2005-03-30",
        Gender = "Male",
        BloodGroup = "A+",
        PassportPhoto = "https://randomuser.me/api/portraits/men/67.jpg",
        RollNumber = "BCA004",
        Email = "vivek@gmail.com",
        PhoneNumber = "9876543216",
        PermanentAddress = "Katargam, Surat, Gujarat",
        ParentName = "Bhupendra Patel",
        ParentContactNumber = "9876500017",
        Course = "BCA",
        Semester = 5,
        CollegeName = "ABC College of Computer Applications",
        GPA = 8.0,
        AdmissionNumber = "202407100510007",
        EmergencyName = "Bhupendra Patel",
        EmergencyNumber = "9876500017",
        Hobbies = "Cricket, Travelling, Music",
        CollegeIconImage = "https://i.pravatar.cc/100?img=1",
        Class = "BCA - B"
    },

    new {
        Index = 8,
        FullName = "Anjali Shah",
        DOB = "2005-12-05",
        Gender = "Female",
        BloodGroup = "O+",
        PassportPhoto = "https://randomuser.me/api/portraits/women/12.jpg",
        RollNumber = "BBA001",
        Email = "anjali@gmail.com",
        PhoneNumber = "9876543217",
        PermanentAddress = "Piplod, Surat, Gujarat",
        ParentName = "Jignesh Shah",
        ParentContactNumber = "9876500018",
        Course = "BBA",
        Semester = 5,
        CollegeName = "ABC College of Computer Applications",
        GPA = 8.6,
        AdmissionNumber = "202407100510008",
        EmergencyName = "Jignesh Shah",
        EmergencyNumber = "9876500018",
        Hobbies = "Dance, Fashion, Reading",
        CollegeIconImage = "https://i.pravatar.cc/100?img=1",
        Class = "BBA - A"
    },

    new {
        Index = 9,
        FullName = "Harsh Mehta",
        DOB = "2004-06-17",
        Gender = "Male",
        BloodGroup = "B-",
        PassportPhoto = "https://randomuser.me/api/portraits/men/41.jpg",
        RollNumber = "BCA005",
        Email = "harsh@gmail.com",
        PhoneNumber = "9876543218",
        PermanentAddress = "Dindoli, Surat, Gujarat",
        ParentName = "Nitin Mehta",
        ParentContactNumber = "9876500019",
        Course = "BCA",
        Semester = 5,
        CollegeName = "ABC College of Computer Applications",
        GPA = 7.8,
        AdmissionNumber = "202407100510009",
        EmergencyName = "Nitin Mehta",
        EmergencyNumber = "9876500019",
        Hobbies = "Gaming, Cricket, Technology",
        CollegeIconImage = "https://i.pravatar.cc/100?img=1",
        Class = "BCA - B"
    },

    new {
        Index = 10,
        FullName = "Pooja Patel",
        DOB = "2005-08-22",
        Gender = "Female",
        BloodGroup = "A-",
        PassportPhoto = "https://randomuser.me/api/portraits/women/51.jpg",
        RollNumber = "BIT002",
        Email = "pooja@gmail.com",
        PhoneNumber = "9876543219",
        PermanentAddress = "Nanpura, Surat, Gujarat",
        ParentName = "Ketan Patel",
        ParentContactNumber = "9876500020",
        Course = "B.Sc IT",
        Semester = 5,
        CollegeName = "ABC College of Computer Applications",
        GPA = 8.8,
        AdmissionNumber = "202407100510010",
        EmergencyName = "Ketan Patel",
        EmergencyNumber = "9876500020",
        Hobbies = "Painting, Cooking, Reading",
        CollegeIconImage = "https://i.pravatar.cc/100?img=1",
        Class = "B.Sc IT - A"
    },

    new {
        Index = 11,
        FullName = "Yash Shah",
        DOB = "2005-05-11",
        Gender = "Male",
        BloodGroup = "AB+",
        PassportPhoto = "https://randomuser.me/api/portraits/men/22.jpg",
        RollNumber = "MCA003",
        Email = "yash@gmail.com",
        PhoneNumber = "9876543220",
        PermanentAddress = "Rander, Surat, Gujarat",
        ParentName = "Manoj Shah",
        ParentContactNumber = "9876500021",
        Course = "MCA",
        Semester = 3,
        CollegeName = "ABC College of Computer Applications",
        GPA = 8.3,
        AdmissionNumber = "202407100510011",
        EmergencyName = "Manoj Shah",
        EmergencyNumber = "9876500021",
        Hobbies = "Coding, Chess, Cricket",
        CollegeIconImage = "https://i.pravatar.cc/100?img=1",
        Class = "MCA - B"
    },

    new {
        Index = 12,
        FullName = "Sneha Desai",
        DOB = "2006-03-14",
        Gender = "Female",
        BloodGroup = "O+",
        PassportPhoto = "https://randomuser.me/api/portraits/women/28.jpg",
        RollNumber = "BCA006",
        Email = "sneha@gmail.com",
        PhoneNumber = "9876543221",
        PermanentAddress = "Vesu, Surat, Gujarat",
        ParentName = "Sanjay Desai",
        ParentContactNumber = "9876500022",
        Course = "BCA",
        Semester = 5,
        CollegeName = "ABC College of Computer Applications",
        GPA = 9.0,
        AdmissionNumber = "202407100510012",
        EmergencyName = "Sanjay Desai",
        EmergencyNumber = "9876500022",
        Hobbies = "Singing, Dancing, Travelling",
        CollegeIconImage = "https://i.pravatar.cc/100?img=1",
        Class = "BCA - B"
    },

    new {
        Index = 13,
        FullName = "Dhruv Patel",
        DOB = "2005-10-02",
        Gender = "Male",
        BloodGroup = "A+",
        PassportPhoto = "https://randomuser.me/api/portraits/men/36.jpg",
        RollNumber = "BBA002",
        Email = "dhruv@gmail.com",
        PhoneNumber = "9876543222",
        PermanentAddress = "Udhna, Surat, Gujarat",
        ParentName = "Rakesh Patel",
        ParentContactNumber = "9876500023",
        Course = "BBA",
        Semester = 5,
        CollegeName = "ABC College of Computer Applications",
        GPA = 7.7,
        AdmissionNumber = "202407100510013",
        EmergencyName = "Rakesh Patel",
        EmergencyNumber = "9876500023",
        Hobbies = "Business, Football, Reading",
        CollegeIconImage = "https://i.pravatar.cc/100?img=1",
        Class = "BBA - A"
    },

    new {
        Index = 14,
        FullName = "Kavya Shah",
        DOB = "2005-01-27",
        Gender = "Female",
        BloodGroup = "B+",
        PassportPhoto = "https://randomuser.me/api/portraits/women/49.jpg",
        RollNumber = "BCA007",
        Email = "kavya@gmail.com",
        PhoneNumber = "9876543223",
        PermanentAddress = "Vesu, Surat, Gujarat",
        ParentName = "Paresh Shah",
        ParentContactNumber = "9876500024",
        Course = "BCA",
        Semester = 5,
        CollegeName = "ABC College of Computer Applications",
        GPA = 8.5,
        AdmissionNumber = "202407100510014",
        EmergencyName = "Paresh Shah",
        EmergencyNumber = "9876500024",
        Hobbies = "Photography, Art, Music",
        CollegeIconImage = "https://i.pravatar.cc/100?img=1",
        Class = "BCA - B"
    },

    new {
        Index = 15,
        FullName = "Rohan Mehta",
        DOB = "2004-12-19",
        Gender = "Male",
        BloodGroup = "O+",
        PassportPhoto = "https://randomuser.me/api/portraits/men/75.jpg",
        RollNumber = "MCA004",
        Email = "rohan@gmail.com",
        PhoneNumber = "9876543224",
        PermanentAddress = "Adajan, Surat, Gujarat",
        ParentName = "Mukesh Mehta",
        ParentContactNumber = "9876500025",
        Course = "MCA",
        Semester = 3,
        CollegeName = "ABC College of Computer Applications",
        GPA = 9.2,
        AdmissionNumber = "202407100510015",
        EmergencyName = "Mukesh Mehta",
        EmergencyNumber = "9876500025",
        Hobbies = "Programming, Gaming, Movies",
        CollegeIconImage = "https://i.pravatar.cc/100?img=1",
        Class = "MCA - B"
    },

    new {
        Index = 16,
        FullName = "Isha Patel",
        DOB = "2006-04-09",
        Gender = "Female",
        BloodGroup = "AB-",
        PassportPhoto = "https://randomuser.me/api/portraits/women/55.jpg",
        RollNumber = "BIT003",
        Email = "isha@gmail.com",
        PhoneNumber = "9876543225",
        PermanentAddress = "Pal, Surat, Gujarat",
        ParentName = "Hitesh Patel",
        ParentContactNumber = "9876500026",
        Course = "B.Sc IT",
        Semester = 5,
        CollegeName = "ABC College of Computer Applications",
        GPA = 8.1,
        AdmissionNumber = "202407100510016",
        EmergencyName = "Hitesh Patel",
        EmergencyNumber = "9876500026",
        Hobbies = "Reading, Yoga, Painting",
        CollegeIconImage = "https://i.pravatar.cc/100?img=1",
        Class = "B.Sc IT - B"
    },

    new {
        Index = 17,
        FullName = "Meet Shah",
        DOB = "2005-09-16",
        Gender = "Male",
        BloodGroup = "B+",
        PassportPhoto = "https://randomuser.me/api/portraits/men/29.jpg",
        RollNumber = "BCA008",
        Email = "meet@gmail.com",
        PhoneNumber = "9876543226",
        PermanentAddress = "Athwa, Surat, Gujarat",
        ParentName = "Kishor Shah",
        ParentContactNumber = "9876500027",
        Course = "BCA",
        Semester = 5,
        CollegeName = "ABC College of Computer Applications",
        GPA = 8.7,
        AdmissionNumber = "202407100510017",
        EmergencyName = "Kishor Shah",
        EmergencyNumber = "9876500027",
        Hobbies = "Cricket, Coding, Travelling",
        CollegeIconImage = "https://i.pravatar.cc/100?img=1",
        Class = "BCA - C"
    },

    new {
        Index = 18,
        FullName = "Nidhi Desai",
        DOB = "2005-06-28",
        Gender = "Female",
        BloodGroup = "O-",
        PassportPhoto = "https://randomuser.me/api/portraits/women/68.jpg",
        RollNumber = "BBA003",
        Email = "nidhi@gmail.com",
        PhoneNumber = "9876543227",
        PermanentAddress = "Palanpur, Surat, Gujarat",
        ParentName = "Vijay Desai",
        ParentContactNumber = "9876500028",
        Course = "BBA",
        Semester = 5,
        CollegeName = "ABC College of Computer Applications",
        GPA = 8.9,
        AdmissionNumber = "202407100510018",
        EmergencyName = "Vijay Desai",
        EmergencyNumber = "9876500028",
        Hobbies = "Dancing, Cooking, Travelling",
        CollegeIconImage = "https://i.pravatar.cc/100?img=1",
        Class = "BBA - A"
    },

    new {
        Index = 19,
        FullName = "Akash Patel",
        DOB = "2004-08-13",
        Gender = "Male",
        BloodGroup = "A+",
        PassportPhoto = "https://randomuser.me/api/portraits/men/61.jpg",
        RollNumber = "MCA005",
        Email = "akash@gmail.com",
        PhoneNumber = "9876543228",
        PermanentAddress = "Sachin, Surat, Gujarat",
        ParentName = "Pravin Patel",
        ParentContactNumber = "9876500029",
        Course = "MCA",
        Semester = 3,
        CollegeName = "ABC College of Computer Applications",
        GPA = 8.0,
        AdmissionNumber = "202407100510019",
        EmergencyName = "Pravin Patel",
        EmergencyNumber = "9876500029",
        Hobbies = "Football, Coding, Photography",
        CollegeIconImage = "https://i.pravatar.cc/100?img=1",
        Class = "MCA - B"
    },

    new {
        Index = 20,
        FullName = "Mansi Shah",
        DOB = "2006-02-03",
        Gender = "Female",
        BloodGroup = "B-",
        PassportPhoto = "https://randomuser.me/api/portraits/women/24.jpg",
        RollNumber = "BCA009",
        Email = "mansi@gmail.com",
        PhoneNumber = "9876543229",
        PermanentAddress = "Vesu, Surat, Gujarat",
        ParentName = "Alpesh Shah",
        ParentContactNumber = "9876500030",
        Course = "BCA",
        Semester = 5,
        CollegeName = "ABC College of Computer Applications",
        GPA = 9.3,
        AdmissionNumber = "202407100510020",
        EmergencyName = "Alpesh Shah",
        EmergencyNumber = "9876500030",
        Hobbies = "Music, Reading, Painting",
        CollegeIconImage = "https://i.pravatar.cc/100?img=1",
        Class = "BCA - C"
    }
};


    public IActionResult Students(){
        ViewBag.Students = students;
        return View();
    }   

    public IActionResult Profile(String Email)
    {

        var user = students.FirstOrDefault((c => c.Email == Email));
        if (user == null)
        {
            return NotFound("User is not found");
        }

        ViewBag.user = user;
        return View();
    }

    public IActionResult Edit()
    {
        return View();
    }

    public IActionResult Delete()
    {
        return View();
    }

    public IActionResult IDCard(String Email)
    {
        var user = students.FirstOrDefault((c => c.Email == Email));
        if(user == null)
        {
            return NotFound("User Not Found");
        }

        ViewBag.user = user;
        return View();
    }

    

 

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
