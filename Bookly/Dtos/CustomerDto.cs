using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Bookly.Models;

namespace Bookly.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "* Please enter the customer name.")]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }

        public byte MembershipTypeId { get; set; }
        //[Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }
    }
}