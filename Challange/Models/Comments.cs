using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;



namespace Challange.Models
{
    public class SampleComments : DbContext
    {
        public SampleComments() : base("Challange") { }
        public DbSet<Comment> Comments { get; set; }
    }
    public class Comment
    {
        public int postId { get; set; }

        public int id { get; set; }

        public string name { get; set; }

        public string email { get; set; }

        public string body { get; set; }

    }
}