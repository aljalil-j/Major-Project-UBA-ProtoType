using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Major_Project_UBA_ProtoType.Models
{
    public class Transaction
    {
        [Required]
        public int Id { get; set; }

        [Display(Name = "Transaction Date")]
        [DataType(DataType.Time)]
        public DateTime StartDate { get; set; }

        [Display(Name = "Account Number")]
        [Required]
        // [ValidUniqueValue]
        [StringLength(60, MinimumLength = 3)]
        [RegularExpression("^[0-9]*$", ErrorMessage = "must be numeric")]
        public string AccountNumber { get; set; }

        public string TransactionType { get; set; }

        [Display(Name = "Amount")]
        [DataType(DataType.Currency)]
        [Required]
        public decimal Amount { get; set; }

        public string Location { get; set; }
        public string Item_purchase { get; set; }


    }
}
