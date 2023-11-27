using System.ComponentModel.DataAnnotations;

namespace server.DTOs;

<<<<<<< HEAD
=======

>>>>>>> 95e8f6d94275e0d193004a8a0340148a48ca3370
public class CreateEventDto
{
    [Required]
    public int Id { get; set; }
<<<<<<< HEAD
    [Required]
    public string Speakers { get; set; }
    [Required]
    public string Description { get; set; }
    [Required]
    [Timestamp]
    public string Time { get; set; }
    [Required]
    public string AuthorUsername { get; set; }
    [Required]
    public string Place { get; set; }
    [Required]
=======
    public string Speakers { get; set; }
    public string Description { get; set; }
    public DateTime Time { get; set; }
    public string Place { get; set; }
>>>>>>> 95e8f6d94275e0d193004a8a0340148a48ca3370
    public string PictureUrl { get; set; }
}