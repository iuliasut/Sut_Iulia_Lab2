using System.ComponentModel.DataAnnotations;

namespace Sut_Iulia_Lab2.Models
{
    public class Author
    {
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string? FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string? LastName { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        public List<Book> Books { get; set; } = new List<Book>();

       
    

}
}
