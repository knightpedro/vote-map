namespace VoteMap.Data.Models
{
    public class BoothCandidateResult : BaseModel
    {
        public int Votes { get; set; }
        public string BoothId { get; set; }
        public Booth Booth { get; set; }
        public string CandidateCampaignId { get; set; }
        public CandidateCampaign CandidateCampaign { get; set; }
    }
}
