using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace August7thWebsite.Models
{
    public class LineUp   //no direct inheritance from DB context
    {  //web.config file needs the connection string
        [Key]
        public int Id { get; set; }
        public string Date { get; set; }
        public string Match_1_B1 { get; set; }
        public string Match_1_B2 { get; set; }
        public string Match_2_B1 { get; set; }
        public string Match_2_B2 { get; set; }
        public string Match_3_B1 { get; set; }
        public string Match_3_B2 { get; set; }
        public string Match_4_B1 { get; set; }
        public string Match_4_B2 { get; set; }

        public string Match_5_B1 { get; set; }
        public string Match_5_B2 { get; set; }
        public string Match_6_B1 { get; set; }
        public string Match_6_B2 { get; set; }

        public string Match_7_B1 { get; set; }
        public string Match_7_B2 { get; set; }
    }
}