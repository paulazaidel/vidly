using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Membership Type")]
        public string Name { get; set; }

        [Display(Name = "Sign up free")]
        public short SignUpFree { get; set; }

        [Display(Name = "Duration in months")]
        public byte DurationInMonths { get; set; }

        [Display(Name = "Discount rate")]
        public byte DiscountRate { get; set; }

        public static readonly byte Unknown = 0;
        public static readonly byte PayAsYouGo = 1;
    }
}