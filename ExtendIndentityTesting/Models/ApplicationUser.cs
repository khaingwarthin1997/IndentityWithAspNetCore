using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ExtendIndentityTesting.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser() : base() { }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int APPID { get; set; }
        public string APPUSERNAME { get; set; }
        public string FULLNAME { get; set; }
        public string APPEMAIL { get; set; }
        public string APPPHONENUM { get; set; }
        public string PASSWORD { get; set; }
        public string PROFESSIONALPHOTO { get; set; }
        public string PROFESSIONALNRC { get; set; }
        public string PROFESSIONALSIGN { get; set; }

    }
}
