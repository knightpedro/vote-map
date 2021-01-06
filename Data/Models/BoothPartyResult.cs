namespace VoteMap.Data.Models
{
    public class BoothPartyResult : BaseModel
    {
        public int Votes { get; set; }
        public int BoothId { get; set; }
        public Booth Booth { get; set; }
        public int PartyCampaignId { get; set; }
        public PartyCampaign PartyCampaign { get; set; }
    }
}
