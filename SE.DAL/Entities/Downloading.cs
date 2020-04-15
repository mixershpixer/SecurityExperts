using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SE.DAL.Entities
{
    public class Downloading
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

        [Required]
        public DateTime DownloadingDate { get; set; }
    }
}
