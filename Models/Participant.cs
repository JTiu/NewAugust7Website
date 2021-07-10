using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace August7thWebsite.Models
{
    public class Participant
    {
        [Key]
        public int Id { get; set; }
        public String First_Name { get; set; }
        public String Last_Name { get; set; }
        public String Ring_Name { get; set; }
        public String Weight { get; set; }
        public String Wins { get; set; }
        public String Losses { get; set; }
        public String Draw { get; set; }
        public String KnockOuts { get; set; }

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
        private List<LineUp> ScoreCards { get; set; }
    }
}
