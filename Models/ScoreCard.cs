using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Box_Themis_Capstone.Models
{
    public class ScoreCard   //no direct inheritance from DB context
    {  //web.config file needs the connection string
        [Key]
        public int ScoreCardId { get; set; }
        public int FightId { get; set; }
        public string UserId { get; set; }
        public int Round_1_B1 { get; set; }
        public int Round_1_B2 { get; set; }
        public int Round_2_B1 { get; set; }
        public int Round_2_B2 { get; set; }
        public int Round_3_B1 { get; set; }
        public int Round_3_B2 { get; set; }
        public int Round_4_B1 { get; set; }
        public int Round_4_B2 { get; set; }
        public int Round_5_B1 { get; set; }
        public int Round_5_B2 { get; set; }
        public int Round_6_B1 { get; set; }
        public int Round_6_B2 { get; set; }
        public int Round_7_B1 { get; set; }
        public int Round_7_B2 { get; set; }
        public int Round_8_B1 { get; set; }
        public int Round_8_B2 { get; set; }
        public int Round_9_B1 { get; set; }
        public int Round_9_B2 { get; set; }
        public int Round_10_B1 { get; set; }
        public int Round_10_B2 { get; set; }
        public int Round_11_B1 { get; set; }
        public int Round_11_B2 { get; set; }
        public int Round_12_B1 { get; set; }
        public int Round_12_B2 { get; set; }
        public int Total_B1 { get; set; }
        public int Total_B2 { get; set; }

    }
}