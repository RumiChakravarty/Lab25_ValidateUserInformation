using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Lab25_ValidateUserInformation.Models
{
    public class Student
    {
        [Required(ErrorMessage ="Non empty, only characters, up to 20 characters.")]
        [StringLength(20, ErrorMessage ="up to 20 character")]
        
        public string Name { set; get; }
       [Required(ErrorMessage = "Only interger, value from 1 to 150")]
        [Range(1, 150, ErrorMessage = "Can only be between 0 .. 150")]
        public int Age { set; get; }
    }
}