using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleApplication.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string Name { get; set; }
        [StringLength(20)]
        public string LastName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        
        public int? ContactGroupId { get; set; }
        [ForeignKey("CotactGroupId")]
        public virtual ContactGroup CotactGroup { get; set; }

        /// <summary>
        /// //Unit test
        /// </summary>
        /// <returns></returns>
        public string GetFullName()
        {
            if(string.IsNullOrWhiteSpace(Name) && string.IsNullOrWhiteSpace(LastName)){
                return "[No Name]"; 
            }

            return $"{Name} {LastName}"; 
           
        }


    }
}
