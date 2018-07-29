using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MovieBox.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)] /* Data Annotations */
        public string Name { get; set; }

        public bool isSubscribedToNewsletter { get; set; }

        
        public MembershipType MembershipType { get; set; }


        [Display(Name = "Date of Birth")]
        [Min18YearsIfAMember] // Custom Validation
        public DateTime? Birthdate { get; set; }
        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }
    }
}