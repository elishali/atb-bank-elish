﻿using Atbbank.WebUI.AppCode.Services;
using Atbbank.WebUI.Models.Entities;
using Atbbank.WebUI.Models.Entities.Commons;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Atbbank.WebUI.Models.Persistences
{
    public class DataContext : IdentityDbContext<AppUser>
    {
        private readonly IDateTimeService dateTimeService;
        private readonly IIdentityService identityService;

        public DataContext(DbContextOptions options,IDateTimeService dateTimeService,IIdentityService identityService)
            :base(options)
        {
            this.dateTimeService = dateTimeService;
            this.identityService = identityService;
        }

        public DbSet<Card> Cards { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<UsefulCard> UsefulCards { get; set; }
      

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DataContext).Assembly);
        }

        public override int SaveChanges()
        {

            var changes = this.ChangeTracker.Entries<IAuditableEntity>();

            if (changes != null) { 
            
                foreach (var entry in changes.Where(m=>m.State==EntityState.Added || m.State==EntityState.Modified || m.State==EntityState.Deleted))
                {
                    switch(entry.State)
                    {
                        case EntityState.Added:
                            entry.Entity.CreatedBy = identityService.GetPrincipalId();
                            entry.Entity.CreatedAt = dateTimeService.ExecutingTime;
                            break;
                        case EntityState.Modified:
                            entry.Entity.LastModifiedBy = identityService.GetPrincipalId();
                            entry.Entity.LastModifiedAt = dateTimeService.ExecutingTime;
                            break;
                        case EntityState.Deleted:
                            entry.State = EntityState.Modified;
                            entry.Entity.DeletedBy = identityService.GetPrincipalId();
                            entry.Entity.DeletedAt = dateTimeService.ExecutingTime;
                            break;
                        default:

                        break;

                    }

                }
            
            }

            return base.SaveChanges();
        }
    }

   
}
