namespace server.Entities;

public class Event
{
    public int Id { get; set; }
    public string Speakers { get; set; }
    public string Description { get; set; }
<<<<<<< HEAD
<<<<<<< HEAD
    public string Time { get; set; }
    public string AuthorUsername { get; set; }
    public string Place { get; set; }
    public string PictureUrl { get; set; }
=======
=======
>>>>>>> 95e8f6d94275e0d193004a8a0340148a48ca3370
    public DateTime Time { get; set; }

    public string Place { get; set; }
    public string PictureUrl { get; set; }

    public string UserId { get; set; }
    public virtual User User { get; set; }
    
    public virtual ICollection<Comment> Comments { get; set; }
    
    public virtual ICollection<Like> Likes { get; set; }
<<<<<<< HEAD
>>>>>>> 95e8f6d94275e0d193004a8a0340148a48ca3370
=======
>>>>>>> 95e8f6d94275e0d193004a8a0340148a48ca3370
}