using System;

namespace JF_Services.Models;

public class LikeModel
{
    public int? POST_ID  { get; set; }
    public int? COMMENT_ID { get; set; }
    public required int LIKE_ID { get; set; }
    public required UserModel LIKER { get; set; }
    public required DateTime LIKE_DATE { get; set; }
}
