using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL.Entities
{
    public class UserMessage:BaseEntity
    {
        [Required]
        [ForeignKey("User")]
        public int UserID { get; set; }
        public virtual User User { get; set; }

        [Required]
        [ForeignKey("Message")]
        public int MessageID { get; set; }
        public virtual Message Message { get; set; }
    }
}
