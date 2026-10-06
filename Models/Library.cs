using System.ComponentModel.DataAnnotations;
namespace practicalsAsProject.Models;

    public class Library
    {
        public int LibraryId { get; set; }   // Primary Key

        [Required(ErrorMessage = "Library name is required")]
        public string LibraryName { get; set; }

        [Required(ErrorMessage = "Location is required")]
        public string Location { get; set; }

        [Required(ErrorMessage = "Library code is required")]
        public string LibraryCode { get; set; }

        public bool IsActive { get; set; }
    }
