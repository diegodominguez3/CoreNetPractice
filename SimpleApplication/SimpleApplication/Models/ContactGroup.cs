using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; 

namespace SimpleApplication.Models
{
    public class ContactGroup
    {
        [Key]
        public int Id { get; set;}
        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        public string Description { get; set; }
        
        public virtual List<Contact> Contacts { get; set; }
    }
}
