namespace DataAccess
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ExpenseModel : DbContext
    {
        public ExpenseModel()
            : base("name=ExpenseModel")
        {
        }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Expense> Expense { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Category>()
                .HasMany(e => e.Expense)
                .WithRequired(e => e.Category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Expense>()
                .Property(e => e.Sum)
                .HasPrecision(10, 4);
        }
    }
}
