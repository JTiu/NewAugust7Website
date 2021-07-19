using August7thWebsite.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace August7thWebsiteVS.Models
{
    public class ParticipantViewModel: Participant
    {
        public IFormFile PictureParticipant { get; set; }
    }
}
