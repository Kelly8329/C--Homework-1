namespace HomeWork09.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TransportModel : DbContext
    {
        public TransportModel()
            : base("name=TransportModel2")
        {
        }

        public virtual DbSet<TicketFare> TicketFare { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TicketFare>()
                .Property(e => e.Fare)
                .HasPrecision(18, 0);
        }
    }
}
