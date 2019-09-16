using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AllianceBankMVC_bmiles.Models
{
    [Table("Loans")]
    public class Loan
    {
        [Key]
        public int LoanId { get; set; }
        public string LoanName { get; set; }
        public string LoanType { get; set; }
        public int term { get; set; }
        public double rate { get; set; }

    }
}