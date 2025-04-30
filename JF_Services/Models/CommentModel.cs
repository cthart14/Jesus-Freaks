using System;
using System.ComponentModel.DataAnnotations;

namespace JF_Services.Models;

public class CommentModel
{
    [Key]   public required int COMMENT_ID { get; set; }
    public required UserModel COMMENTER { get; set; }
    public int? POST_ID { get; set; }
    public int? REPLY_TO_COMMENT_ID { get; set; }
    public required string COMMENT_TEXT { get; set; }
    public required DateTime COMMENT_DATE { get; set; }

}
