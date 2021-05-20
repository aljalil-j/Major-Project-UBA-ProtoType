using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Major_Project_UBA_ProtoType.Models;

namespace Major_Project_UBA_ProtoType.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Major_Project_UBA_ProtoType.Models.DataModel> Data { get; set; }

        public DbSet<Major_Project_UBA_ProtoType.Models.Transaction> Transaction { get; set; }
    }
}
