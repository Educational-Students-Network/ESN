namespace server.Entities;

public class Comment
{
    public int CommentId { get; set; }
    public string Text { get; set; }
    public DateTime Date { get; set; }

    // Add other comment-related properties as needed

    public string UserId { get; set; }
    public virtual User User { get; set; }

    public int EventId { get; set; }
    public virtual Event Event { get; set; }
}