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
        public String Full_Name { get; set; }

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
        private List<LineUp> ScoreCards { get; set; }
    }
}
