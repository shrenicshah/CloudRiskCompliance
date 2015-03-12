﻿using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using CloudRiskCompliance.DomainClasses;
using Microsoft.AspNet.Identity.EntityFramework;

namespace CloudRiskCompliance.DataLayer.Context
{
    public class ApplicationDbContext :
        IdentityDbContext<ApplicationUser, CustomRole, int, CustomUserLogin, CustomUserRole, CustomUserClaim>,
        IUnitOfWork
    {
        public DbSet<Category> Categories { set; get; }
        public DbSet<Product> Products { set; get; }
        public DbSet<Address> Addresses { set; get; }

        public ApplicationDbContext()
            : base("connectionString")
        {
        }

        //private static string GetConnectionString()
        //{
        //    string host = System.Web.HttpContext.Current.Request.Headers["Host"];
        //    int portNumberIndex = host.LastIndexOf(':');
        //    if (portNumberIndex > 0)
        //    {
        //        host = host.Substring(0, portNumberIndex);
        //    }

        //    return string.Format(@"Data Source=DEVPC-PC\SQLEXPRESS;Initial Catalog={0};Integrated Security=true", host);
        //}

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ApplicationUser>().ToTable("Users");
            builder.Entity<CustomRole>().ToTable("Roles");
            builder.Entity<CustomUserClaim>().ToTable("UserClaims");
            builder.Entity<CustomUserRole>().ToTable("UserRoles");
            builder.Entity<CustomUserLogin>().ToTable("UserLogins");
        }

        public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }

        public int SaveAllChanges()
        {
            return base.SaveChanges();
        }

        public IEnumerable<TEntity> AddThisRange<TEntity>(IEnumerable<TEntity> entities) where TEntity : class
        {
            return ((DbSet<TEntity>)this.Set<TEntity>()).AddRange(entities);
        }

        public void MarkAsChanged<TEntity>(TEntity entity) where TEntity : class
        {
            Entry(entity).State = EntityState.Modified;
        }

        public IList<T> GetRows<T>(string sql, params object[] parameters) where T : class
        {
            return Database.SqlQuery<T>(sql, parameters).ToList();
        }

        public void ForceDatabaseInitialize()
        {
            this.Database.Initialize(force: true);
        }
    }
}