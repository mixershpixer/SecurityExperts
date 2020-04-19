using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SE.DAL.Entities
{
    public class Comment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required]
        public Guid UserId { get; set; }
        public User User { get; set; }

        [Required]
        public Guid MaterialId { get; set; }
        public Material Material { get; set; }

        [Column(TypeName = "datetime2")]
        [Required] public DateTime Date { get; set; }

        [Required]
        [StringLength(1000)]
        public string Text { get; set; }
    }
}
