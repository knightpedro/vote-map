namespace VoteMap.Data.Models
{
    public class ElectoratePartyResult : BaseModel
    {
        public int Votes { get; set; }
        public int ElectorateId { get; set; }
        public Electorate Electorate { get; set; }
        public int PartyCampaignId { get; set; }
        public PartyCampaign PartyCampaign { get; set; }
    }
}
