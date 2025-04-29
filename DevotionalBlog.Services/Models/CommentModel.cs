using System;

namespace DevotionalBlog.Services.Models;

public class CommentModel
{
    public required UserModel COMMENTOR { get; set; }
    public int? POST_ID { get; set; }
    public int? REPLY_TO_COMMENT_ID { get; set; }
    public required int COMMENT_ID { get; set; }
    public required string COMMENT_TEXT { get; set; }
    public required DateTime COMMENT_DATE { get; set; }

}
