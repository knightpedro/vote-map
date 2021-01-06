namespace VoteMap.Data.Models
{
    public class ElectorateCandidateResult : BaseModel
    {
        public int Votes { get; set; }
        public int CandidateCampaignId { get; set; }
        public CandidateCampaign CandidateCampaign { get; set; }
    }
}
