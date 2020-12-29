using System;
using System.Collections.Generic;

namespace VoteMap.Data.Models
{
    public class Election : BaseModel
    {
        public DateTime Date { get; set; }
        public int PartyValidVotes { get; set; }
        public int PartyInformalVotes { get; set; }
        public int CandidateValidVotes { get; set; }
        public int CandidateInformalVotes { get; set; }

        public List<BoothVote> BoothVotes { get; set; }
        public List<CandidateCampaign> CandidateCampaigns {  get; set; }
        public List<ElectorateVote> ElectorateVotes { get; set; }
        public List<PartyCampaign> PartyCampaigns { get; set; }

    }
}
