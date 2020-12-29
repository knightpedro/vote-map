using System.Collections.Generic;

namespace VoteMap.Data.Models
{
    public class Candidate : BaseModel
    {
        public string Name { get; set; }
        public List<CandidateCampaign> Campaigns { get; set; }
    }
}
