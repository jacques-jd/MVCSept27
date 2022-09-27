using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCSept27.Models
{
    public class Book
    {
        //public int ID { get; set; }
        [Key]
        public int Book_ID { get; set; }

        //ISBN
        [Required]
        [StringLength(11, MinimumLength =7, ErrorMessage ="Use a 7 or 11 digit ISBN string")]
        public string ISBN { get; set; }

        //Title
        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        //Author
        [Required]
        public string AuthorName { get; set; }

        //PublishedDate
        [Required]
        public DateTime PublishedDate { get; set; }

        [Required]
        [StringLength(20, MinimumLength =3)]
        public string Genre { get; set; }
    }

    public class Author
    {
        public int AuthorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}