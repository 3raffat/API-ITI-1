using System.ComponentModel.DataAnnotations;

namespace API_ITI_1.Models
{
    public class Courses
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string? Crs_Name { get; set; }
        [MaxLength(150)]
        public string? Crs_Description { get; set; }
        public int? Crs_Duration { get; set; }
    }
}
