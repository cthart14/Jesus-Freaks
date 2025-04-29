using System;

namespace DevotionalBlog.Services.Models;

public class PostModel
{   
    public required UserModel USER { get; set; }
    public required int POST_ID { get; set; }
    public string CAPTION { get; set; }
    public required string POST_DATA { get; set; }
    public required DateTime POST_DATE { get; set; }
    public ICollection<CommentModel> COMMENTS { get; set; }
    public ICollection<LikeModel> LIKES { get; set; }
    public ICollection<UserModel> TAGGED_USERS { get; set; }
}
