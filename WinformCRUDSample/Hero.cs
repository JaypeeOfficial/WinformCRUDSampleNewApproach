using System.ComponentModel.DataAnnotations;

namespace WinformCRUDSample
{
    public class Hero
    {

        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(1000)]
        public string Description { get; set; }

        [Required, MaxLength(100)]
        public string HeroType { get; set;}

        [Required, MaxLength(100)]

        public string PictureUrl { get; set; }

    }
}