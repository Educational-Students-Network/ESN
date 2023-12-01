using System.ComponentModel.DataAnnotations;

namespace server.DTOs;


public class CreateEventDto
{
    public string Speakers { get; set; }
    public string Description { get; set; }
    public DateTime Time { get; set; }
    public string Place { get; set; }
    public string PictureUrl { get; set; }
}