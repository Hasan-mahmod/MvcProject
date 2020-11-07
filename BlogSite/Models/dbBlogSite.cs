using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogSite.Models
{
    public class dbBlogSite:DbContext
    {
        public DbSet<News> News { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }


    public class News
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string FeatureImg { get; set; }
        public DateTime PostDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public string PostIp { get; set; }
        public string UserName { get; set; }
        public int CatId { get; set; }
        [ForeignKey("CatId")]
        public virtual Category Category { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }

    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int ParentId { get; set; }
        public virtual ICollection<News> News { get; set; }
    }
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string commentsIp { get; set; }
        public string UserName { get; set; }
        public int NewsId { get; set; }
        [ForeignKey("NewsId")]
        public virtual News News { get; set; }

    }
}
