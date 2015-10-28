namespace School.Model
{
    using System.ComponentModel.DataAnnotations;

    public class Course
    {
        [Key] // Works without it, too
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

         [MaxLength(100)]
        public string Description { get; set; }

         [MaxLength(30)]
        public string Materials { get; set; }
    }
}
