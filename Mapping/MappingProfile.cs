using August7thWebsite.Models;
using August7thWebsiteVS.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace August7thWebsiteVS.Mapping
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Participant, ParticipantViewModel>();
            CreateMap<ScoreCard, CreateScorecardViewModel>();
        }

    }
}
