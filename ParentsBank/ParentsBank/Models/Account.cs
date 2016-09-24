using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ParentsBank.Models
{
    public class Account
    {
        public int ID { get; set; }

        [StringLength(5)]
        [EmailAddress]
        public string Owner { get; set; }

        [EmailAddress]
        public string Recipient { get; set; }
        public string Name { get; set; }
        public DateTime OpenDate { get; set; }

            
        public decimal InterestRate { get; set; }
        public decimal balance { get; set; }

        public void InterestEarned (decimal balance, decimal InterestRate) {/* Method statements here */ }
    }
}