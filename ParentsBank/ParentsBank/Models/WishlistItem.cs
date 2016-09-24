using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ParentsBank.Models
{
    public class WishlistItem
    {
        public int ID { get; set; }
        public int AccountId { get; set; }
        public string Account { get; set; }
        public DateTime DateAdded { get; set; }

        [Required]
        public decimal Cost { get; set; }

        [Required]
        public string Description { get; set; }

        [Url]
        public string Link { get; set; }
        public Boolean Purchased { get; set; }

        public void InterestEarned(decimal balance, decimal InterestRate) {/* Method statements here */ }
    }
}