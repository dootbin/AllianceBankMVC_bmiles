using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AllianceBankMVC_bmiles.Models
{
    [Table("InterestRates")]
    public class InterestRate
    {
        [Key]
        public int RateID { get; set; }
        public string RateType { get; set; }
        public string RateDesc { get; set; }
        public double Rate { get; set; }
    }
}