using Microsoft.AspNetCore.Identity;

namespace server.Entities;

public class User : IdentityUser
{
    public virtual ICollection<Comment> Comments { get; set; }
    public virtual ICollection<Like> Likes { get; set; }
}