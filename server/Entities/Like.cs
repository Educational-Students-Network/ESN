﻿namespace server.Entities;

public class Like
{
    public int LikeId { get; set; }

    public string UserId { get; set; }
    public virtual User User { get; set; }

    public int EventId { get; set; }
    public virtual Event Event { get; set; }
}
