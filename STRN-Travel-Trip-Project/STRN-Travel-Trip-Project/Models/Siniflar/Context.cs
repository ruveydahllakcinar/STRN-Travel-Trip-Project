using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace STRN_Travel_Trip_Project.Models.Siniflar
{
    public class Context : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<AdressBlog> AdressBlogs { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Abouts> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Comments> Comments { get; set; }

    }
}