using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication15.Models
{
    public class LoggerContext : DbContext
    {
        public LoggerContext() : base("DefaultConnection")
        {
        }

        public DbSet<ExceptionDetail> ExceptionDetails { get; set; }
        public DbSet<ReauesDetail> ReauesDetails { get; set; }
    }
}