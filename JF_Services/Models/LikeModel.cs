using System;
using System.ComponentModel.DataAnnotations;

namespace JF_Services.Models;

public class LikeModel
{
    [Key]    public required int LIKE_ID { get; set; }
    public int? POST_ID { get; set; }
    public int? COMMENT_ID { get; set; }
    public required UserModel LIKER { get; set; }
    public required DateTime LIKE_DATE { get; set; }
}
