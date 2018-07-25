using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MovieBox.Models;

namespace MovieBox.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer customer { get; set; }
    }
}