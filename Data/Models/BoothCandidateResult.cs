namespace VoteMap.Data.Models
{
    public class BoothCandidateResult : BaseModel
    {
        public int Votes { get; set; }
        public int BoothId { get; set; }
        public Booth Booth { get; set; }
        public int CandidateCampaignId { get; set; }
        public CandidateCampaign CandidateCampaign { get; set; }
    }
}
