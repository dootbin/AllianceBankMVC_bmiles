using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AllianceBankMVC_bmiles.Models
{
    public class BankingMVCDbContext : DbContext
    {
        public DbSet<InterestRate> InterestRates { get; set; }
        public DbSet<Loan> Loans { get; set; }
    }
}