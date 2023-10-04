using Bliss_Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Bliss_Infrastructure.Data
{
    public class BlissDBContext : DbContext
    {
        public BlissDBContext()
        {
            
        }

        public BlissDBContext(DbContextOptions options):base(options)
        {
        }

        public DbSet<Bank> Banks { get; set; }
        public DbSet<IncomeCategory> IncomeCategories { get; set; }
        public DbSet<ExpenseCategory> ExpenseCategoroes{ get; set; }
        public DbSet<Jar> Jars{ get; set; }
        public DbSet<Income> Incomes { get; set; }
        public DbSet <Expense> Expenses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Expense>().Property(e => e.Amount).HasColumnType<decimal>("decimal(10,2)");
            modelBuilder.Entity<Income>().Property(e => e.Amount).HasColumnType<decimal>("decimal(15,2)");
            modelBuilder.Entity<Jar>().Property(e => e.PercentOfIncomeAlloted).HasColumnType<decimal>("decimal(15,2)");
            modelBuilder.Entity<Jar>().Property(e => e.AllottedAmount).HasColumnType<decimal>("decimal(15,2)");
            modelBuilder.Entity<Jar>().Property(e => e.CurrentAmount).HasColumnType<decimal>("decimal(15,2)");
            modelBuilder.Entity<Jar>().Property(e => e.RemainingAmount).HasColumnType<decimal>("decimal(15,2)");


            var banks = new List<Bank>{
                new Bank{ Id =1, Name = "Maya"},
                new Bank{ Id =2, Name = "GCash"},
                new Bank{ Id =3, Name = "Cimb"},
                new Bank{ Id =4, Name = "Tonik"},
                new Bank{ Id =5, Name = "Uno"},
                new Bank{ Id =6, Name = "Komo"}
            };

            modelBuilder.Entity<Bank>().HasData(banks);

            var incomeCategories = new List<IncomeCategory>
            {
                new IncomeCategory{Id = 1, Name = "Full-time Job", Description ="Salary from fulltime job" },
                new IncomeCategory{Id = 2, Name = "Investment", Description="Stock Dividends"}
            };

            modelBuilder.Entity<IncomeCategory>().HasData(incomeCategories);

            var expenseCategories = new List<ExpenseCategory>
            {
                new ExpenseCategory{Id = 1, Name = "Food", Description ="Groceries, Dine out, etc."},
                new ExpenseCategory{Id = 2, Name = "Household Bills", Description = "Household Bills"},
                new ExpenseCategory{Id = 3, Name = "Credit Card", Description ="Credit Card payments"}
            };

            modelBuilder.Entity<ExpenseCategory>().HasData(expenseCategories);

        }


    }
}
