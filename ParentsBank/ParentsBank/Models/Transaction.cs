using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ParentsBank.Models
{
    public class Transaction
    {
        public int ID { get; set; }
        public int AccountId { get; set; }
        public string Account { get; set; }

        [CustomValidation(typeof(Transaction), "ValidateFD")]
        [CustomValidation(typeof(Transaction), "ValidateCY")]
        public DateTime TransactionDate { get; set; }

        [Range(0,999999999999)]
        public decimal Amount { get; set; }

        [Required]
        public string Note { get; set; }

        public static ValidationResult ValidateCY(DateTime TransactionDate, ValidationContext context)
        {
            if (TransactionDate.Year < DateTime.Now.Year)
            {
                return new ValidationResult("Transaction Date year cannot be a previous year");
            }

            return ValidationResult.Success;
        }

        public static ValidationResult ValidateFD(DateTime TransactionDate, ValidationContext context)
        {
            if (TransactionDate.Year > DateTime.Now.Year)
            {
                return new ValidationResult("Transaction Date year cannot be in the future");
            }

            return ValidationResult.Success;
        }
    }

}