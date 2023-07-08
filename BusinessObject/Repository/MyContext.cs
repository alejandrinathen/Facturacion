using System.Data.Entity;
using BusinessObject.Models;


namespace BusinessObject.Repository
{
    public class MyContext : DbContext
    {
        public MyContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().ToTable("Customers");
            modelBuilder.Entity<CustomerType>().ToTable("CustomerTypes");
            modelBuilder.Entity<Invoice>().ToTable("Invoice");
            modelBuilder.Entity<InvoiceDetail>().ToTable("InvoiceDetail");
            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<CustomerType> CustomerType { get; set; }
        public virtual DbSet<Invoice> Invoice { get; set; }
        public virtual DbSet<InvoiceDetail> InvoiceDetail { get; set; }
    }
}
