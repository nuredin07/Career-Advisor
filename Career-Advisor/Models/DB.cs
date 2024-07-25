using Elfie.Serialization;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
using System;
using System.ComponentModel.DataAnnotations;
namespace Career_Advisor.Models
{
    public class DB : DbContext
    {

        public DB(DbContextOptions<DB> context) : base(context) {
        }

        public DbSet<Career> Careers { get; set; }

        public DbSet<Comment> Comments { get; set; }

    }
}
       


 
