using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Box_Themis_Capstone.Models
{
    public class Judge
    {
        [Key]
        public int Id { get; set; }
        public String Full_Name { get; set; }

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
        private List<ScoreCard> ScoreCards { get; set; }
    }
}
