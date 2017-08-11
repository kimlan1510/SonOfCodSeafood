using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SonOfCodSeafood.Models
{
    [Table("NewsLetters")]
    public class NewsLetter
    {
        [Key]
        public int NewsLetterId { get; set; }
        [Display (Name = "Email Address")]
        [Required(ErrorMessage = "Email is required")]
        [RegularExpression(@"^[\w -\.] +@([\w -] +\.)+[\w-]{2,4}$", ErrorMessage = "Please provide a valid email address!")]
        
        public string Email { get; set; }
    }
}
