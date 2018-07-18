using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MovieBox.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)] /* Data Annotations */
        public string Name { get; set; }
        public bool isSubscribedToNewsletter { get; set; }

        public DateTime? Birthdate { get; set; }
       
        public byte MembershipTypeId { get; set; }
    }
}