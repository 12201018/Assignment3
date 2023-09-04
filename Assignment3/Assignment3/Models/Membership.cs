using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignment3.Models
{
    public class Membership
    {
        public int Id { get; set; }

        [Required]
        public MembershipType Type { get; set; }

        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        // Foreign key
        public int MemberId { get; set; }
        public Member Member { get; set; }
    }

    public enum MembershipType
    {
        Monthly,
        Quarterly,
        Yearly
    }
}