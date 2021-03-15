using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Manage_Deck___PMS.Models;

namespace Manage_Deck___PMS.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Manage_Deck___PMS.Models.Task> Task { get; set; }
        public DbSet<Manage_Deck___PMS.Models.Project> Project { get; set; }
        public DbSet<Manage_Deck___PMS.Models.Checklist> Checklist { get; set; }
    }
}
