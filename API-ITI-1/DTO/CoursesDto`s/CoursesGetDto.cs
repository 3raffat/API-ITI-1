using System.ComponentModel.DataAnnotations;

namespace API_ITI_1.DTO.CoursesDto_s
{
    public class CoursesGetDto
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string? Name { get; set; }
        [MaxLength(150)]
        public string? Description { get; set; }
    }
}
