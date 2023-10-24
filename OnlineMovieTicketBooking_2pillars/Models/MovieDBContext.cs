using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace OnlineMovieTicketBooking_2pillars.Models
{
    public partial class MovieDBContext : DbContext
    {
        public MovieDBContext()
            : base("name=MovieDBContext1")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<ScheduledMovie> ScheduledMovies { get; set; }
        public virtual DbSet<Seat> Seats { get; set; }
        public virtual DbSet<SeatDetail> SeatDetails { get; set; }
        public virtual DbSet<SeatType> SeatTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Reservations)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Accounts)
                .WithRequired(e => e.Employee)
                .HasForeignKey(e => e.UserID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Movies)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Movie>()
                .HasMany(e => e.ScheduledMovies)
                .WithRequired(e => e.Movie)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Reservation>()
                .Property(e => e.TotalPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Reservation>()
                .HasMany(e => e.SeatDetails)
                .WithRequired(e => e.Reservation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.Accounts)
                .WithRequired(e => e.Role)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ScheduledMovie>()
                .Property(e => e.Date)
                .IsUnicode(false);

            modelBuilder.Entity<ScheduledMovie>()
                .Property(e => e.Time)
                .IsUnicode(false);

            modelBuilder.Entity<ScheduledMovie>()
                .HasMany(e => e.Reservations)
                .WithRequired(e => e.ScheduledMovie)
                .HasForeignKey(e => e.ScheduleID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Seat>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Seat>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Seat>()
                .HasMany(e => e.SeatDetails)
                .WithRequired(e => e.Seat)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SeatType>()
                .HasMany(e => e.Seats)
                .WithRequired(e => e.SeatType)
                .WillCascadeOnDelete(false);
        }
    }
}
