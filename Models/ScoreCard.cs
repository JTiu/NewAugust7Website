using System;
using System.ComponentModel.DataAnnotations;

namespace August7thWebsite.Models
{
    public class ScoreCard   //no direct inheritance from DB context
    {  //web.config file needs the connection string
        [Key]
        public int ScoreCardId { get; set; }
        public string FightName { get; set; }
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

        public string DeterminateFactor_R1 { get; set; }
        public string DeterminateFactor_R2 { get; set; }
        public string DeterminateFactor_R3 { get; set; }
        public string DeterminateFactor_R4 { get; set; }
        public string DeterminateFactor_R5 { get; set; }
        public string DeterminateFactor_R6 { get; set; }
        public string DeterminateFactor_R7 { get; set; }
        public string DeterminateFactor_R8 { get; set; }
        public string DeterminateFactor_R9 { get; set; }
        public string DeterminateFactor_R10 { get; set; }
        public string DeterminateFactor_R11 { get; set; }
        public string DeterminateFactor_R12 { get; set; }

        public string FirstNameOnCard { get; set; }
        public string LastNameOnCard { get; set; }
        public DateTime DateCreated { get; set; }
        public string Boxer1 { get; set; }
        public string Boxer2 { get; set; }
        public ScoreCard()
        {
            DateCreated = DateTime.Today;
        }
    }
}
