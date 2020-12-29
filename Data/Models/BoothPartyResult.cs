namespace VoteMap.Data.Models
{
    public class BoothPartyResult : BaseModel
    {
        public int Votes { get; set; }
        public string BoothId { get; set; }
        public Booth Booth { get; set; }
        public string PartyCampaignId { get; set; }
        public PartyCampaign PartyCampaign { get; set; }
    }
}
