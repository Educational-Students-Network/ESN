namespace server.Entities;

public class Event
{
    public int Id { get; set; }
    public string Title { get; set; }
    public decimal Price { get; set; }
    public string Speakers { get; set; }
    public string Description { get; set; }
    public DateTime Time { get; set; }

    public string Place { get; set; }
    public string PictureUrl { get; set; }
    public string Link { get; set; }
    public string UserId { get; set; }
    public virtual User User { get; set; }
    
    public virtual ICollection<Comment> Comments { get; set; }
    
    public virtual ICollection<Like> Likes { get; set; }
}