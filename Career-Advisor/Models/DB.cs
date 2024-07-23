using Elfie.Serialization;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
using System;
namespace Career_Advisor.Models
{
    public class DB : DbContext
    {
        public DB(DbContextOptions<DB> context) : base(context) {
        }
        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-CKEG5I8\\SQLEXPRESS; Database=IKGAI, Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        DbSet<Comment> comments { get; set; }

        DbSet<Career> careers { get; set; }


    }

}
