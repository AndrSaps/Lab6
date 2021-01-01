using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DL.Entities
{
    public enum RightTypes
    {
        Moral,
        Positive,
        Negative,
        Civil,
        Economic
    }

    public class Right: BaseEntity
    {
        [Required]
        public string Text { get; set; }

        public RightTypes? Category { get; set; }

        public int? AgeFrom { get; set; }

        public int? AgeTo { get; set; }


        public virtual ICollection<UserRight> Users { get; set; }
    }
}
