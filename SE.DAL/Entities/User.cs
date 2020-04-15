using SE.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SE.DAL.Entities
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Surname { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(100)]
        public string Password { get; set; }

        [Required]
        public Enums.Role Role { get; set; }

        [Required] 
        public bool IsConfirmed { get; set; }


        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Downloading> Downloadings { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }
        public virtual ICollection<Material> Materials { get; set; }
    }
}
