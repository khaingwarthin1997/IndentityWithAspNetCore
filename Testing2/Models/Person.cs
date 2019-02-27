using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Testing2.Models
{
    public class Person : IdentityUser<int>
    {

        public Person() : base() { }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public  int PID { get; set; }
        //
        public string Name { get; set; }
        //
        public override string Email { get; set; }
        //
        public string PhoneNum { get; set; }
        //
        public string ProfessionalPhoto { get; set; }
        //
        public string ProfessionalNrc { get; set; }
        //
        public string ProfessionalSignature { get; set; }
        //
        public string Password { get; set; }
    }
}
