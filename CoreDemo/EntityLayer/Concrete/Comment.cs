﻿using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }
        public string CommentUserName { get; set; }
        public string CommentMail { get; set; }
        public string CommentContent { get; set; }
        public DateTime CommentDate { get; set; }
		public int BlogScore { get; set; }
		public bool CommentStatus { get; set; } = true;
        public int BlogID { get; set; }
        public Blog Blog { get; set; }
    }
}
