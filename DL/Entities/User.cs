using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;
using System.Text;

namespace DL.Entities
{
    public class User:BaseEntity
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public int Age { get; set; }

        public string Sex { get; set;}
        public string Email { get; set; }

        public virtual ICollection<UserMessage> Messages { get; set; }

        public virtual ICollection<UserRight> Rights { get; set; }
    }
}
