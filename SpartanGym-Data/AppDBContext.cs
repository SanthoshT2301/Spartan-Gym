using Microsoft.EntityFrameworkCore;
using SpartanGym_Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpartanGym_Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> option) : base(option) { }

        protected void Onconfiguration(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=Z14-55N;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Application Name=\"SQL Server Management Studio\";Command Timeout=0");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Fee> Fees {  get; set; }
        public DbSet<Attendance> Attendances { get; set; } 
        public DbSet<DeadLines> DeadLines { get; set; }
        public DbSet<Events> Events { get; set; }
        public DbSet<OrderHistory> OrderHistorys { get; set; }
        public DbSet<OrderItems> OrderItems { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<OrderStatus> OrderStatus { get; set; }
        public DbSet<PaymentStatus> PaymentStatus { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<Supplements> Supplements { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(u=>u.UserId);
            modelBuilder.Entity<Role>().HasKey(r => r.RoleId);
            modelBuilder.Entity<Fee>().HasKey(r => r.FeeId);
            modelBuilder.Entity<Attendance>().HasKey(r => r.AttendanceId);
            modelBuilder.Entity<DeadLines>().HasKey(d => d.DeadLineId);
            modelBuilder.Entity<Events>().HasKey(e => e.EventId);
            modelBuilder.Entity<OrderHistory>().HasKey(oh => oh.OrderHistoryid);
            modelBuilder.Entity<OrderItems>().HasKey(oi => oi.OrderItemId);
            modelBuilder.Entity<Orders>().HasKey(o => o.OrderId);
            modelBuilder.Entity<OrderStatus>().HasKey(o => o.OrderStatusId);
            modelBuilder.Entity<PaymentStatus>().HasKey(p => p.StatusId);
            modelBuilder.Entity<Subscription>().HasKey(o => o.SubscriptionId);
            modelBuilder.Entity<Supplements>().HasKey(o => o.SupplementId);
        }
    }
}
