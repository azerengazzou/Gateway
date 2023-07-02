using JwtAuthenticationManager.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace JwtAuthenticationManager.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<UserAccount> Users { get; set; }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserAccount>().HasData(
               new UserAccount() { UserId = 1, UserName = "azerDoctor", Password = "00000000", Role = "Doctor",FirstName="Azer",LastName="Engazzou",Identifiant="012345",Email="email@email.com"},
               new UserAccount() { UserId = 2, UserName = "azerAdministrator", Password = "00000000", Role = "Administrator", FirstName = "Azer", LastName = "Engazzou", Identifiant = "012345", Email = "email@email.com" },
               new UserAccount() { UserId = 3, UserName = "azerDoctor", Password = "00000000", Role = "Support", FirstName = "Azer", LastName = "Engazzou", Identifiant = "012345", Email = "email@email.com" }
           );
        }
    }
}
