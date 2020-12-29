using System.Collections.Generic;

namespace VoteMap.Data.Models
{
    public class Party : BaseModel
    {
        public string Name { get; set; }
        public List<PartyCampaign> Campaigns { get; set; }
    }
}
