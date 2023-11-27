namespace server.Entities;

public class Event
{
    public int Id { get; set; }
    public string Speakers { get; set; }
    public string Description { get; set; }
    public string Time { get; set; }
    public string AuthorUsername { get; set; }
    public string Place { get; set; }
    public string PictureUrl { get; set; }
}