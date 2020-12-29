using System.Collections.Generic;

namespace VoteMap.Data.Models
{
    public class Party : BaseModel
    {
        public string Name { get; set; }
        public List<CandidateCampaign> CandidateCampaigns { get; set; }
        public List<PartyCampaign> PartyCampaigns { get; set; }
    }
}
