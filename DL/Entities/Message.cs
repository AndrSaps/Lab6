using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Text;

namespace DL.Entities
{
    public class Message: BaseEntity
    {
        [Required]
        public string Text { get; set; }

        public string Author { get; set; }

        public string? Status { get; set; }

        public virtual ICollection<UserMessage> Users { get; set; }

    } 
}
