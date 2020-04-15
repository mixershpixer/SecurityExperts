using SE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SE.DAL.Entities
{
    public class Material
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public Guid UserId { get; set; }
        public User User { get; set; }

        [Required]
        [StringLength(500)]
        public string Description { get; set; }

        [Required]
        [StringLength(500)]
        public string Status { get; set; }

        [Required]
        public DateTime PublishingDate{ get; set; }

        [Required]
        public Enums.Auditory Auditory { get; set; }

        [Required]
        public string Theme { get; set; }

        [Required]
        public Enums.Type Type { get; set; }

        [Required]
        [StringLength(500)]
        public string DownloadingLink { get; set; }

        public byte[] Picture { get; set; }

        [Required]
        [StringLength(500)]
        public string SourceOfInformation { get; set; }

        [Required]
        public double Rating { get; set; }

        [Required]
        public int DownloadsCount { get; set; }
    }
}
